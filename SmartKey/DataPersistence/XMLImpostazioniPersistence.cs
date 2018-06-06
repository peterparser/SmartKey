using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using SmartKey.ModelGestione;

namespace SmartKey.DataPersistence
{
    public class XMLImpostazioniPersistence : XMLDataPersistence
    {
        public XMLImpostazioniPersistence(string filename) : base(filename)
        {
        }

        public override object Carica()
        {
            XmlDocument xdocument = new XmlDocument();
            try
            {
                xdocument.Load(Filename);
                XmlNodeList nodelist = xdocument.SelectNodes("/impostazioni/impostazione");
                IList<ImpostazioneTrasferimento> settings = new List<ImpostazioneTrasferimento>();
                foreach(XmlNode node in nodelist)
                {
                    if (node.Attributes.GetNamedItem("utente").Value.Equals(Utente.GetUtente().NomeHost))
                    {
                        string cartellaSorgente, cartellaDestinazione;
                        cartellaSorgente = null;
                        cartellaDestinazione = null;
                        foreach(XmlNode settingNode in node.ChildNodes)
                        {
                            if (settingNode.Name.Equals("cartella-sorgente")) cartellaSorgente = settingNode.InnerText;
                            if (settingNode.Name.Equals("cartella-destinazione")) cartellaDestinazione = settingNode.InnerText;
                            settings.Add(new ImpostazioneTrasferimento(cartellaSorgente, cartellaDestinazione));
                        }
                    }
                }
                return settings;
            }
            catch
            {
                //Andrà gestita a livello piu alto, semplicemente non facendo nullla.
                throw new PersistenceException("File per le impostazioni non trovato");
            }
        }

        //Si suppone che object o sia una impostazione trasferimento

        public override void Salva(object o, PersistEvent param)
        {
            //
        }
    }
}
