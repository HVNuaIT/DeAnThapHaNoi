
namespace DeAnThapHaNoi
{
    partial class frmKetQua
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.nudSoBuocThucHien = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.ListBox();
            this.pnlTop.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoBuocThucHien)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.nudSoBuocThucHien);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(310, 34);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.lbKetQua);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 34);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(310, 350);
            this.pnlCenter.TabIndex = 1;
            // 
            // nudSoBuocThucHien
            // 
            this.nudSoBuocThucHien.Location = new System.Drawing.Point(141, 8);
            this.nudSoBuocThucHien.Name = "nudSoBuocThucHien";
            this.nudSoBuocThucHien.ReadOnly = true;
            this.nudSoBuocThucHien.Size = new System.Drawing.Size(120, 20);
            this.nudSoBuocThucHien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số bước thực hiện";
            // 
            // lbKetQua
            // 
            this.lbKetQua.FormattingEnabled = true;
            this.lbKetQua.Location = new System.Drawing.Point(3, 9);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(304, 342);
            this.lbKetQua.TabIndex = 0;
            // 
            // frmKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 384);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmKetQua";
            this.Text = "Kết quả";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoBuocThucHien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.NumericUpDown nudSoBuocThucHien;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.ListBox lbKetQua;
    }
}