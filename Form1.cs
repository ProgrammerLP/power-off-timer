using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerOff_Timer
{
    public partial class Form1 : Form
    {
        TimeSpan timeleft;

        public Form1()
        {
            InitializeComponent();
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            CheckTextBoxValues();

            bool isStartable = true;

            try
            {
                timeleft = new TimeSpan(int.Parse(TB_h.Text), int.Parse(TB_min.Text), int.Parse(TB_sec.Text));
            }
            catch (Exception ex)
            {
                isStartable = false;
                MessageBox.Show(ex.Message);
            }

            if (isStartable)
            {
                t1.Start();
                lbl_timer.Text = timeleft.ToString(@"hh\:mm\:ss");
            }

        }

        private void t1_Tick(object sender, EventArgs e)
        {
            timeleft = timeleft.Subtract(TimeSpan.FromSeconds(1));
            try
            {
                lbl_timer.Text = timeleft.ToString(@"hh\:mm\:ss");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (timeleft.TotalSeconds <= 0)
            {
                t1.Stop();
                PerformAction();
            }
        }

        private void PerformAction()
        {
            if (RB_sd.Checked)
            {
                Process.Start("shutdown", "/s");
            }
            else if (RB_rs.Checked)
            {
                Process.Start("shutdown", "/r");
            }
            else if (RB_sp.Checked)
            {
                Process.Start("rundll32.exe", "powrprof.dll,SetSuspendState");
            }
        }
        private void btn_stop_Click(object sender, EventArgs e)
        {
            t1.Stop();
            lbl_timer.Text = "00:00:00";
        }

        private void CheckTextBoxValues()
        {
            if (TB_h.Text.Count() == 0)
            {
                TB_h.Text = "0";
            }

            if (TB_min.Text.Count() == 0)
            {
                TB_min.Text = "0";
            }

            if (TB_sec.Text.Count() == 0)
            {
                TB_sec.Text = "0";
            }
        }

    }
}
