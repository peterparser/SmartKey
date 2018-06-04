using SmartKey.ModelGestione;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.DataPersistence
{
    interface IDataPersistence
    {
       object Carica(Utente utente);
        void Salva(Object o);
    }
}
