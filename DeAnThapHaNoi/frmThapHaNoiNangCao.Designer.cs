
namespace DeAnThapHaNoi
{
    partial class frmThapHaNoiNangCao
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudDoCao = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSoBuocToiDa = new System.Windows.Forms.NumericUpDown();
            this.btnXuatPhat = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnDichDen = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoBuocToiDa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Độ cao \r\ntháp";
            // 
            // nudDoCao
            // 
            this.nudDoCao.Location = new System.Drawing.Point(161, 33);
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
            this.nudDoCao.Size = new System.Drawing.Size(120, 20);
            this.nudDoCao.TabIndex = 1;
            this.nudDoCao.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDoCao.ValueChanged += new System.EventHandler(this.nudDoCao_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số bước tối ";
            // 
            // nudSoBuocToiDa
            // 
            this.nudSoBuocToiDa.Enabled = false;
            this.nudSoBuocToiDa.Location = new System.Drawing.Point(448, 39);
            this.nudSoBuocToiDa.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.nudSoBuocToiDa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoBuocToiDa.Name = "nudSoBuocToiDa";
            this.nudSoBuocToiDa.ReadOnly = true;
            this.nudSoBuocToiDa.Size = new System.Drawing.Size(120, 20);
            this.nudSoBuocToiDa.TabIndex = 3;
            this.nudSoBuocToiDa.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // btnXuatPhat
            // 
            this.btnXuatPhat.Location = new System.Drawing.Point(71, 101);
            this.btnXuatPhat.Name = "btnXuatPhat";
            this.btnXuatPhat.Size = new System.Drawing.Size(75, 23);
            this.btnXuatPhat.TabIndex = 4;
            this.btnXuatPhat.Text = "Xuất phát";
            this.btnXuatPhat.UseVisualStyleBackColor = true;
            this.btnXuatPhat.Click += new System.EventHandler(this.btnXuatPhat_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Enabled = false;
            this.btnThucHien.Location = new System.Drawing.Point(206, 101);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(75, 23);
            this.btnThucHien.TabIndex = 5;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnDichDen
            // 
            this.btnDichDen.Location = new System.Drawing.Point(354, 101);
            this.btnDichDen.Name = "btnDichDen";
            this.btnDichDen.Size = new System.Drawing.Size(75, 23);
            this.btnDichDen.TabIndex = 6;
            this.btnDichDen.Text = "Đích đến";
            this.btnDichDen.UseVisualStyleBackColor = true;
            this.btnDichDen.Click += new System.EventHandler(this.btnDichDen_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(493, 100);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmThapHaNoiNangCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 173);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnDichDen);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.btnXuatPhat);
            this.Controls.Add(this.nudSoBuocToiDa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudDoCao);
            this.Controls.Add(this.label1);
            this.Name = "frmThapHaNoiNangCao";
            this.Text = "frmThapHaNoiNangCao";
            this.Activated += new System.EventHandler(this.frmThapHaNoiNangCao_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.nudDoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoBuocToiDa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDoCao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSoBuocToiDa;
        private System.Windows.Forms.Button btnXuatPhat;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnDichDen;
        private System.Windows.Forms.Button btnDong;
    }
}