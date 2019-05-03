using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMouse.Models
{
    [Serializable]
    public class ColorElf : ElfBase
    {
        private static ColorElfForm colorElfForm;
        public TargetWindowInfo targetWinInfo = new TargetWindowInfo();

        public ColorElf()
        {
            ElfName = "检查颜色";
        }

        public override void Spellcast()
        {
            if (!Form1.isRunning) return;

            Point p = MouseKeyHook.TransferCoordinate(MouseKeyHook.GetWindowHandle(targetWinInfo.TargetWindowTitle),
                targetWinInfo.WindowPosition);
        }

        public override Form GetSettingForm()
        {
            if (colorElfForm == null)
            {
                colorElfForm = new ColorElfForm();
            }
            colorElfForm.LoadElf(this);
            return colorElfForm;
        }
    }
}
