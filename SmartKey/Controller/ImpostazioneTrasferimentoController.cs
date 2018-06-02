using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartKey.ModelGestione;
using SmartKey.ModelLog;

namespace SmartKey.Controller
{
    public class ImpostazioneTrasferimentoController : IGestoreImpostazione
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
                //Creazione del parametro da passare quando scateno l'evento
                ActionCompletedEvent args = new ActionCompletedEvent
                {
                    ToEntry = EntryFactory.GetEntry(this, "aggiunta", impostazione.CartellaSorgente.Path,
                    impostazione.CartellaDestinazione.Path)
                };
                //scateno gli handler registrati all'evento
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
            bool toOut = _impostazioni.Remove(impostazione);
            if (toOut)
            {
                if (ToLog != null)
                {
                    //Creazione dei parametri da passare agli handler dell'evento
                    ActionCompletedEvent args = new ActionCompletedEvent
                    {
                        ToEntry = EntryFactory.GetEntry(this, "rimossa", impostazione.CartellaSorgente.Path,
                    impostazione.CartellaDestinazione.Path)
                    };

                    //Scateno l'evento
                    foreach (EventHandler<ActionCompletedEvent> completed in ToLog.GetInvocationList())
                    {
                        completed(this, args);
                    }
                }
            }
            return toOut;
        }

        void IGestoreImpostazione.SetImpostazioni(IList<ImpostazioneTrasferimento> impostazioni)
        {
            _impostazioni = impostazioni;
        }

    }
}
