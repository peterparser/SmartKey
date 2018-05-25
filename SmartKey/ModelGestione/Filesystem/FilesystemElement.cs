using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelGestione.Filesystem
{
    abstract class FilesystemElement
    {
        private string _path;

        //TODO
        //Bisogna aggiungere il metodo per il visitor

        public string Path
        {
            get { return _path; }
            set { _path = value}
        }
    }
}
