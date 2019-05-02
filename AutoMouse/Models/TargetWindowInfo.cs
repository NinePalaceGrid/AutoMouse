using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMouse.Models
{
    [Serializable]
    public class TargetWindowInfo
    {
        public Point WindowPosition { get; set; } = new Point(0, 0);
        public IntPtr TargetWindowHandle { get; set; }
        public string TargetWindowTitle { get; set; } = "";

        public TargetWindowInfo()
        {

        }
    }
}
