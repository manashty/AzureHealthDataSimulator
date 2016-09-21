using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEAL_Core_Simlulation.HEAL.Insights
{
    public class InsightsCore
    {
        public long DevicePackets { get; set; }
        public long PredictedPackets { get; internal set; }
        public long TransformedPackets { get; set; }

    }
}
