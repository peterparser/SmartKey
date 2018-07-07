using SmartKey.ModelGestione.Filesystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelGestione
{
    public interface IDispositivo
    {
        string OttieniNomeDispositivo();
        string OttieniCartellaPrivata();
        string OttieniCartellaPubblica();
    }
}
