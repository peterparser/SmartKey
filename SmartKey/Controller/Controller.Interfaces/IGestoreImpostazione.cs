using SmartKey.ModelGestione;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartKey.ImpostazioneTrasferimento;

namespace SmartKey.Controller.Controller.Interfaces
{
    interface IGestoreImpostazione : IPersistActions
    {
      
        void SetImpostazioni(ISet<ImpostazioneTrasferimento.ImpostazioneTrasferimento> impostazioni);
        ISet<ImpostazioneTrasferimento.ImpostazioneTrasferimento> ElencoImpostazioni();
        void AddImpostazione(ImpostazioneTrasferimento.ImpostazioneTrasferimento impostazione);
        bool RemoveImpostazione(ImpostazioneTrasferimento.ImpostazioneTrasferimento impostazione);
    }
}
