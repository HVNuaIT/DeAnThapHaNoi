
namespace DeAnThapHaNoi
{
    partial class frmThapHaNoiDonGian
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
            this.lbDiChuyen = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDoCao = new System.Windows.Forms.NumericUpDown();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.uc_ThapHaNoi2 = new DeAnThapHaNoi.UC_ThapHaNoi();
            this.uc_ThapHaNoi1 = new DeAnThapHaNoi.UC_ThapHaNoi();
            this.uc_ThapHaNoi0 = new DeAnThapHaNoi.UC_ThapHaNoi();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDiChuyen
            // 
            this.lbDiChuyen.FormattingEnabled = true;
            this.lbDiChuyen.Location = new System.Drawing.Point(560, 22);
            this.lbDiChuyen.Name = "lbDiChuyen";
            this.lbDiChuyen.Size = new System.Drawing.Size(197, 212);
            this.lbDiChuyen.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tháp 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tháp 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tháp 2";
            // 
            // nudDoCao
            // 
            this.nudDoCao.Location = new System.Drawing.Point(525, 273);
            this.nudDoCao.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudDoCao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDoCao.Name = "nudDoCao";
            this.nudDoCao.Size = new System.Drawing.Size(41, 20);
            this.nudDoCao.TabIndex = 7;
            this.nudDoCao.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDoCao.ValueChanged += new System.EventHandler(this.nudDoCao_ValueChanged);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(572, 266);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(122, 31);
            this.btnThucHien.TabIndex = 8;
            this.btnThucHien.Text = "Thực hiện 0->2";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(700, 266);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(57, 31);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // uc_ThapHaNoi2
            // 
            this.uc_ThapHaNoi2.AutoScroll = true;
            this.uc_ThapHaNoi2.AutoSize = true;
            this.uc_ThapHaNoi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uc_ThapHaNoi2.Location = new System.Drawing.Point(368, 22);
            this.uc_ThapHaNoi2.Name = "uc_ThapHaNoi2";
            this.uc_ThapHaNoi2.Size = new System.Drawing.Size(120, 226);
            this.uc_ThapHaNoi2.TabIndex = 2;
            // 
            // uc_ThapHaNoi1
            // 
            this.uc_ThapHaNoi1.AutoScroll = true;
            this.uc_ThapHaNoi1.AutoSize = true;
            this.uc_ThapHaNoi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uc_ThapHaNoi1.Location = new System.Drawing.Point(195, 22);
            this.uc_ThapHaNoi1.Name = "uc_ThapHaNoi1";
            this.uc_ThapHaNoi1.Size = new System.Drawing.Size(120, 226);
            this.uc_ThapHaNoi1.TabIndex = 1;
            // 
            // uc_ThapHaNoi0
            // 
            this.uc_ThapHaNoi0.AutoScroll = true;
            this.uc_ThapHaNoi0.AutoSize = true;
            this.uc_ThapHaNoi0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uc_ThapHaNoi0.Location = new System.Drawing.Point(25, 22);
            this.uc_ThapHaNoi0.Name = "uc_ThapHaNoi0";
            this.uc_ThapHaNoi0.Size = new System.Drawing.Size(120, 226);
            this.uc_ThapHaNoi0.TabIndex = 0;
            // 
            // frmThapHaNoiDonGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.nudDoCao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDiChuyen);
            this.Controls.Add(this.uc_ThapHaNoi2);
            this.Controls.Add(this.uc_ThapHaNoi1);
            this.Controls.Add(this.uc_ThapHaNoi0);
            this.Name = "frmThapHaNoiDonGian";
            this.Text = "Tháp Hà Nội đơn giản";
            this.Activated += new System.EventHandler(this.frmThapHaNoiDonGian_Activated);
            this.Load += new System.EventHandler(this.frmThapHaNoiDonGian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC_ThapHaNoi uc_ThapHaNoi0;
        private UC_ThapHaNoi uc_ThapHaNoi1;
        private UC_ThapHaNoi uc_ThapHaNoi2;
        private System.Windows.Forms.ListBox lbDiChuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudDoCao;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnDong;
    }
}