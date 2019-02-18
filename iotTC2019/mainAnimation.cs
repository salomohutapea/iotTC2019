using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace iotTC2019
{
    class mainAnimation
    {
        public const int CENTER = 0X4;

        public const int BLEND = 0X90000;

        public const int AW_HIDE = 0x1;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlag);
    }
}
