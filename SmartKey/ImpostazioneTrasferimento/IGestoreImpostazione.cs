using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartKey.Controller.Controller.Interfaces;

namespace SmartKey.ImpostazioneTrasferimento
{
    interface IGestoreImpostazione : IPersistActions
    {
      
        void SetImpostazioni(ISet<ImpostazioneTrasferimento> impostazioni);
        ISet<ImpostazioneTrasferimento> ElencoImpostazioni();
        void AddImpostazione(ImpostazioneTrasferimento impostazione);
        bool RemoveImpostazione(ImpostazioneTrasferimento impostazione);
    }
}
