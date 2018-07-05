using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartKey.Utility
{
    public class NavigationHelper
    {
        private Dictionary<String, BaseForm> _forms;
        private BaseForm _currentForm;
        
        public NavigationHelper()
        {
            _forms = new Dictionary<string, BaseForm>();
            _forms.Add("HomeSmartKey", new HomeSmartKey());
            _forms.Add("HomeBlacklist", new HomeBlacklist());
            _forms.Add("HomeImpostazioni", new HomeImpostazioni());
            _forms.Add("HomeLog", new HomeLog());
            _forms.Add("HomeAnalisiOttimizzazione", new HomeAnalisiOttimizzazione());
            _currentForm = GetForm("HomeSmartKey");
        }

        public void AgganciaHandlers()
        {
            foreach(BaseForm form in _forms.Values)
            {
                form.ButtonHomeSmartKey.Click += HandlerNavigation;
                form.ButtonBlacklist.Click += HandlerNavigation;
                form.ButtonImpostazioneTrasferimento.Click += HandlerNavigation;
                form.ButtonAnalisi.Click += HandlerNavigation;
                form.ButtonLog.Click += HandlerNavigation;
                form.FormClosed += HandlderClosure;
            }

            //Parte per l'aggancio della navigazione a log
            ((HomeSmartKey)GetForm("HomeSmartKey")).ButtonLogSincro.Click += HandlerToLogSincro;
            ((HomeImpostazioni)GetForm("HomeImpostazioni")).ToLogImpostazioni.Click += HandlerToLogImpostazioni;
            ((HomeBlacklist)GetForm("HomeBlacklist")).ButtonToLogBlacklist.Click += HandlerToLogBlacklist;
            ((HomeAnalisiOttimizzazione)GetForm("HomeAnalisiOttimizzazione")).ButtonToLogAnalisi.Click += HandlerToLogAnalisi;
        }

        public BaseForm GetForm(string key)
        {
            _forms.TryGetValue(key, out BaseForm toOut);
            return toOut;
        }

        private void HandlerToLogSincro(object sender, EventArgs args)
        {
            HomeLog logForm =(HomeLog) GetForm("HomeLog");
            logForm.Show();
            _currentForm.Hide();
            _currentForm = logForm;
            logForm.RadioButtonSincronizzazione.Select();
        }

        private void HandlerToLogImpostazioni(object sender, EventArgs args)
        {
            HomeLog logForm = (HomeLog)GetForm("HomeLog");
            logForm.Show();
            _currentForm.Hide();
            _currentForm = logForm;
            logForm.RadioButtonImpostazioni.Select();
        }

        private void HandlerToLogBlacklist(object sender, EventArgs args)
        {
            HomeLog logForm = (HomeLog)GetForm("HomeLog");
            logForm.Show();
            _currentForm.Hide();
            _currentForm = logForm;
            logForm.RadioButtonBlacklist.Select();
        }

        private void HandlerToLogAnalisi(object sender, EventArgs args)
        {
            HomeLog logForm = (HomeLog)GetForm("HomeLog");
            logForm.Show();
            _currentForm.Hide();
            _currentForm = logForm;
            logForm.RadioButtonCompressione.Select();
        }

        public void HandlderClosure(object sender, EventArgs param)
        {
            foreach(BaseForm form in _forms.Values)
            {
                form.FormClosed -= HandlderClosure;
                form.Close();
                
            }
        }

        public void HandlerNavigation(object sender, EventArgs param)
        {
            Button button = (Button)sender;
            
            switch (button.Text)
            {
                case ("Home Smartkey"):
                    BaseForm homeForm = GetForm("HomeSmartKey");
                    //Se il form corrente non è quello
                    if (!_currentForm.Equals(homeForm))
                    { 
                        homeForm.Show();
                        _currentForm.Hide();
                        _currentForm = homeForm;
                    }
                    break;
                case ("Impostazione Trasferimento"):
                    BaseForm impostazioniForm = GetForm("HomeImpostazioni");
                    if (!_currentForm.Equals(impostazioniForm))
                    {
                        impostazioniForm.Show();
                        _currentForm.Hide();
                        _currentForm = impostazioniForm;
                    }
                    break;
                case ("Blacklist"):
                    BaseForm blackListForm = GetForm("HomeBlacklist");
                    if (!_currentForm.Equals(blackListForm))
                    {
                        blackListForm.Show();
                        _currentForm.Hide();
                        _currentForm = blackListForm;
                    }
                    break;
                case ("Analisi e Ottimizzazione"):
                    BaseForm analisiForm = GetForm("HomeAnalisiOttimizzazione");
                    if (!_currentForm.Equals(analisiForm))
                    {
                        analisiForm.Show();
                        _currentForm.Hide();
                        _currentForm = analisiForm;
                    }
                    break;

                case ("Log"):
                    BaseForm logForm = GetForm("HomeLog");
                    if (!_currentForm.Equals(logForm))
                    {
                        logForm.Show();
                        _currentForm.Hide();
                        _currentForm = logForm;
                    }
                    break;
            }
        }

    }
}
