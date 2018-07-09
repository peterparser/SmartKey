using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Log.ModelLog
{
    public class EntrySistema : Entry
    {
        public EntrySistema(string operazione) : base(operazione)
        {
        }

        public EntrySistema(string operazione, DateTime date) : base(operazione, date)
        {
        }

        public override string ToString()
        {
            return "" + base.DataOra + "\tSistema\t" + base.Operazione;
        }
    }
}
