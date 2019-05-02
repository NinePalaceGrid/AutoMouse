namespace AutoMouse
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_run_stop = new System.Windows.Forms.Button();
            this.btn_grow_shrink = new System.Windows.Forms.Button();
            this.tableLayoutPanel_shrink = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_run_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.listBox_seq = new System.Windows.Forms.ListBox();
            this.toolStrip_list_seq = new System.Windows.Forms.ToolStrip();
            this.tool_addTool = new System.Windows.Forms.ToolStripDropDownButton();
            this.tool_checkColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_clickBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_runExe = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_delTool = new System.Windows.Forms.ToolStripButton();
            this.tool_moveUpTool = new System.Windows.Forms.ToolStripButton();
            this.tool_moveDownTool = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_fullView = new System.Windows.Forms.ToolStrip();
            this.tool_grow_shrink = new System.Windows.Forms.ToolStripButton();
            this.tool_run_stop = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel_shrink.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip_list_seq.SuspendLayout();
            this.toolStrip_fullView.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_run_stop
            // 
            this.btn_run_stop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_run_stop.Location = new System.Drawing.Point(3, 3);
            this.btn_run_stop.Name = "btn_run_stop";
            this.btn_run_stop.Size = new System.Drawing.Size(78, 54);
            this.btn_run_stop.TabIndex = 0;
            this.btn_run_stop.Text = "运行";
            this.btn_run_stop.UseVisualStyleBackColor = true;
            this.btn_run_stop.Click += new System.EventHandler(this.tool_run_stop_Click);
            // 
            // btn_grow_shrink
            // 
            this.btn_grow_shrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_grow_shrink.Location = new System.Drawing.Point(87, 3);
            this.btn_grow_shrink.Name = "btn_grow_shrink";
            this.btn_grow_shrink.Size = new System.Drawing.Size(79, 54);
            this.btn_grow_shrink.TabIndex = 1;
            this.btn_grow_shrink.Text = "缩放";
            this.btn_grow_shrink.UseVisualStyleBackColor = true;
            this.btn_grow_shrink.Click += new System.EventHandler(this.tool_grow_shrink_Click);
            // 
            // tableLayoutPanel_shrink
            // 
            this.tableLayoutPanel_shrink.ColumnCount = 2;
            this.tableLayoutPanel_shrink.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_shrink.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_shrink.Controls.Add(this.statusStrip1, 0, 1);
            this.tableLayoutPanel_shrink.Controls.Add(this.btn_run_stop, 0, 0);
            this.tableLayoutPanel_shrink.Controls.Add(this.btn_grow_shrink, 1, 0);
            this.tableLayoutPanel_shrink.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_shrink.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_shrink.Name = "tableLayoutPanel_shrink";
            this.tableLayoutPanel_shrink.RowCount = 2;
            this.tableLayoutPanel_shrink.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_shrink.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_shrink.Size = new System.Drawing.Size(169, 82);
            this.tableLayoutPanel_shrink.TabIndex = 2;
            this.tableLayoutPanel_shrink.Visible = false;
            // 
            // statusStrip1
            // 
            this.tableLayoutPanel_shrink.SetColumnSpan(this.statusStrip1, 2);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_run_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 60);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(169, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_run_status
            // 
            this.status_run_status.Name = "status_run_status";
            this.status_run_status.Size = new System.Drawing.Size(35, 17);
            this.status_run_status.Text = "状态:";
            // 
            // listBox_seq
            // 
            this.listBox_seq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_seq.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_seq.FormattingEnabled = true;
            this.listBox_seq.ItemHeight = 16;
            this.listBox_seq.Location = new System.Drawing.Point(0, 27);
            this.listBox_seq.Name = "listBox_seq";
            this.listBox_seq.Size = new System.Drawing.Size(284, 210);
            this.listBox_seq.TabIndex = 0;
            this.listBox_seq.DoubleClick += new System.EventHandler(this.listBox_seq_DoubleClick);
            // 
            // toolStrip_list_seq
            // 
            this.toolStrip_list_seq.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip_list_seq.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_addTool,
            this.tool_delTool,
            this.tool_moveUpTool,
            this.tool_moveDownTool});
            this.toolStrip_list_seq.Location = new System.Drawing.Point(0, 237);
            this.toolStrip_list_seq.Name = "toolStrip_list_seq";
            this.toolStrip_list_seq.Size = new System.Drawing.Size(284, 25);
            this.toolStrip_list_seq.TabIndex = 1;
            this.toolStrip_list_seq.Text = "toolStrip1";
            // 
            // tool_addTool
            // 
            this.tool_addTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tool_addTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_checkColor,
            this.tool_clickBtn,
            this.tool_runExe});
            this.tool_addTool.Image = ((System.Drawing.Image)(resources.GetObject("tool_addTool.Image")));
            this.tool_addTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_addTool.Name = "tool_addTool";
            this.tool_addTool.Size = new System.Drawing.Size(45, 22);
            this.tool_addTool.Text = "添加";
            // 
            // tool_checkColor
            // 
            this.tool_checkColor.Name = "tool_checkColor";
            this.tool_checkColor.Size = new System.Drawing.Size(152, 22);
            this.tool_checkColor.Text = "检查颜色";
            this.tool_checkColor.Click += new System.EventHandler(this.tool_checkColor_Click);
            // 
            // tool_clickBtn
            // 
            this.tool_clickBtn.Name = "tool_clickBtn";
            this.tool_clickBtn.Size = new System.Drawing.Size(152, 22);
            this.tool_clickBtn.Text = "点击按钮";
            this.tool_clickBtn.Click += new System.EventHandler(this.tool_clickBtn_Click);
            // 
            // tool_runExe
            // 
            this.tool_runExe.Name = "tool_runExe";
            this.tool_runExe.Size = new System.Drawing.Size(152, 22);
            this.tool_runExe.Text = "打开Exe";
            this.tool_runExe.Click += new System.EventHandler(this.tool_runExe_Click);
            // 
            // tool_delTool
            // 
            this.tool_delTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tool_delTool.Image = ((System.Drawing.Image)(resources.GetObject("tool_delTool.Image")));
            this.tool_delTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_delTool.Name = "tool_delTool";
            this.tool_delTool.Size = new System.Drawing.Size(36, 22);
            this.tool_delTool.Text = "删除";
            this.tool_delTool.Click += new System.EventHandler(this.tool_delTool_Click);
            // 
            // tool_moveUpTool
            // 
            this.tool_moveUpTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tool_moveUpTool.Image = ((System.Drawing.Image)(resources.GetObject("tool_moveUpTool.Image")));
            this.tool_moveUpTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_moveUpTool.Name = "tool_moveUpTool";
            this.tool_moveUpTool.Size = new System.Drawing.Size(36, 22);
            this.tool_moveUpTool.Text = "上移";
            this.tool_moveUpTool.Click += new System.EventHandler(this.tool_moveUpTool_Click);
            // 
            // tool_moveDownTool
            // 
            this.tool_moveDownTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tool_moveDownTool.Image = ((System.Drawing.Image)(resources.GetObject("tool_moveDownTool.Image")));
            this.tool_moveDownTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_moveDownTool.Name = "tool_moveDownTool";
            this.tool_moveDownTool.Size = new System.Drawing.Size(36, 22);
            this.tool_moveDownTool.Text = "下移";
            this.tool_moveDownTool.Click += new System.EventHandler(this.tool_moveDownTool_Click);
            // 
            // toolStrip_fullView
            // 
            this.toolStrip_fullView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_grow_shrink,
            this.tool_run_stop});
            this.toolStrip_fullView.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_fullView.Name = "toolStrip_fullView";
            this.toolStrip_fullView.Size = new System.Drawing.Size(284, 27);
            this.toolStrip_fullView.TabIndex = 1;
            this.toolStrip_fullView.Text = "toolStrip1";
            // 
            // tool_grow_shrink
            // 
            this.tool_grow_shrink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tool_grow_shrink.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tool_grow_shrink.Image = ((System.Drawing.Image)(resources.GetObject("tool_grow_shrink.Image")));
            this.tool_grow_shrink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_grow_shrink.Name = "tool_grow_shrink";
            this.tool_grow_shrink.Size = new System.Drawing.Size(41, 24);
            this.tool_grow_shrink.Text = "缩放";
            this.tool_grow_shrink.Click += new System.EventHandler(this.tool_grow_shrink_Click);
            // 
            // tool_run_stop
            // 
            this.tool_run_stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tool_run_stop.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tool_run_stop.Image = ((System.Drawing.Image)(resources.GetObject("tool_run_stop.Image")));
            this.tool_run_stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_run_stop.Name = "tool_run_stop";
            this.tool_run_stop.Size = new System.Drawing.Size(41, 24);
            this.tool_run_stop.Text = "运行";
            this.tool_run_stop.Click += new System.EventHandler(this.tool_run_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listBox_seq);
            this.Controls.Add(this.toolStrip_fullView);
            this.Controls.Add(this.tableLayoutPanel_shrink);
            this.Controls.Add(this.toolStrip_list_seq);
            this.Name = "Form1";
            this.Text = "Auto Mouse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel_shrink.ResumeLayout(false);
            this.tableLayoutPanel_shrink.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip_list_seq.ResumeLayout(false);
            this.toolStrip_list_seq.PerformLayout();
            this.toolStrip_fullView.ResumeLayout(false);
            this.toolStrip_fullView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_run_stop;
        private System.Windows.Forms.Button btn_grow_shrink;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_shrink;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_run_status;
        private System.Windows.Forms.ToolStrip toolStrip_fullView;
        private System.Windows.Forms.ToolStripButton tool_grow_shrink;
        private System.Windows.Forms.ToolStripButton tool_run_stop;
        private System.Windows.Forms.ToolStrip toolStrip_list_seq;
        private System.Windows.Forms.ToolStripDropDownButton tool_addTool;
        private System.Windows.Forms.ToolStripMenuItem tool_checkColor;
        private System.Windows.Forms.ToolStripMenuItem tool_clickBtn;
        private System.Windows.Forms.ToolStripMenuItem tool_runExe;
        private System.Windows.Forms.ToolStripButton tool_delTool;
        private System.Windows.Forms.ToolStripButton tool_moveUpTool;
        private System.Windows.Forms.ToolStripButton tool_moveDownTool;
        private System.Windows.Forms.ListBox listBox_seq;
    }
}

