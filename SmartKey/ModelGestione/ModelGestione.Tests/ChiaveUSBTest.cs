using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelGestione.ModelGestione.Tests
{
    class ChiaveUSBTest : IDispositivo
    {
        string IDispositivo.NomeDispositivo()
        {
            throw new NotImplementedException();
        }

        string IDispositivo.NomePercorso()
        {
            throw new NotImplementedException();
        }
    }
}
