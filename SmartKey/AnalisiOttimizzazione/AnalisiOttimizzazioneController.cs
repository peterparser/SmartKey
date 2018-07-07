using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartKey.Controller;
using SmartKey.ModelGestione.Filesystem;

namespace SmartKey.AnalisiOttimizzazione
{
    class AnalisiOttimizzazioneController : IGestoreAnalisiOttimizzazione
    {

        public event EventHandler<ActionCompletedEvent> ToLog;
        private int _sogliaMemoria;
        private CompressionLevel _qualita;
        private HomeAnalisiOttimizzazione _viewAnalisi;

        public AnalisiOttimizzazioneController(HomeAnalisiOttimizzazione _view)
        {
           
            _viewAnalisi = _view;
            _viewAnalisi.ButtonComprimi.Click += ComprimiHandler();
        }

        private EventHandler ComprimiHandler()
        {
            throw new NotImplementedException();
        }

        public List<Cartella> Analizza(Cartella cartella)
        {
            throw new NotImplementedException();
        }

        public List<string> MostraConsigli()
        {
            throw new NotImplementedException();
        }

        public void Ottimizza(List<Cartella> cartelle)
        {
            throw new NotImplementedException();
        }
    }
}
