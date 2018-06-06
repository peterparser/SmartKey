using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using SmartKey.ModelGestione;

namespace SmartKey.DataPersistence
{
    public class XMLBlacklistPersistence : XMLDataPersistence
    {
        public XMLBlacklistPersistence(string filename) : base(filename) { }
        
        public override object Carica(Utente utente)
        {
            XmlDocument xdocument = new XmlDocument();
            try
            {
                //carico il documento
                xdocument.Load(Filename);
                //prendo tutti i nodi con il tag blacklist
                XmlNodeList nodelist = xdocument.SelectNodes("/blacklists/blacklist");
                //Preparo il contenitore
                ISet<string> blacklist = new HashSet<string>();
                //Itero su quegli elementi
                foreach (XmlNode node in nodelist)
                {
                    //Se quell'elemento blacklist ha "me" come proprietario allora è la mia blacklist
                    if (node.Attributes.GetNamedItem("proprietario").Value.Equals(utente.NomeHost)){
                        //Itero sui figli di quel nodo per prendere tutti gli utenti nella mia blacklist
                        foreach(XmlNode utenti in node.ChildNodes)
                        {
                            blacklist.Add(utenti.InnerText);
                        }
                    }
                }
                return blacklist;
            }
            catch
            {
                throw new PersistenceException("File per il caricamento non trovato");
            }
        }

        public override void Salva(object o)
        {
            ISet<string> set = (ISet<String>)o;
            //Questo metodo riceverà un set di stringhe quindi effettuo il cast
            //prima il documento andrà letto
            XmlDocument xdocument = new XmlDocument();
            try
            {
                //Carico il documento xml
                xdocument.Load(Filename);
                //Prendo tutti i nodi blacklist
                XmlNodeList blacklists = xdocument.SelectNodes("/blacklists/blacklist");
                //Itero sui nodi
                foreach(XmlNode blacklist in blacklists)
                {
                    //Cerco la blacklist che mi appartiene
                    if(blacklist.Attributes.GetNamedItem("proprietario").Value
                        .Equals(Utente.GetUtente().NomeHost))
                    {
                        //Rimuovo tutti gli utenti dalla blacklist
                        blacklist.RemoveAll();
                        ((XmlElement)blacklist).SetAttribute("proprietario", Utente.GetUtente().NomeHost);
                        
                        //Reinserisco tutti per evitare duplicati
                        foreach (string utente in set)
                        {
                            var utentexml = xdocument.CreateElement("utente");
                            utentexml.InnerText = utente;
                            blacklist.AppendChild(utentexml);
                        }

                    }
                }
                //Flusso normale il file esiste
                //TODO MODIFICA FILE XML
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true
                };
                XmlWriter writer = XmlWriter.Create(Filename, settings);
                xdocument.Save(writer);
                writer.Close();
            }
            catch (Exception e)
            {
                xdocument = new XmlDocument();
                //flusso anormale il file non esiste
                //creo il tag blacklists
                XmlElement blacklists = xdocument.CreateElement("blacklists");
                //creo il tag blacklist
                XmlElement blacklist = xdocument.CreateElement("blacklist");
                //metto l'attributo per il proprietario
                blacklist.SetAttribute("proprietario", Utente.GetUtente().NomeHost);
                foreach (string utente in set)
                {
                    var utentexml = xdocument.CreateElement("utente");
                    utentexml.InnerText = utente;
                    blacklist.AppendChild(utentexml);
                }
                blacklists.AppendChild(blacklist);
                XmlDeclaration xmlDeclaration = xdocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = xdocument.DocumentElement;
                xdocument.InsertBefore(xmlDeclaration, root);
                xdocument.AppendChild(blacklists);
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true
                };
                XmlWriter writer = XmlWriter.Create(Filename, settings);
                XmlSchemaSet schemas = new XmlSchemaSet();
                //Bisogna trovare una LLLLLLOCATION per tutte queste impostazioni
                schemas.Add("", @"C:\Users\massi\Desktop\blacklist.xsd");
                xdocument.Schemas = schemas;
                try
                {
                    xdocument.Validate((oggetto, handler) => { });
                    xdocument.Save(writer);
                    writer.Close();
                }catch(Exception ex)
                {
                    throw new PersistenceException("Non è stato possibile scrivere il file .xml");
                }
            }
        }
    }
}
