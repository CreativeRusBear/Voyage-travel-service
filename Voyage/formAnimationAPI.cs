using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Voyage
{
    class formAnimationAPI
    {
        public const int H_Positive = 0X1,
                         H_Negative = 0X2,
                         V_Positive = 0X4,
                         V_Negative = 0X8,
                         Center = 0X10,
                         Blend = 0X80000;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlag);
    }
}
