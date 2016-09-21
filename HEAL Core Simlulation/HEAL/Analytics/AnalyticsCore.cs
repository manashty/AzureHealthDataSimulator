using HEAL_Core_Simlulation.HEAL.Controllers.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HEAL_Core_Simlulation.HEAL.Analytics
{
    public class AnalyticsCore
    {

        Thread threadDevices;
        public void Start()
        {

            isRunning = true;
            threadDevices = new Thread(new ThreadStart(Analyzing));

            threadDevices.Start();

        }

        public void Stop()
        {
            isRunning = false;
            threadDevices.Abort();
            threadDevices.Join();
        }

        static bool isRunning = false;
        static void Analyzing()
        {
            while (isRunning)
            {
                if (HEAL.HEALCore._storage.processedData.Count > 10)
                {
                    List<DeviceSensors> sensorValues = new List<DeviceSensors>();
                    for (int i = 0; i < 10; i++)//Remove 10
                    {
                        sensorValues.Add(HEAL.HEALCore._storage.processedData.Dequeue());
                    }

                    var s = Predict(sensorValues);
                    HEAL.HEALCore._storage.predictedData.Enqueue(s);
                    Controllers.UI.UIController.Display("Predicted value added. " + s.ToString(), "AnalyticsController");
                    HEAL.HEALCore._insights.PredictedPackets++;
                }
            }
        }

        private static DeviceSensors Predict(List<DeviceSensors> sensorValues)
        {
            return sensorValues.Last();
        }
    }
}
