
namespace DeAnThapHaNoi
{
    partial class frmBaThapHaNoi
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlCenterRight = new System.Windows.Forms.Panel();
            this.nudDoCao = new System.Windows.Forms.NumericUpDown();
            this.uC_BaThapHaNoi = new DeAnThapHaNoi.UC_BaThapHaNoi();
            this.pnlTop.SuspendLayout();
            this.pnlCenterRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Aqua;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Aqua;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTitle.Location = new System.Drawing.Point(382, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 384);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 66);
            this.pnlBottom.TabIndex = 1;
            // 
            // pnlCenterRight
            // 
            this.pnlCenterRight.Controls.Add(this.nudDoCao);
            this.pnlCenterRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCenterRight.Location = new System.Drawing.Point(458, 100);
            this.pnlCenterRight.Name = "pnlCenterRight";
            this.pnlCenterRight.Size = new System.Drawing.Size(342, 284);
            this.pnlCenterRight.TabIndex = 2;
            // 
            // nudDoCao
            // 
            this.nudDoCao.Enabled = false;
            this.nudDoCao.Location = new System.Drawing.Point(41, 29);
            this.nudDoCao.Name = "nudDoCao";
            this.nudDoCao.ReadOnly = true;
            this.nudDoCao.Size = new System.Drawing.Size(120, 20);
            this.nudDoCao.TabIndex = 0;
            this.nudDoCao.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
          
            // 
            // uC_BaThapHaNoi
            // 
            this.uC_BaThapHaNoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.uC_BaThapHaNoi.Location = new System.Drawing.Point(22, 106);
            this.uC_BaThapHaNoi.Name = "uC_BaThapHaNoi";
            this.uC_BaThapHaNoi.Size = new System.Drawing.Size(403, 260);
            this.uC_BaThapHaNoi.TabIndex = 3;
            // 
            // frmBaThapHaNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uC_BaThapHaNoi);
            this.Controls.Add(this.pnlCenterRight);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmBaThapHaNoi";
            this.Text = "frmBaThapHaNoi";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlCenterRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDoCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlCenterRight;
        private System.Windows.Forms.NumericUpDown nudDoCao;
        private UC_BaThapHaNoi uC_BaThapHaNoi;
    }
}