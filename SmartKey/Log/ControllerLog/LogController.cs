using SmartKey.Controller;
using SmartKey.Log.LogPersistence;
using SmartKey.Log.ModelLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Log.ControllerLog
{
    public class LogController : IObserver
    {
        private ILogPersistence _logPersistence;
        private ModelLog.Log _log;
        private HomeLog _logView;

        public LogController(HomeLog _view)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            _logPersistence = new ConcreteLogPersistence(string.Join("\\",path,"log.txt"));
            _log = _logPersistence.LeggiLog();
            _logView = _view;
            _logView.RadioButtonData.CheckedChanged += ShowLogData;
            _logView.RadioButtonImpostazioni.CheckedChanged += ShowLogImpostazioni;
            _logView.ButtonReset.Click += ResetButtonHandler;
            _logView.RadioButtonBlacklist.CheckedChanged += ShowLogBlacklist;
            _logView.RadioButtonCompressione.CheckedChanged += ShowLogCompressione;
            _logView.RadioButtonSincronizzazione.CheckedChanged += ShowLogSincro;
            _logView.RadioButtonSistema.CheckedChanged += ShowLogSistema;
            

            //Popolo la grid con i dati dei log
            foreach(Entry entry in _log.Entries)
            {
                _logView.DataGridOutputLog.Rows.Add(entry.ToString().Replace('\t',' '));
            }

        }
        private void ResetButtonHandler(object sender, EventArgs args)
        {
            //Controllo che non siano gia tutte stampate
            //Se sono lo stesso numero che abbiamo in Entries vuol dire che le abbiamo stampate tutte
            if (_logView.DataGridOutputLog.Rows.Count != _log.Entries.Count)
            {
                //Cancello tutto dalla view e ripopolo
                _logView.DataGridOutputLog.Rows.Clear();
                foreach (Entry entry in _log.Entries)
                { 
                    _logView.DataGridOutputLog.Rows.Add(entry.ToString().Replace('\t', ' '));
                }
            }
        }
        private void ShowLogData(object sender, EventArgs args)
        {
            if (_logView.RadioButtonData.Checked)
            {
                _logView.LabelDataStart.Visible = true;
                _logView.DateTimePickerStart.Visible = true;
                _logView.LabelDataStart.Visible = true;
                _logView.DateTimePickerEnd.Visible = true;
            }
            else
            {
                _logView.LabelDataStart.Visible = false;
                _logView.DateTimePickerStart.Visible = false;
                _logView.LabelDataStart.Visible = false;
                _logView.DateTimePickerEnd.Visible = false;
            }
        }

        public void Update(object sender, EventArgs e)
        {

            ActionCompletedEvent param = (ActionCompletedEvent)e;
            ScriviEntry(param.ToEntry);
            _logPersistence.ScriviLog(_log);
        }
        private void ScriviEntry(Entry e)
        {
            _log.AddEntry(e);
            _logView.DataGridOutputLog.Rows.Add(e.ToString().Replace('\t',' '));
        }
        public IList<Entry> Entries
        {
            get
            {
                return _log.Entries;
            }
        }
        //TODO GENTRIESINTIME
        private void ShowLogImpostazioni(object sender, EventArgs args)
        {
            _logView.DataGridOutputLog.Rows.Clear();
            foreach(Entry entry in GetEntriesType("EntryImpostazione"))
            {
                _logView.DataGridOutputLog.Rows.Add(entry.ToString().Replace('\t', ' '));
            }
        }
        private void ShowLogBlacklist(object sender, EventArgs args)
        {
            _logView.DataGridOutputLog.Rows.Clear();
            foreach (Entry entry in GetEntriesType("EntryBlacklist"))
            {
                _logView.DataGridOutputLog.Rows.Add(entry.ToString().Replace('\t', ' '));
            }
        }
        private void ShowLogSincro(object sender, EventArgs args)
        {
            _logView.DataGridOutputLog.Rows.Clear();
            foreach (Entry entry in GetEntriesType("EntrySincronizzazione"))
            {
                _logView.DataGridOutputLog.Rows.Add(entry.ToString().Replace('\t', ' '));
            }
        }

        private void ShowLogCompressione(object sender, EventArgs args)
        {
            _logView.DataGridOutputLog.Rows.Clear();
            foreach (Entry entry in GetEntriesType("EntryAnalisi"))
            {
                _logView.DataGridOutputLog.Rows.Add(entry.ToString().Replace('\t', ' '));
            }
        }

        private void ShowLogSistema(object sender, EventArgs args)
        {
            _logView.DataGridOutputLog.Rows.Clear();
            foreach (Entry entry in GetEntriesType("EntrySistema"))
            {
                _logView.DataGridOutputLog.Rows.Add(entry.ToString().Replace('\t', ' '));
            }
        }



        private IList<Entry> GetEntriesType(string type){
            return _log.Entries.Where(x => x.GetType().Name.Equals(type)).ToList();
        }
    }
}
