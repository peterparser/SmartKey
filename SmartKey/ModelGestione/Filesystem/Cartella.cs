using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelGestione.Filesystem
{
    class Cartella : FilesystemElement
    {
        private List<FilesystemElement> _children;

        public Cartella(string path)
        {
            Path = path;
            _children = new List<FilesystemElement>();
        }
        
        public String NomeCartella()
        {
            return base.Path.Split('\\').Last();
        }

        public void AddChild(FilesystemElement e)
        {
            //Se directory si aggiugne una cartella
            //Se file si aggiunge un file
        }
        
        public void RemoveChild(FilesystemElement e)
        {
            //Optional
        }

        public FilesystemElement GetChild(string path)
        {
            return _children.Find(x => x.Path.Equals(path));
        }


    }
}
