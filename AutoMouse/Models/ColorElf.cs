using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMouse.Models
{
    [Serializable]
    public class ColorElf : ElfBase
    {
        public ColorElf()
        {
            ElfName = "检查颜色";
        }

        public override void Spellcast()
        {
            if (!Form1.isRunning) return;
        }

        public override Form GetSettingForm()
        {
            throw new NotImplementedException();
        }
    }
}
