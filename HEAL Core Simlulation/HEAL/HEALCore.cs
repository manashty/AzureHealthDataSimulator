using HEAL_Core_Simlulation.HEAL.Acquisition;
using HEAL_Core_Simlulation.HEAL.Analytics;
using HEAL_Core_Simlulation.HEAL.Controllers.Cloud;
using HEAL_Core_Simlulation.HEAL.Controllers.Device;
using HEAL_Core_Simlulation.HEAL.Controllers.HACC;
using HEAL_Core_Simlulation.HEAL.Controllers.Storage;
using HEAL_Core_Simlulation.HEAL.Controllers.UI;
using HEAL_Core_Simlulation.HEAL.Insights;
using HEAL_Core_Simlulation.HEAL.Transformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEAL_Core_Simlulation.HEAL
{
    public class HEALCore
    {
        public static AcquisitionCore _aquisition = new AcquisitionCore();
        public static TransformationCore _transformation = new TransformationCore();

        internal void Stop()
        {
            _device.Stop();
            _transformation.Stop();
            _analytics.Stop();
        }

        public static AnalyticsCore _analytics = new AnalyticsCore();
        public static InsightsCore _insights = new InsightsCore();
        public static CloudController _cloud = new CloudController();
        public static DeviceController _device = new DeviceController();
        public static HACCController _HACC = new HACCController();
        public static StorageController _storage = new StorageController();
        public static UIController _UI = new UIController();

        public HEALCore()
        {
            _device.Start();
            _transformation.Start();
            _analytics.Start();
        }
    }


}
