﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace ClickOnceDMService
{
    public partial class Service : ServiceBase
    {
        private System.Timers.Timer timer;
        public Service()
        {
            InitializeComponent();

            timer = new System.Timers.Timer(10000);
            timer.Enabled = false;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Elapsed);
        }

        protected override void OnStart(string[] args)
        {
            timer.Enabled = true;
            timer.Start();
        }

        protected override void OnStop()
        {
            timer.Enabled = false;
            timer.Stop();
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            System.Console.WriteLine("timer");
        }
    }
}
