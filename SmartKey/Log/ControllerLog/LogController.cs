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
            _logPersistence = new ConcreteLogPersistence("C:\\Users\\massi\\Desktop\\log.txt");
            _log = _logPersistence.LeggiLog();
            _logView = _view;
            _logView.RadioButtonData.CheckedChanged += RadioButtonDataHandler;
        }
        private void RadioButtonDataHandler(object sender, EventArgs args)
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
            _log.AddEntry(param.ToEntry);
            _logPersistence.ScriviLog(_log);
        }
        private void ScriviEntry(Entry e)
        {
            _log.AddEntry(e);
        }
        public IList<Entry> Entries
        {
            get
            {
                return _log.Entries;
            }
        }
        //TODO GENTRIESINTIME
        //GETENTRIESTIPE
    }
}
