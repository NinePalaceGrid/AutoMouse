namespace AutoMouse.Models
{
    partial class ExeElfForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tb_exePath = new System.Windows.Forms.TextBox();
            this.btn_selectExe = new System.Windows.Forms.Button();
            this.btn_runTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tb_exePath
            // 
            this.tb_exePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_exePath.Location = new System.Drawing.Point(12, 12);
            this.tb_exePath.Name = "tb_exePath";
            this.tb_exePath.Size = new System.Drawing.Size(179, 21);
            this.tb_exePath.TabIndex = 0;
            // 
            // btn_selectExe
            // 
            this.btn_selectExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_selectExe.Location = new System.Drawing.Point(201, 10);
            this.btn_selectExe.Name = "btn_selectExe";
            this.btn_selectExe.Size = new System.Drawing.Size(75, 23);
            this.btn_selectExe.TabIndex = 1;
            this.btn_selectExe.Text = "选择exe";
            this.btn_selectExe.UseVisualStyleBackColor = true;
            this.btn_selectExe.Click += new System.EventHandler(this.btn_selectExe_Click);
            // 
            // btn_runTest
            // 
            this.btn_runTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_runTest.Location = new System.Drawing.Point(201, 45);
            this.btn_runTest.Name = "btn_runTest";
            this.btn_runTest.Size = new System.Drawing.Size(75, 23);
            this.btn_runTest.TabIndex = 3;
            this.btn_runTest.Text = "试运行";
            this.btn_runTest.UseVisualStyleBackColor = true;
            this.btn_runTest.Click += new System.EventHandler(this.btn_runTest_Click);
            // 
            // ExeElfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 80);
            this.Controls.Add(this.btn_runTest);
            this.Controls.Add(this.btn_selectExe);
            this.Controls.Add(this.tb_exePath);
            this.Name = "ExeElfForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "打开Exe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tb_exePath;
        private System.Windows.Forms.Button btn_selectExe;
        private System.Windows.Forms.Button btn_runTest;
    }
}