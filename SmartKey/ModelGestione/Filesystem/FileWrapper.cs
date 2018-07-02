using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartKey.Controller.Controller.Interfaces;

namespace SmartKey.ModelGestione.Filesystem
{
    public class FileWrapper : FilesystemElement 
    {
        public FileWrapper(string path)
        {
            Path = path;
        }
        public override void Accept(IGestoreSincronizzazione visitor)
        {
            visitor.Visit(this);
        }
    }
}
