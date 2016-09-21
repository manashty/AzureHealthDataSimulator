using HEAL_Core_Simlulation.HEAL.Controllers.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HEAL_Core_Simlulation.HEAL.Transformation
{
    public class TransformationCore
    {

        Thread threadDevices;
        public void Start()
        {

            isRunning = true;
            threadDevices = new Thread(new ThreadStart(Abstracting));

            threadDevices.Start();



        }

        public void Stop()
        {
            isRunning = false;
            threadDevices.Abort();
            threadDevices.Join();
        }

        static bool isRunning = false;
        static void Abstracting()
        {
            while (isRunning)
            {
                if (HEAL.HEALCore._storage.biomedicalDevices.Count > 10)
                {
                    List<DeviceSensors> sensorValues = new List<DeviceSensors>();
                    for (int i = 0; i < 10; i++)//Remove 10
                    {
                        sensorValues.Add(HEAL.HEALCore._storage.biomedicalDevices.Dequeue());
                    }

                    var s = Summarize(sensorValues);
                    HEAL.HEALCore._storage.processedData.Enqueue(s);
                    Controllers.UI.UIController.Display("Summary value added. "+s.ToString(), "TransformationController");
                    HEAL.HEALCore._insights.TransformedPackets++;
                }                                                    
            }
        }

        private static DeviceSensors Summarize(List<DeviceSensors> sensorValues)
        {            
            return sensorValues.Last();            
        }

        public TransformationCore()
        {

        }
    }
}
