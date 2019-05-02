using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace AutoMouse.Models
{
    [Serializable]
    public class ClickElf : ElfBase
    {
        private static ClickElfForm clickElfForm;
        public TargetWindowInfo targetWinInfo = new TargetWindowInfo();

        public ClickElf()
        {
            ElfName = "点击按钮";
        }

        public override void Spellcast()
        {
            if (!Form1.isRunning) return;
            var sim = new InputSimulator();
            MouseKeyHook.mouseMoveTo(sim,
                MouseKeyHook.TransferCoordinate(MouseKeyHook.GetWindowHandle(targetWinInfo.TargetWindowTitle),
                targetWinInfo.WindowPosition));
            sim.Mouse
               .LeftButtonClick();
        }

        public override Form GetSettingForm()
        {
            if (clickElfForm == null)
            {
                clickElfForm = new ClickElfForm();
            }
            clickElfForm.LoadElf(this);
            return clickElfForm;
        }
    }
}
