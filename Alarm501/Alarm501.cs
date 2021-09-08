/**
 * Jay Brown
 * CIS 501
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Alarm501
{
    public partial class Alarm501 : Form
    {
        private BindingList<Alarm> alarms = new BindingList<Alarm>();

        private System.Timers.Timer timer;

        private int index = 0;

        public Alarm501()
        {
            InitializeComponent();

            if (File.Exists("..\\..\\Alarms.txt"))
            {
                StreamReader sr = new StreamReader("..\\..\\Alarms.txt");
                while (!sr.EndOfStream)
                {
                    string[] alarmData = sr.ReadLine().Split(',');

                    bool status = false;

                    if(alarmData[1] == "RUNNING")
                    {
                        status = true;
                    }

                    Alarm temp = new Alarm(DateTime.Parse(alarmData[0]), status);
                    alarms.Add(temp);
                }

                sr.Close();
            }

            uxAlarmList.DataSource = alarms;

            timer = new System.Timers.Timer(1000);
            timer.Elapsed += CheckAlarms;
            timer.SynchronizingObject = this;
            timer.AutoReset = true;
            timer.Start();

            label.Text = "Start an Alarm";

            if (uxAlarmList.SelectedItem != null) { uxEditBtn.Enabled = true; }
        }

        private void CheckAlarms(object sender, ElapsedEventArgs e)
        {
            DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

            foreach (Alarm a in alarms)
            {
                if (a.Status == AlarmStatus.RUNNING && TimeSpan.Compare(a.time.TimeOfDay, now.TimeOfDay) == 0)
                {
                    SignalAlarm(alarms.IndexOf(a));
                }
            }
        }

        private void SignalAlarm(int alarmIdx)
        {
            index = alarmIdx;

            uxSnoozeBtn.Enabled = true;
            uxStopBtn.Enabled = true;

            label.Text = "BEEP BEEP BEEP";
        }

        private void uxAddBtn_Click(object sender, EventArgs e)
        {
            NewAlarmForm naf = new NewAlarmForm(alarms); ;
            naf.ShowDialog();

            label.Text = "Running...";
        }

        private void uxEditBtn_Click(object sender, EventArgs e)
        {
            Alarm selectedAlarm = (Alarm)uxAlarmList.SelectedItem;

            NewAlarmForm newAlarm = new NewAlarmForm(alarms, selectedAlarm);
            newAlarm.Show();

            label.Text = "Running...";
        }

        private void uxSnoozeBtn_Click(object sender, EventArgs e)
        {
            Alarm temp = alarms[index];

            temp.time = temp.time.AddSeconds(3);
            alarms.Remove(alarms[index]);
            alarms.Add(temp);

            uxSnoozeBtn.Enabled = false;
            uxStopBtn.Enabled = false;

            label.Text = "Snoozed..Running..";
        }

        private void uxStopBtn_Click(object sender, EventArgs e)
        {
            alarms[index].Status = AlarmStatus.STOPPED;

            Alarm temp = alarms[index];
            alarms.Remove(alarms[index]);
            alarms.Add(temp);

            uxSnoozeBtn.Enabled = false;
            uxStopBtn.Enabled = false;

            label.Text = "Alarm Stopped";
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            if (File.Exists("..\\..\\AlarmData.txt"))
            {
                using (StreamWriter sw = new StreamWriter("..\\..\\Alarms.txt"))
                {
                    foreach (Alarm a in alarms)
                    {
                        sw.WriteLine(a.time.ToString("h:mm:ss tt") + "," + a.Status.ToString());
                    }
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText("..\\..\\Alarms.txt"))
                {
                    foreach (Alarm a in alarms)
                    {
                        sw.WriteLine(a.time.ToString("h:mm:ss tt") + "," + a.Status.ToString());
                    }
                }
            }
        }
    }
}
