namespace AutoMouse.Models
{
    partial class ClickElfForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_clickBtn = new System.Windows.Forms.Button();
            this.btn_runTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_winTitle = new System.Windows.Forms.TextBox();
            this.tb_relativePoint = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_clickBtn
            // 
            this.btn_clickBtn.Location = new System.Drawing.Point(22, 38);
            this.btn_clickBtn.Name = "btn_clickBtn";
            this.btn_clickBtn.Size = new System.Drawing.Size(75, 23);
            this.btn_clickBtn.TabIndex = 1;
            this.btn_clickBtn.Text = "选择按钮";
            this.btn_clickBtn.UseVisualStyleBackColor = true;
            this.btn_clickBtn.Click += new System.EventHandler(this.btn_clickBtn_Click);
            // 
            // btn_runTest
            // 
            this.btn_runTest.Location = new System.Drawing.Point(132, 38);
            this.btn_runTest.Name = "btn_runTest";
            this.btn_runTest.Size = new System.Drawing.Size(75, 23);
            this.btn_runTest.TabIndex = 2;
            this.btn_runTest.Text = "试运行";
            this.btn_runTest.UseVisualStyleBackColor = true;
            this.btn_runTest.Click += new System.EventHandler(this.btn_runTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "窗口标题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "按钮相对坐标";
            // 
            // tb_winTitle
            // 
            this.tb_winTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_winTitle.Location = new System.Drawing.Point(110, 79);
            this.tb_winTitle.Name = "tb_winTitle";
            this.tb_winTitle.Size = new System.Drawing.Size(151, 21);
            this.tb_winTitle.TabIndex = 4;
            // 
            // tb_relativePoint
            // 
            this.tb_relativePoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_relativePoint.Location = new System.Drawing.Point(110, 109);
            this.tb_relativePoint.Name = "tb_relativePoint";
            this.tb_relativePoint.Size = new System.Drawing.Size(151, 21);
            this.tb_relativePoint.TabIndex = 4;
            // 
            // ClickElfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 147);
            this.Controls.Add(this.tb_relativePoint);
            this.Controls.Add(this.tb_winTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_runTest);
            this.Controls.Add(this.btn_clickBtn);
            this.Name = "ClickElfForm";
            this.Text = "点击按钮";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClickElfForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clickBtn;
        private System.Windows.Forms.Button btn_runTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_winTitle;
        private System.Windows.Forms.TextBox tb_relativePoint;
    }
}