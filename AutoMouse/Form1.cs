using AutoMouse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMouse
{
    public partial class Form1 : Form
    {
        #region full view 模式的尺寸位置
        private int growWidth;
        private int growHeight;
        private int growTop;
        private int growLeft;
        #endregion

        #region elf related member
        private BindingList<ElfBase> elfList = new BindingList<ElfBase>();
        #endregion

        #region run related member
        public static bool isRunning = false;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 4; i++)
            //{
            //    elfList.Add(new ClickElf());
            //    elfList.Add(new ExeElf());
            //    elfList.Add(new ColorElf());
            //}

            listBox_seq.DataSource = elfList;
            listBox_seq.DisplayMember = "ElfName";

            growWidth = this.Width;
            growHeight = this.Height;
            growTop = this.Top;
            growLeft = this.Left;
        }

        private void tool_grow_shrink_Click(object sender, EventArgs e)
        {
            // 微缩模式 => Full view
            if (tableLayoutPanel_shrink.Visible)
            {
                this.Width = growWidth;
                this.Height = growHeight;
                this.Top = growTop;
                this.Left = growLeft;

                this.AutoSize = false;
                this.AutoSizeMode = AutoSizeMode.GrowOnly;
            }
            // Full view => 微缩模式
            else
            {
                growWidth = this.Width;
                growHeight = this.Height;
                growTop = this.Top;
                growLeft = this.Left;

                this.AutoSize = true;
                this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            }

            listBox_seq.Visible = tableLayoutPanel_shrink.Visible;
            toolStrip_list_seq.Visible = tableLayoutPanel_shrink.Visible;
            toolStrip_fullView.Visible = tableLayoutPanel_shrink.Visible;

            tableLayoutPanel_shrink.Visible = !tableLayoutPanel_shrink.Visible;
        }

        private void tool_run_stop_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                isRunning = false;
                tool_run_stop.Text = "运行";
                btn_run_stop.Text = tool_run_stop.Text;
            }
            else
            {
                isRunning = true;
                tool_run_stop.Text = "停止";
                btn_run_stop.Text = tool_run_stop.Text;

                Task.Factory.StartNew(ElfListSpellcast);
            }
        }

        private void ElfListSpellcast()
        {
            while (isRunning)
            {
                foreach (var elf in elfList)
                {
                    elf.Spellcast();
                    status_run_status.Text = elf.ElfName;
                }
            }
        }

        private void tool_runExe_Click(object sender, EventArgs e)
        {
            ElfBase elf = new ExeElf();
            elfList.Add(elf);
            listBox_seq.SelectedItem = elf;
        }

        private void tool_clickBtn_Click(object sender, EventArgs e)
        {
            ElfBase elf = new ClickElf();
            elfList.Add(elf);
            listBox_seq.SelectedItem = elf;
        }

        private void tool_checkColor_Click(object sender, EventArgs e)
        {
            ElfBase elf = new ColorElf();
            elfList.Add(elf);
            listBox_seq.SelectedItem = elf;
        }

        private void tool_delTool_Click(object sender, EventArgs e)
        {
            if (listBox_seq.SelectedItem != null)
            {
                ElfBase elf = listBox_seq.SelectedItem as ElfBase;
                elfList.Remove(elf);
            }
        }

        private void tool_moveUpTool_Click(object sender, EventArgs e)
        {
            if (listBox_seq.SelectedItem != null)
            {
                ElfBase elf = listBox_seq.SelectedItem as ElfBase;
                int index = elfList.IndexOf(elf);
                if (index <= 0) return;
                elfList.Remove(elf);
                elfList.Insert(index - 1, elf);
                listBox_seq.SelectedItem = elf;
            }
        }

        private void tool_moveDownTool_Click(object sender, EventArgs e)
        {
            if (listBox_seq.SelectedItem != null)
            {
                ElfBase elf = listBox_seq.SelectedItem as ElfBase;
                int index = elfList.IndexOf(elf);
                if (index >= elfList.Count - 1) return;
                elfList.Remove(elf);
                elfList.Insert(index + 1, elf);
                listBox_seq.SelectedItem = elf;
            }
        }

        private void listBox_seq_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_seq.SelectedItem != null)
            {
                ElfBase elf = listBox_seq.SelectedItem as ElfBase;
                elf.GetSettingForm().ShowDialog();
            }
        }
    }
}
