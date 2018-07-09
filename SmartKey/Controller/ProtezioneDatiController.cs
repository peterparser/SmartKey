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

        public void ProteggiCartella(string path)
        {
            if (!Directory.Exists(path))
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
                // security.RemoveAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, AccessControlType.Allow));

                //Inserisco la regola che consente il full control al proprietario
                Console.WriteLine(WindowsIdentity.GetCurrent().Name);
                security.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.Delete, AccessControlType.Deny));
                security.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.DeleteSubdirectoriesAndFiles, AccessControlType.Allow));
                security.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.CreateDirectories, AccessControlType.Allow));
                security.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.CreateFiles, AccessControlType.Allow));
                security.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ReadAndExecute, AccessControlType.Allow));
                security.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.Modify, AccessControlType.Allow));



                //Applico le regole alla cartella
                Directory.SetAccessControl(path, security);

                ActionCompletedEvent args = new ActionCompletedEvent
                {
                    ToEntry = EntryFactory.CreateEntry(this, "protetta cartella "+path)
                };
                ToLog?.Invoke(this, args);

            }
        }
    }
}
