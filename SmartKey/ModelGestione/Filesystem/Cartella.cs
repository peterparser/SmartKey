using SmartKey.Controller.Controller.Interfaces;
using SmartKey.ModelGestione.Filesystem.Filesystem.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelGestione.Filesystem
{
   public class Cartella : FilesystemElement
    {
        private List<FilesystemElement> _children;

        public Cartella(string path)
        {
            //Bisogna controllare che sia una directory
            
            //Bisogna inserire il build del sottoalbero alla creazione
            if(path != null)
            {
                Path = path;
            }
            else
            {
                throw new PathNotValidException("Path della cartella non valido");
            }
            FileAttributes dirAtt = File.GetAttributes(Path);
            if (dirAtt.HasFlag(FileAttributes.Directory))
            {
                _children = new List<FilesystemElement>();
                //Popolamento del sottoalbero
                //Enumero il contenuto della cartella, se è un file aggiungo filewrapper
                //Se è una cartella aggiungo una directory
                var filesystemEntry = Directory.EnumerateFileSystemEntries(path);
                foreach (string currentEntry in filesystemEntry)
                {
                    FileAttributes attr = File.GetAttributes(currentEntry);
                    if (attr.HasFlag(FileAttributes.Directory))
                    {
                        AddChild(new Cartella(currentEntry));
                    }
                    else
                    { 
                        AddChild(new FileWrapper(currentEntry));
                    }
                }
            }
            else
            {
                throw new PathNotValidException("Il path passato non è una cartella");
            }
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

        //Metodo per vedere i figli
        public List<FilesystemElement> Children
        {
            get
            {
                return _children;
            }
        }

        public override void Accept(IGestoreSincronizzazione visitor)
        {
            visitor.Visit(this);
        }
    }
}
