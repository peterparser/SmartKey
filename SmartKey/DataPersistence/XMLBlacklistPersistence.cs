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
        public XMLBlacklistPersistence() : base("blacklist.xml") { }
        
        public override object Carica()
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
                    if (node.Attributes.GetNamedItem("proprietario").Value.Equals(Utente.GetNomeUtente())){
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

        public override void Salva(object o, PersistEvent param)
        {
            //TODO bel controllo sul tipo con reflection
            string badUser = (string)param.ToPersist;
            //Questo metodo riceverà un set di stringhe quindi effettuo il cast
            //prima il documento andrà letto
            XmlDocument xdocument = new XmlDocument();
            try
            {
                //Carico il documento xml
                xdocument.Load(Filename);
                //Flusso normale il file esiste
                //Prendo tutti i nodi blacklist
                XmlNodeList blacklists = xdocument.SelectNodes("/blacklists/blacklist");
                /*DA LEGGERE PER CAPIRE IL FLUSSO*/

                //Da inserire cosa fare dipendentemente dall'azione
                //se l'aggiunta va a buon fine aggiungo senza controllare
                //Dato che il set mi ha dato true nel controller
                //Questa voce è univoca

                //Idem per la delete, se lo tolgo e l'operazione ha dato true
                //Cerco la entry e la tolgo a colpo sicuro
                //Per prima cosa trovo la mia blacklist
                foreach (XmlNode blacklist in blacklists)
                {
                    if (blacklist.Attributes.GetNamedItem("proprietario").Value.Equals(Utente.GetNomeUtente()))
                    {
                        //Se l'operazione era di aggiunta appendo l'elemento
                        if (param.Action.Equals("aggiungi"))
                        {
                            var xutente = xdocument.CreateElement("utente");
                            xutente.InnerText = badUser;
                            blacklist.AppendChild(xutente);
                        //Se era rimuovi -> rimuovo like pino la lavatrice
                        }else if(param.Action.Equals("rimuovi"))
                        {
                            foreach(XmlNode user in blacklist.ChildNodes)
                            {
                                if (user.InnerText.Equals(badUser))
                                {
                                    blacklist.RemoveChild(user);
                                }
                            }
                        }
                    }
                }
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true
                };
                //Scrivo il file
                XmlWriter writer = XmlWriter.Create(Filename, settings);
                xdocument.Save(writer);
                //Ricordarsi la close sennò si hanno vari problemi
                writer.Close();
            }
            catch (Exception e)
            {
                //Tutto da fare solamente in caso di add,
                //Dato che il file è vuoto, non esistono regole
                //La remove non avrebbe senso
                xdocument = new XmlDocument();
                //flusso anormale il file non esiste
                //creo il tag blacklists
                XmlElement blacklists = xdocument.CreateElement("blacklists");
                //creo il tag blacklist
                XmlElement blacklist = xdocument.CreateElement("blacklist");
                //metto l'attributo per il proprietario
                blacklist.SetAttribute("proprietario", Utente.GetNomeUtente());
                //Aggiungo l'utente al dom

                var utentexml = xdocument.CreateElement("utente");
                utentexml.InnerText = badUser;
                blacklist.AppendChild(utentexml);

                //Aggangio la blacklist al nostro contenitore blacklists
                blacklists.AppendChild(blacklist);
                //Solfa per creare il documento xml
                XmlDeclaration xmlDeclaration = xdocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = xdocument.DocumentElement;
                xdocument.InsertBefore(xmlDeclaration, root);
                //Aggiungo blacklists al dom
                xdocument.AppendChild(blacklists);
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true
                };
                //Aggiungo il writer
                XmlWriter writer = XmlWriter.Create(Filename, settings);
                XmlSchemaSet schemas = new XmlSchemaSet();
                //Bisogna trovare una LLLLLLOCATION per tutte queste impostazioni
                schemas.Add("", @"C:\Users\massi\Desktop\blacklist.xsd");
                xdocument.Schemas = schemas;
                try
                {
                    //Scrivo il file
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
