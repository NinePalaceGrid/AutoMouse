using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMouse.Models
{
    [Serializable]
    public class ExeElf : ElfBase
    {
        public string ExePath { get; set; }
        private static ExeElfForm exeElfForm;

        public ExeElf()
        {
            ElfName = "运行Exe";
        }

        public override void Spellcast()
        {
            Process p = new Process();
            p.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
            p.StartInfo.FileName = ExePath;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();
        }

        public override Form GetSettingForm()
        {
            if (exeElfForm == null)
            {
                exeElfForm = new ExeElfForm();
            }
            exeElfForm.LoadElf(this);
            return exeElfForm;
        }
    }
}
