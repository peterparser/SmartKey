﻿using NUnit.Framework;
using SmartKey.Controller.Controller.Interfaces;
using SmartKey.Log.ControllerLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller.TestController
{
    [TestFixture]
    class TestLogSistema
    {
        IGestoreProtezioneDati _protec;
        IObserver _controller;

        public void Init()
        {
            _protec = new ProtezioneDatiController();
            _controller = new LogController(new HomeLog());
            _protec.ToLog += _controller.Update;

        }

        [TestCase]
        public void TestLog()
        {
            Init();
            _protec.ProteggiCartella("C:\\Users\\massi\\Desktop\\sistem");

        }
    }
}