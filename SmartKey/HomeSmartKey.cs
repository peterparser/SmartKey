using SmartKey.ModelGestione;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartKey
{
    public partial class HomeSmartKey : SmartKey.BaseForm
    {
        public HomeSmartKey()
        {
            InitializeComponent();

            textBoxUtente.Text = Utente.GetNomeUtente();

            if (Utente.Dispositivo.Count < 1)
            {
                this.textBoxDispositivo.Text = "Nessun Dispositivo Collegato";
            }
            else
            {
                this.textBoxDispositivo.Text = Utente.Dispositivo[0].OttieniNomeDispositivo();
            }

            if (Utente.Dispositivo.Count < 1)
            {
                this.textBoxCartellaPrivata.Text = "No USB no party...";
            }
            else
            {
                // qui invoco entrambi i metodi per la creazione dello spazio
                this.textBoxCartellaPrivata.Text = Utente.Dispositivo[0].OttieniCartellaPrivata();
                Utente.Dispositivo[0].OttieniCartellaPubblica();
            }
        }

        public void StatusAndHide()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    statusLabel.Text = "Sto sincronizzando...";
                    ButtonSincronizza.Hide();
                }));
            }
            else
            {
                statusLabel.Text = "Sto sincronizzando...";
                ButtonSincronizza.Hide();
            }
        }

        public bool ChiediScelta(string badUser)
        {
            var confirmResult = MessageBox.Show("Vuoi sincronizzare i file prodotti da " +badUser+" ?",
                                     "Attenzione Sincronizzazione",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Button ButtonLogSincro
        {
            get
            {
                return buttonLogSincro;
            }
        }
        public Button ButtonSincronizza
        {
            get
            {
                return buttonSincronizza;
            }
        }
        public void AvvisaFineSync()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    MessageBox.Show("Sincronizzazione terminata", "Sincronizzazione",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    statusLabel.Text = "Pronto!";
                    ButtonSincronizza.Show();
                }));
            }
        }

        private void textBoxUtente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
