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
    public partial class ClickElfForm : Form
    {
        private MouseKeyHook mouseKeyHook;
        private ClickElf clickElf;

        public ClickElfForm()
        {
            InitializeComponent();
        }

        public void LoadElf(ClickElf clickElf)
        {
            this.clickElf = clickElf;
        }

        private void ClickElfForm_Load(object sender, EventArgs e)
        {
            mouseKeyHook = new MouseKeyHook(clickElf.targetWinInfo);
        }

        private void ClickElfForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mouseKeyHook.Unsubscribe();
        }

        private void btn_clickBtn_Click(object sender, EventArgs e)
        {
            mouseKeyHook.Subscribe();
        }

        private void btn_runTest_Click(object sender, EventArgs e)
        {
        }
    }
}
