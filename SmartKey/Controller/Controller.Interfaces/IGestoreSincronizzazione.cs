using SmartKey.ModelGestione.Filesystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller.Controller.Interfaces
{
    public interface IGestoreSincronizzazione :IController
    {
        void Sincronizza(List<ImpostazioneTrasferimento.ImpostazioneTrasferimento> impostazioni);
        void Visit(Cartella cartella);
        void Visit(FileWrapper file);

    }
}
