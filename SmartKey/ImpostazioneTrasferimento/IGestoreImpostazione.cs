using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartKey.Controller.Controller.Interfaces;

namespace SmartKey.ImpostazioneTrasferimento
{
    public interface IGestoreImpostazione : IPersistActions
    {
      
        void SetImpostazioni(ISet<ImpostazioneTrasferimento> impostazioni);
        ISet<ImpostazioneTrasferimento> ElencoImpostazioni();
        bool AddImpostazione(ImpostazioneTrasferimento impostazione);
        bool RemoveImpostazione(ImpostazioneTrasferimento impostazione);
    }
}
