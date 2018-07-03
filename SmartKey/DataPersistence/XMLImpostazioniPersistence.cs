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
                ISet<ImpostazioneTrasferimento.ImpostazioneTrasferimento> settings = new HashSet<ImpostazioneTrasferimento.ImpostazioneTrasferimento>();
                foreach(XmlNode node in nodelist)
                {
                    if (node.Attributes.GetNamedItem("utente").Value.Equals(Utente.GetNomeUtente()))
                    {
                        string cartellaSorgente, cartellaDestinazione;
                        cartellaSorgente = null;
                        cartellaDestinazione = null;
                        foreach(XmlNode settingNode in node.ChildNodes)
                        {
                            if (settingNode.Name.Equals("cartella-sorgente")) cartellaSorgente = settingNode.InnerText;
                            if (settingNode.Name.Equals("cartella-destinazione")) cartellaDestinazione = settingNode.InnerText;
                        }
                        settings.Add(new ImpostazioneTrasferimento.ImpostazioneTrasferimento(cartellaSorgente, cartellaDestinazione));
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
            ImpostazioneTrasferimento.ImpostazioneTrasferimento toPut = (ImpostazioneTrasferimento.ImpostazioneTrasferimento)param.ToPersist;
            XmlDocument xdocument = new XmlDocument();
            try
            {
                xdocument.Load(Filename);
                //Dato che sono stato chiamato e il file esiste, si suppone che ci sia da fare un inserimento consono
                //Mi ri-permetto di andare liscio (a spade)
                XmlNode impostazioniMainNode = xdocument.DocumentElement;
                if (param.Action.Equals("aggiungi"))
                {
                    //Caso di aggiunta si veda sotto nel catch per commenti dettagliati
                    XmlElement xImpostazione = xdocument.CreateElement("impostazione");
                    xImpostazione.SetAttribute("utente", Utente.GetNomeUtente());
                    XmlElement cartellaSorgente = xdocument.CreateElement("cartella-sorgente");
                    cartellaSorgente.InnerText = toPut.CartellaSorgente.Path;
                    XmlElement cartellaDestinazione = xdocument.CreateElement("cartella-destinazione");
                    cartellaDestinazione.InnerText = toPut.CartellaDestinazione;
                    XmlElement verso = xdocument.CreateElement("verso");
                    verso.InnerText = toPut.Verso;
                    xImpostazione.AppendChild(cartellaSorgente);
                    xImpostazione.AppendChild(cartellaDestinazione);
                    xImpostazione.AppendChild(verso);
                    impostazioniMainNode.AppendChild(xImpostazione);
                }
                else if (param.Action.Equals("rimuovi"))
                {
                    //Caso di rimozione
                    //Itero, trovo l'impostazione che fa al caso mio e la rimuovo da impostazioni main node
                    //E tutti amici come prima
                    foreach(XmlNode impostazioneNode in impostazioniMainNode.ChildNodes)
                    {
                        if (impostazioneNode.Attributes.GetNamedItem("utente").Value.Equals(Utente.GetNomeUtente()))
                        {
                            //Controllo il contenuto
                            bool found = true;
                            foreach(XmlNode valueImpostazione in impostazioneNode.ChildNodes)
                            {
                                if(!valueImpostazione.Name.Equals("verso"))
                                found = found && (
                                    ((valueImpostazione.Name.Equals("cartella-sorgente") &&
                                    valueImpostazione.InnerText.Equals(toPut.CartellaSorgente.Path)) )||
                                    (valueImpostazione.Name.Equals("cartella-destinazione") && 
                                    valueImpostazione.InnerText.Equals(toPut.CartellaDestinazione)));
                            }
                            if (found) impostazioniMainNode.RemoveChild(impostazioneNode);
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
            catch
            {
                //Il documento esiste, aggiungo andando liscio(a spade)
                xdocument = new XmlDocument();
                //Creo il tag contenitore
                XmlElement impostazioni = xdocument.CreateElement("impostazioni");
                //Creo il tag per la mia impostazione
                XmlElement impostazione = xdocument.CreateElement("impostazione");
                //Imposto l'attributo utente in modo consono
                impostazione.SetAttribute("utente", Utente.GetNomeUtente());
                
                //Creo gli i figli che compongono il tag impostazione e gli do il valore che devo inserire
                XmlElement cartellaSorgente = xdocument.CreateElement("cartella-sorgente");
                cartellaSorgente.InnerText = toPut.CartellaSorgente.Path;
                XmlElement cartellaDestinazione = xdocument.CreateElement("cartella-destinazione");
                cartellaDestinazione.InnerText = toPut.CartellaDestinazione;
                XmlElement verso = xdocument.CreateElement("verso");
                verso.InnerText = toPut.Verso;
                
                //Creo l'albero XML da aggiungere al DOM appena verra creato
                impostazione.AppendChild(cartellaSorgente);
                impostazione.AppendChild(cartellaDestinazione);
                impostazione.AppendChild(verso);
                impostazioni.AppendChild(impostazione);
                XmlDeclaration xmlDeclaration = xdocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                //Creo la document root
                XmlElement root = xdocument.DocumentElement;
                xdocument.InsertBefore(xmlDeclaration, root);
                //Aggiungo impostazioni al dom
                xdocument.AppendChild(impostazioni);
                
                //Scrivo il file
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true
                };
                //Aggiungo il writer
                XmlWriter writer = XmlWriter.Create(Filename, settings);
                //TODO Aggiungere lo schema
                xdocument.Save(writer);
                writer.Close();
            }
        }
    }
}
