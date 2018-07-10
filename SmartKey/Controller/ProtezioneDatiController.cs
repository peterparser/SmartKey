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

        private string _path;
        public ProtezioneDatiController(string path)
        {
            _path = path;
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

        public static void ProteggiDir(string path)
        {
            DirectoryInfo dInfo = new DirectoryInfo(path);
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
            security.AddAccessRule(new FileSystemAccessRule(WindowsIdentity.GetCurrent().Name, FileSystemRights.FullControl, AccessControlType.Allow));
            security.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null)
                , FileSystemRights.ReadAndExecute, AccessControlType.Allow));

            Directory.SetAccessControl(path, security);
        }

        public static void ProteggiFile(string path)
        {
            FileSecurity fSecurity = File.GetAccessControl(path);
            fSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null),
                FileSystemRights.Read, AccessControlType.Allow));
            File.SetAccessControl(path, fSecurity);
        }
    }
}
