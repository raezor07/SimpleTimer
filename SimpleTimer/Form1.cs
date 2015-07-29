#region Using Section

using System;
using System.Windows.Forms;

#endregion

namespace SimpleTimer
{
    public partial class Form1 : Form
    {
        private static DateTime sessionDateTime;

        public Form1()
        {
            InitializeComponent();
            btnEndTimer.Enabled = false;
        }

        private void tmrSimple_Tick(object sender, EventArgs e)
        {
            // Using String format and building a string using the Current DateTime.Now object to minus the started DateTime Object from it.
            // To get the difference between the 2 DateTime values. This then gives me the hours/minutes/seconds
            // I then grab the values from it.

            var dateTimeDiff = (DateTime.Now - sessionDateTime);

            lblTime.Text = string.Format("{0}:{1}:{2}", DecimalPlacesForced2(dateTimeDiff.Hours),
                DecimalPlacesForced2(dateTimeDiff.Minutes),
                DecimalPlacesForced2(dateTimeDiff.Seconds));
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            btnEndTimer.Enabled = true;
            btnStartTimer.Enabled = false;

            sessionDateTime = DateTime.Now;
            lblTime.Text = @"00:00:00";

            // Starts the timer object that then executes it own thread to handle the tmrSimple_Tick(object sender, EventArgs e) Event.
            tmrSimple.Start();
        }

        private void btnEndTimer_Click(object sender, EventArgs e)
        {
            btnEndTimer.Enabled = false;
            btnStartTimer.Enabled = true;

            // Remember to record the end DateTime here... :)

            // Stops the timer...
            tmrSimple.Stop();
        }

        // This method only adds a 0 if the time value is less than 10. Example: if seconds is 5 then a 0 is added in front of it.
        // so then the value is 05. Else if the value is larger than 10 then only the value is returned.
        private static string DecimalPlacesForced2(int time)
        {
            return time < 10 ? string.Format("0{0}", time) : time.ToString();
        }
    }
}