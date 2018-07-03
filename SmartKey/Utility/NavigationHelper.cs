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
        }

        public BaseForm GetForm(string key)
        {
            _forms.TryGetValue(key, out BaseForm toOut);
            return toOut;
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
                        _currentForm.Hide();
                        homeForm.Show();
                        _currentForm = homeForm;
                    }
                    break;
                case ("Impostazione Trasferimento"):
                    BaseForm impostazioniForm = GetForm("HomeImpostazioni");
                    if (!_currentForm.Equals(impostazioniForm))
                    {
                        _currentForm.Hide();
                        impostazioniForm.Show();
                        _currentForm = impostazioniForm;
                    }
                    break;
                case ("Blacklist"):
                    BaseForm blackListForm = GetForm("HomeBlacklist");
                    if (!_currentForm.Equals(blackListForm))
                    {
                        _currentForm.Hide();
                        blackListForm.Show();
                        _currentForm = blackListForm;
                    }
                    break;
                case ("Analisi e Ottimizzazione"):
                    BaseForm analisiForm = GetForm("HomeAnalisiOttimizzazione");
                    if (!_currentForm.Equals(analisiForm))
                    {
                        _currentForm.Hide();
                        analisiForm.Show();
                        _currentForm = analisiForm;

                       
                    }
                    break;

                case ("Log"):
                    BaseForm logForm = GetForm("HomeLog");
                    if (!_currentForm.Equals(logForm))
                    {
                        _currentForm.Hide();
                        logForm.Show();
                        _currentForm = logForm;
                    }
                    break;
            }
        }

    }
}
