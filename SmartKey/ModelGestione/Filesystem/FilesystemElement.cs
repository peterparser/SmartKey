using SmartKey.ModelGestione.Filesystem.Filesystem.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelGestione.Filesystem
{
    public abstract class FilesystemElement
    {
        private string _path;

        //TODO
        //Bisogna aggiungere il metodo per il visitor

        public string Path
        {
            get { return _path; }
            set
            {
                if(value.Length > 260)
                {
                    throw new PathNotValidException("Path inserito troppo lungo");
                }
                else
                {
                    _path = value;
                }
            }
        }

        public override bool Equals(object obj)
        {
            var element = obj as FilesystemElement;
            return element != null &&
                   _path == element._path;
        }

        public override int GetHashCode()
        {
            return 2090457805 + EqualityComparer<string>.Default.GetHashCode(_path);
        }
    }
}
