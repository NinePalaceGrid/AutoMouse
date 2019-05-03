using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMouse.Models
{
    public partial class ExeElfForm : Form
    {
        private ExeElf exeElf;

        public ExeElfForm()
        {
            InitializeComponent();
        }

        public void LoadElf(ExeElf exeElf)
        {
            this.exeElf = exeElf;
            tb_exePath.Text = exeElf.ExePath;
        }

        private void btn_selectExe_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Exe(*.exe)|*.exe";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_exePath.Text = openFileDialog1.FileName;
                exeElf.ExePath = tb_exePath.Text;
            }
        }

        private void btn_runTest_Click(object sender, EventArgs e)
        {
            exeElf.Spellcast();
        }
    }
}
