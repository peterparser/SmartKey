using SmartKey.ModelGestione;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller.Controller.Interfaces
{
    interface IGestoreImpostazione : IController
    {
      
        void SetImpostazioni(ISet<ImpostazioneTrasferimento> impostazioni);
        ISet<ImpostazioneTrasferimento> ElencoImpostazioni();
        void AddImpostazione(ImpostazioneTrasferimento impostazione);
        bool RemoveImpostazione(ImpostazioneTrasferimento impostazione);
    }
}
