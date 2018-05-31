using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelGestione.Filesystem
{
    class FileWrapper : FilesystemElement 
    {
        public FileWrapper(string path)
        {
            Path = path;
        }
    }
}
