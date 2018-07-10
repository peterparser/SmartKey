using SmartKey.Controller.Controller.Interfaces;
using SmartKey.Log.ModelLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller
{
    public class ProtezioneDatiController : IGestoreProtezioneDati
    {
        public event EventHandler<ActionCompletedEvent> ToLog;
        private FileSystemWatcher _watcher;

        private string _path;
        public ProtezioneDatiController(string path)
        {
            _path = path;
            _watcher = new FileSystemWatcher(path);
            _watcher.NotifyFilter = NotifyFilters.LastWrite;
            _watcher.EnableRaisingEvents = true;
            // watcher.Filter = "*.*";
            _watcher.Created += ProteggiFile;
            _watcher.Changed += ProteggiFile;
        }
        public void ProteggiCartella()
        {
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
            
            DirectoryInfo dInfo = new DirectoryInfo(_path);
            DirectorySecurity security = dInfo.GetAccessControl();

            // Bisogna rimuovere una regola protetta, quindi bisogna anche rimuovere l'ereditarietà, da qui true e false
            security.SetAccessRuleProtection(true, false);

            // Prendo tutte le regole presenti.
            AuthorizationRuleCollection rules = security.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));
            //Ciclo sulle regole e le rimuovo tutte
            foreach (FileSystemAccessRule rule in rules)
            {
                security.RemoveAccessRule(rule);
            }
            
            // security.RemoveAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, AccessControlType.Allow));

            //Inserisco la regola che consente il full control al proprietario
          //  Console.WriteLine(WindowsIdentity.GetCurrent().Name);
            security.AddAccessRule(new FileSystemAccessRule(WindowsIdentity.GetCurrent().Name, FileSystemRights.FullControl, AccessControlType.Allow));
            security.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null)
                , FileSystemRights.ReadAndExecute, AccessControlType.Allow));

            /* security.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.Delete, AccessControlType.Deny));
             security.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.DeleteSubdirectoriesAndFiles, AccessControlType.Allow));
             security.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.CreateDirectories, AccessControlType.Allow));
             security.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.CreateFiles, AccessControlType.Allow));
             security.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ReadAndExecute, AccessControlType.Allow));
             security.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.Modify, AccessControlType.Allow));
             */


            //Applico le regole alla cartella
            Directory.SetAccessControl(_path, security);

            ActionCompletedEvent args = new ActionCompletedEvent
            {
                ToEntry = EntryFactory.CreateEntry(this, "protetta cartella "+_path)
            };
            ToLog?.Invoke(this, args);
        }

        private void ProteggiFile(object o, FileSystemEventArgs param)
        {
            FileSecurity fSecurity = File.GetAccessControl(param.FullPath);
            fSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null),
                FileSystemRights.ReadData, AccessControlType.Allow));
            File.SetAccessControl(param.FullPath, fSecurity);
            ActionCompletedEvent args = new ActionCompletedEvent
            {
                ToEntry = EntryFactory.CreateEntry(this, "protetto file " + param.FullPath)
            };
            ToLog?.Invoke(this, args);
        }
    }
}
