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
    public partial class ColorElfForm : Form
    {
        private IKeyboardMouseEvents m_GlobalHook;
        private ColorElf colorElf;

        public ColorElfForm()
        {
            InitializeComponent();
        }

        public void LoadElf(ColorElf colorElf)
        {
            this.colorElf = colorElf;
            UpdateInfo();
        }

        private void ColorElfForm_Load(object sender, EventArgs e)
        {
        }

        private void ColorElfForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unsubscribe();
        }

        private void btn_selectPoint_Click(object sender, EventArgs e)
        {
            Subscribe();
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
            colorElf.targetWinInfo.TargetWindowHandle = MouseKeyHook.GetForegroundWindow();

            RECT rc = new RECT();
            MouseKeyHook.GetWindowRect(colorElf.targetWinInfo.TargetWindowHandle, ref rc);
            int x = rc.Left;
            int y = rc.Top;

            colorElf.targetWinInfo.WindowPosition = new Point(e.X - x, e.Y - y); ;

            StringBuilder s = new StringBuilder(512);
            int i = MouseKeyHook.GetWindowText(colorElf.targetWinInfo.TargetWindowHandle.ToInt32(), s, s.Capacity);

            colorElf.targetWinInfo.TargetWindowTitle = s.ToString();

            UpdateInfo();

            Unsubscribe();
        }

        private void UpdateInfo()
        {
            tb_winTitle.Text = colorElf.targetWinInfo.TargetWindowTitle;

            tb_relativePoint.Text = colorElf.targetWinInfo.WindowPosition.X + "," +
                colorElf.targetWinInfo.WindowPosition.Y;
        }
    }
}
