using NUnit.Framework;
using SmartKey.Controller;
using SmartKey.Controller.Controller.Interfaces;
using SmartKey.ModelGestione;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.DataPersistence.Tests
{
    [TestFixture]
    class ImpostazioniTrasfermientoPersistenceXMLTest
    {
        private const string PATH = @"C:\Users\massi\Desktop\impostazioni.xml";


        [TestCase(Category ="ImpostazioneTrasferimentoPersistence")]
        public void TestReadWriteImpostazioni()
        {
            XMLDataPersistence impPers = new XMLImpostazioniPersistence(PATH);
            IGestoreImpostazione impCon = new ImpostazioneTrasferimentoController();
            ((IPersistActions)impCon).Persist += impPers.Salva;
            try
            {
                //Carico il file
                ISet<ImpostazioneTrasferimento> imps = (ISet<ImpostazioneTrasferimento>)impPers.Carica();
                impCon.SetImpostazioni(imps);
            }
            catch(PersistenceException e) { }
            finally
            {
                //Inserisco le impostazioni
                ImpostazioneTrasferimento toBeRemoved = new ImpostazioneTrasferimento("toRemoveSrc", "toRemoveDst");
                impCon.AddImpostazione(new ImpostazioneTrasferimento("myPathSrc", "myPathDst"));
                impCon.AddImpostazione(new ImpostazioneTrasferimento("myPath1Src", "myPath1Dst"));
                impCon.AddImpostazione(toBeRemoved);
                ISet<ImpostazioneTrasferimento> imps = (ISet<ImpostazioneTrasferimento>)impPers.Carica();
                impCon.SetImpostazioni(imps);
                //Testo un po lascamente la lettura da file
                Assert.IsTrue(impCon.RemoveImpostazione(toBeRemoved));
                imps = (ISet<ImpostazioneTrasferimento>)impPers.Carica();
                //Testo la rimozione
                impCon.SetImpostazioni(imps);
                Assert.IsFalse(impCon.RemoveImpostazione(toBeRemoved));
                Assert.IsTrue(impCon.RemoveImpostazione(new ImpostazioneTrasferimento("myPathSrc", "myPathDst")));

            }
        }
    }
}
