using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeAnThapHaNoi
{
    public partial class frmDeAnThapHaNoi : Form
    {
        public frmDeAnThapHaNoi()
        {
            InitializeComponent();
        }

        #region Khai Bao Bien 

        public const int Entered_DonGian = 10;
        public const int Calculated_DonGian = 20;
        public const int Entered_NangCao = 10;
        public const int Calculated_NangCao = 40;
        public const int Entered_About = 10;
        public const int Closed_About = 10;
        public static int Visit_Point = 0;

        #endregion
        #region  Các phương thức

        public void TienDo_Refresh()
        {
            TienDo.Value = Visit_Point;
        }

        public Form FormExist(string formName)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.Name == formName)
                    return frm;
            }
            return null;
        }

        #endregion

        private void mnuThapHaNoiDonGian_Click(object sender, EventArgs e)
        {
            frmThapHaNoiDonGian frm = (frmThapHaNoiDonGian)FormExist("frmThapHaNoiDonGian");
            if (frm == null)
            {
                frm = new frmThapHaNoiDonGian();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Activate();

        }

        private void mnuThapHaNoiNangCao_Click(object sender, EventArgs e)
        {
            frmThapHaNoiNangCao frm = (frmThapHaNoiNangCao)FormExist("frmThapHaNoiNangCao");
            if (frm == null)
            {
                frm = new frmThapHaNoiNangCao();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Activate();
            frm.BringToFront();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = (frmAbout)FormExist("frmAbout");
            if (frm == null)
            {
                frm = new frmAbout();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Activate();
        }

        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            if (Visit_Point >= 100)
            {
                MessageBox.Show("Bạn đã hoàn tất toàn bộ yêu cầu của đề án Tháp Hà Nội\n"
                + "- Tháp Hà Nội đơn giản\n"
                + "- Thap Hà Nội nâng cao\n"
                + "Ngoài ra, bạn đã biết cách phát triển chương trình theo dạng xoắn ốc,\n"
                + "cách lập trình hướng đối tượng.\n"
                + "Đặc biệt, bạn đã thuần thục cách sử dụng danh sách.",
                this.Text);
            }
            Application.Exit();
        }
    }
}
