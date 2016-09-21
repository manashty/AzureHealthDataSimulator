using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEAL_Core_Simlulation.HEAL.Controllers.UI
{
    public class UIController
    {
        public static void Display(string message, string pipe="")
        {
            //Display
            Debug.WriteLine(pipe + ": " + message);
        }

        public void DisplayInsights()
        {
           
        }
    }
}
