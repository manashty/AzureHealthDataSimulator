using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HEAL_Core_Simlulation.HEAL.Controllers.Device
{
    public class DeviceController
    {

        Thread threadDevices;
        public void Start()
        {
            
            isRunning = true;
            threadDevices = new Thread(new ThreadStart(Sensors));

            threadDevices.Start();

            
            
        }

        public void Stop()
        {
            isRunning = false;
            threadDevices.Abort();
            threadDevices.Join();
        }

        static bool isRunning = false;
        static void Sensors()
        {
            while (isRunning)
            {
                var ds = new DeviceSensors();
                HEAL.HEALCore._storage.biomedicalDevices.Enqueue(ds);

                UI.UIController.Display("Sensor value added. " + ds, "DeviceController");
                HEAL.HEALCore._insights.DevicePackets++;
                //Debug.WriteLine(sensorValues.Last());
            }
        }

        

    

    }
    public class DeviceSensors
    {
        public BloodPressure BP { get; set; } = new BloodPressure();
        public HeartBeat HB { get; set; } = new HeartBeat();

        public override string ToString()
        {
            return BP + ", " + HB;
        }
    }

    public class BloodPressure
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

   public class HeartBeat
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
