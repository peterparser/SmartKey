using SmartKey.ModelGestione.Filesystem.Filesystem.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelGestione.Filesystem
{
   public class Cartella : FilesystemElement
    {
        private List<FilesystemElement> _children;
        private Cartella _parent;
        public Cartella(string path)
        {

            if(path != null)
            {
                Path = path;
            }
            else
            {
                throw new PathNotValidException("Path della cartella non valido");
            }
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
            _children.Add(e);
        }
        
        public void RemoveChild(FilesystemElement e)
        {
            _children.Remove(e);
        }

        public FilesystemElement GetChild(string path)
        {
            return _children.Find(x => x.Path.Equals(path));
        }

    }
}
