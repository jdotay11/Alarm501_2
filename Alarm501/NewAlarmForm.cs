/**
 * Jay Brown
 * CIS 501
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    public partial class NewAlarmForm : Form
    {
        private BindingList<Alarm> alarmList;

        Alarm alarm;

        bool isEditing;

        public NewAlarmForm(BindingList<Alarm> list, Alarm current = null)
        {
            InitializeComponent();
            uxDateTimePicker.Value = DateTime.Now;
            uxDateTimePicker.Format = DateTimePickerFormat.Time;

            alarmList = list;
            alarm = new Alarm(DateTime.Now, false);

            if(current == null)
            {
                alarm = new Alarm(DateTime.Now, false);
            }
            else
            {
                alarm = current;
                uxDateTimePicker.Value = alarm.time;

                if(alarm.Status == AlarmStatus.RUNNING)
                {
                    uxSetOnOff.Checked = true;
                }
                else
                {
                    uxSetOnOff.Checked = false;
                }

                isEditing = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (uxSetOnOff.Checked == true)
            {
                uxSetOnOff.Text = "ON";
            }
            else
            {
                uxSetOnOff.Text = "OFF";
            }
        }

        private void uxCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxSetBtn_Click(object sender, EventArgs e)
        {
            alarm.time = uxDateTimePicker.Value;

            if(uxSetOnOff.Checked == true)
            {
                alarm.Status = AlarmStatus.RUNNING;
            }
            else
            {
                alarm.Status = AlarmStatus.STOPPED;
            }

            if(isEditing == true)
            {
                alarmList.Remove(alarm);
                alarmList.Add(alarm);
            }
            else
            {
                alarmList.Add(alarm);
            }

            this.Close();
        }
    }
}
