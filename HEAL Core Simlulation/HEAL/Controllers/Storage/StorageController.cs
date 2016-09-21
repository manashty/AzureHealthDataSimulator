using HEAL_Core_Simlulation.HEAL.Controllers.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEAL_Core_Simlulation.HEAL.Controllers.Storage
{    
    public class StorageController
    {
        public Queue<Device.DeviceSensors> biomedicalDevices = new Queue<Device.DeviceSensors>();
        public Queue<DeviceSensors> processedData = new Queue<DeviceSensors>();
        public Queue<DeviceSensors> predictedData = new Queue<DeviceSensors>();
        public List<Object> situationData = new List<object>();


    }
}
