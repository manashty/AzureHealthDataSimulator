using HEAL_Core_Simlulation.HEAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEAL_Core_Simlulation
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            
        }
        HEALCore HEAL;
        private void btn_StartHeal_Click(object sender, EventArgs e)
        {
            HEAL = new HEALCore();
            timer_Insights.Start();
        }

        private void btn_StopHeal_Click(object sender, EventArgs e)
        {
            HEAL.Stop();
            timer_Insights.Stop();
        }

        private void timer_Insights_Tick(object sender, EventArgs e)
        {
            HEALCore._UI.DisplayInsights();
            DisplayInsights();
        }

        private void DisplayInsights()
        {
            lbl_DevicesPackets.Text = HEALCore._insights.DevicePackets.ToString();
            lbl_TransformedPacketsNo.Text = HEALCore._insights.TransformedPackets.ToString();
            lbl_PredictionPacketsNo.Text = HEALCore._insights.PredictedPackets.ToString();
        }
    }
}
