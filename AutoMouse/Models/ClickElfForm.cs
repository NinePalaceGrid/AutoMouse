using Gma.System.MouseKeyHook;
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
        private IKeyboardMouseEvents m_GlobalHook;
        private ClickElf clickElf;

        public ClickElfForm()
        {
            InitializeComponent();
        }

        public void LoadElf(ClickElf clickElf)
        {
            this.clickElf = clickElf;
            UpdateInfo();
        }

        private void ClickElfForm_Load(object sender, EventArgs e)
        {
        }

        private void ClickElfForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unsubscribe();
        }

        private void btn_clickBtn_Click(object sender, EventArgs e)
        {
            Subscribe();
        }

        private void btn_runTest_Click(object sender, EventArgs e)
        {
            clickElf.Spellcast();
        }

        public void Subscribe()
        {
            if (m_GlobalHook == null)
            {
                // Note: for the application hook, use the Hook.AppEvents() instead
                m_GlobalHook = Hook.GlobalEvents();
            }

            m_GlobalHook.MouseClick += OnMouseClick;
        }

        public void Unsubscribe()
        {
            if (m_GlobalHook == null) return;

            m_GlobalHook.MouseDownExt -= OnMouseClick;

            //It is recommened to dispose it
            m_GlobalHook.Dispose();
            m_GlobalHook = null;
        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            clickElf.targetWinInfo.TargetWindowHandle = MouseKeyHook.GetForegroundWindow();

            RECT rc = new RECT();
            MouseKeyHook.GetWindowRect(clickElf.targetWinInfo.TargetWindowHandle, ref rc);
            int x = rc.Left;
            int y = rc.Top;

            clickElf.targetWinInfo.WindowPosition = new Point(e.X - x, e.Y - y); ;

            StringBuilder s = new StringBuilder(512);
            int i = MouseKeyHook.GetWindowText(clickElf.targetWinInfo.TargetWindowHandle.ToInt32(), s, s.Capacity);

            clickElf.targetWinInfo.TargetWindowTitle = s.ToString();

            UpdateInfo();

            Unsubscribe();
        }

        private void UpdateInfo()
        {
            tb_winTitle.Text = clickElf.targetWinInfo.TargetWindowTitle;
            tb_relativePoint.Text = clickElf.targetWinInfo.WindowPosition.X + "," +
                clickElf.targetWinInfo.WindowPosition.Y;
        }
    }
}
