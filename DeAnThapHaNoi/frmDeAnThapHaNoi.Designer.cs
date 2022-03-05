
namespace DeAnThapHaNoi
{
    partial class frmDeAnThapHaNoi
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuThapHaNoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThapHaNoiDonGian = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThapHaNoiNangCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKetThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.sts = new System.Windows.Forms.StatusStrip();
            this.TienDo = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThapHaNoi,
            this.mnuHeThong});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mnuThapHaNoi
            // 
            this.mnuThapHaNoi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThapHaNoiDonGian,
            this.mnuThapHaNoiNangCao});
            this.mnuThapHaNoi.Name = "mnuThapHaNoi";
            this.mnuThapHaNoi.Size = new System.Drawing.Size(85, 20);
            this.mnuThapHaNoi.Text = "&Tháp Hà Nội";
            // 
            // mnuThapHaNoiDonGian
            // 
            this.mnuThapHaNoiDonGian.Name = "mnuThapHaNoiDonGian";
            this.mnuThapHaNoiDonGian.Size = new System.Drawing.Size(192, 22);
            this.mnuThapHaNoiDonGian.Text = "Tháp Hà Nội &đơn giản";
            this.mnuThapHaNoiDonGian.Click += new System.EventHandler(this.mnuThapHaNoiDonGian_Click);
            // 
            // mnuThapHaNoiNangCao
            // 
            this.mnuThapHaNoiNangCao.Name = "mnuThapHaNoiNangCao";
            this.mnuThapHaNoiNangCao.Size = new System.Drawing.Size(192, 22);
            this.mnuThapHaNoiNangCao.Text = "Tháp Hà Nội &nâng cao";
            this.mnuThapHaNoiNangCao.Click += new System.EventHandler(this.mnuThapHaNoiNangCao_Click);
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKetThuc,
            this.mnuAbout});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(69, 20);
            this.mnuHeThong.Text = "&Hệ thống";
            // 
            // mnuKetThuc
            // 
            this.mnuKetThuc.Name = "mnuKetThuc";
            this.mnuKetThuc.Size = new System.Drawing.Size(180, 22);
            this.mnuKetThuc.Text = "&Kết thúc";
            this.mnuKetThuc.Click += new System.EventHandler(this.mnuKetThuc_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(180, 22);
            this.mnuAbout.Text = "&Vài nét";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // sts
            // 
            this.sts.AutoSize = false;
            this.sts.Location = new System.Drawing.Point(0, 425);
            this.sts.Name = "sts";
            this.sts.Size = new System.Drawing.Size(800, 25);
            this.sts.TabIndex = 2;
            this.sts.Text = "statusStrip1";
            // 
            // TienDo
            // 
            this.TienDo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TienDo.Location = new System.Drawing.Point(143, 425);
            this.TienDo.Name = "TienDo";
            this.TienDo.Size = new System.Drawing.Size(100, 23);
            this.TienDo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sẵn sàng";
            // 
            // frmDeAnThapHaNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TienDo);
            this.Controls.Add(this.sts);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "frmDeAnThapHaNoi";
            this.Text = "Đề án Tháp Hà Nội";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.StatusStrip sts;
        private System.Windows.Forms.ToolStripMenuItem mnuThapHaNoi;
        private System.Windows.Forms.ToolStripMenuItem mnuThapHaNoiDonGian;
        private System.Windows.Forms.ToolStripMenuItem mnuThapHaNoiNangCao;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuKetThuc;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ProgressBar TienDo;
        private System.Windows.Forms.Label label1;
    }
}

