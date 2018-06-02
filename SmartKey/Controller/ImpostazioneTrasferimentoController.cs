using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartKey.ModelGestione;
using SmartKey.ModelLog;

namespace SmartKey.Controller
{
    class ImpostazioneTrasferimentoController : IGestoreImpostazione
    {
        IList<ImpostazioneTrasferimento> _impostazioni;
        public event EventHandler<ActionCompletedEvent> ToLog;

        public ImpostazioneTrasferimentoController()
        {
            _impostazioni = new List<ImpostazioneTrasferimento>();
        }

        

        void IGestoreImpostazione.AddImpostazione(ImpostazioneTrasferimento impostazione)
        {
            _impostazioni.Add(impostazione);
           if(ToLog != null)
            {
                ActionCompletedEvent args = new ActionCompletedEvent
                {
                    Action = "Aggiunta Impostazione"
                };
                foreach (EventHandler<ActionCompletedEvent> completed in ToLog.GetInvocationList())
                {
                    completed(this, args);
                }
            }
        }

        IList<ImpostazioneTrasferimento> IGestoreImpostazione.ElencoImpostazioni()
        {
            return _impostazioni;
        }

        bool IGestoreImpostazione.RemoveImpostazione(ImpostazioneTrasferimento impostazione)
        {
            return _impostazioni.Remove(impostazione);
        }

        void IGestoreImpostazione.SetImpostazioni(IList<ImpostazioneTrasferimento> impostazioni)
        {
            _impostazioni = impostazioni;
        }

    }
}
