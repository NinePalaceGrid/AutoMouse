namespace AutoMouse.Models
{
    partial class ColorElfForm
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
            this.tb_relativePoint = new System.Windows.Forms.TextBox();
            this.tb_winTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_selectPoint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_relativePoint
            // 
            this.tb_relativePoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_relativePoint.Location = new System.Drawing.Point(100, 83);
            this.tb_relativePoint.Name = "tb_relativePoint";
            this.tb_relativePoint.Size = new System.Drawing.Size(151, 21);
            this.tb_relativePoint.TabIndex = 9;
            // 
            // tb_winTitle
            // 
            this.tb_winTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_winTitle.Location = new System.Drawing.Point(100, 53);
            this.tb_winTitle.Name = "tb_winTitle";
            this.tb_winTitle.Size = new System.Drawing.Size(151, 21);
            this.tb_winTitle.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "按钮相对坐标";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "窗口标题";
            // 
            // btn_selectPoint
            // 
            this.btn_selectPoint.Location = new System.Drawing.Point(12, 12);
            this.btn_selectPoint.Name = "btn_selectPoint";
            this.btn_selectPoint.Size = new System.Drawing.Size(75, 23);
            this.btn_selectPoint.TabIndex = 5;
            this.btn_selectPoint.Text = "选择位置";
            this.btn_selectPoint.UseVisualStyleBackColor = true;
            this.btn_selectPoint.Click += new System.EventHandler(this.btn_selectPoint_Click);
            // 
            // ColorElfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tb_relativePoint);
            this.Controls.Add(this.tb_winTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_selectPoint);
            this.Name = "ColorElfForm";
            this.Text = "检查颜色";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColorElfForm_FormClosing);
            this.Load += new System.EventHandler(this.ColorElfForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_relativePoint;
        private System.Windows.Forms.TextBox tb_winTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_selectPoint;
    }
}