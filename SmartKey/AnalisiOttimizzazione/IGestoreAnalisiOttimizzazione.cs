using SmartKey.Controller.Controller.Interfaces;
using SmartKey.ModelGestione.Filesystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.AnalisiOttimizzazione
{
    public interface IGestoreAnalisiOttimizzazione : IController
    {
        List<Cartella> Analizza(Cartella cartella);
        List<String> MostraConsigli();
        void Ottimizza(List<Cartella> cartelle);
    }
}
