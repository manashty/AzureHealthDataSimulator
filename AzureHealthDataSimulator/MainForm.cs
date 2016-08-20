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

namespace AzureHealthDataSimulator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_StartSimulation_Click(object sender, EventArgs e)
        {
            //Populate Values
            List<DeviceSensors> sensorValues = new List<DeviceSensors>();
            for (int i = 0; i < 1000; i++)
            {
                sensorValues.Add(new DeviceSensors());
                Debug.WriteLine(sensorValues.Last());
            }
        }

        class DeviceSensors
        {
            public BloodPressure BP { get; set; } = new BloodPressure();
            public HeartBeat HB { get; set; } = new HeartBeat();

            public override string ToString()
            {
                return BP + ", " + HB;
            }
        }

        class BloodPressure
        {
            public float Systolic { get; set; }
            public float Diastolic { get; set; }

            public DateTime Timestamp { get; set; } = DateTime.Now;
            static Random r = new Random();
            public BloodPressure()
            {
                Systolic = r.Next(9, 15) + (float)Math.Round(r.NextDouble(), 1);
                Diastolic = r.Next(6, 11) + (float)Math.Round(r.NextDouble(), 1);
            }

            public override string ToString() { return $"{{Systolic: {Systolic}, Diastolic: {Diastolic} at {Timestamp.ToString()}}}"; }

        }

        class HeartBeat
        {
            public short Value { get; set; }
            //public float Diastolic { get; set; }
            static Random r = new Random();
            public DateTime Timestamp { get; set; } = DateTime.Now;
            public HeartBeat()
            {
                Value = (short)r.Next(60, 180); ;
                //Diastolic = r.Next(9, 15) + (float)Math.Round(r.NextDouble(), 1);
            }
            public override string ToString() { return $"{{Heartbeat: {Value} at {Timestamp.ToString()}}}"; }
        }
    }
}
