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
    public partial class frmThapHaNoiDonGian : Form
    {
        public frmThapHaNoiDonGian()
        {
            InitializeComponent();
        }
        #region Khai Báo Biến 
        private static int Visit_Enter = 0;
        private static int Calc1_Done = 0, Calc2_Done = 0;

        private int SoBuoc = 0;
        private UC_ThapHaNoi[] Thap;
        private int XP = 0;
        private int ND = 2;
        private bool m_LoadXong = false;
        #endregion

        private void frmThapHaNoiDonGian_Activated(object sender, EventArgs e)
        {
            if (Visit_Enter == 0)
            {
                Visit_Enter = frmDeAnThapHaNoi.Entered_DonGian;
                frmDeAnThapHaNoi.Visit_Point += Visit_Enter;
                ((frmDeAnThapHaNoi)this.MdiParent).TienDo_Refresh();

            }
        }
        #region Các Phương Thức 
        private void NapThap(int n)
        {
            if (m_LoadXong)
            {
                Thap[XP].XoaSach();
                for (int i = n; i > 0; i--)
                    Thap[XP].Them(i);
            }
        }
        private void DiChuyenDia(int XP, int ND, int SoDia)
        {
            SoBuoc += 1;
            Thap[XP].Bot();
            Thap[ND].Them(SoDia);
            lbDiChuyen.Items.Add(SoBuoc + ". Đưa đĩa " + SoDia.ToString() + " từ tháp " + XP.ToString() + " đến tháp "
            + ND.ToString());
        }

        private void frmThapHaNoiDonGian_Load(object sender, EventArgs e)
        {
            Thap = new UC_ThapHaNoi[] { uc_ThapHaNoi0, uc_ThapHaNoi1, uc_ThapHaNoi2 };
            m_LoadXong = true;
            NapThap((int)nudDoCao.Value);
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            SoBuoc = 0;
            lbDiChuyen.Items.Clear();
            DiChuyenThap(XP, ND, (int)nudDoCao.Value);
            int TG = 3 - XP - ND;
            XP = ND;
            ND = TG;
            btnThucHien.Text = "Thực hiện " + XP.ToString() + " -> " + ND.ToString();
            if (Calc2_Done == 0)
            {
                Calc2_Done = frmDeAnThapHaNoi.Calculated_DonGian / 2;
                frmDeAnThapHaNoi.Visit_Point += Calc2_Done;
                ((frmDeAnThapHaNoi)this.MdiParent).TienDo_Refresh();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudDoCao_ValueChanged(object sender, EventArgs e)
        {
            NapThap((int)nudDoCao.Value);
            if (Calc1_Done == 0)
            {
                Calc1_Done = frmDeAnThapHaNoi.Calculated_DonGian / 2;
                frmDeAnThapHaNoi.Visit_Point += Calc1_Done;
                ((frmDeAnThapHaNoi)this.MdiParent).TienDo_Refresh();
            }
        }

        private void DiChuyenThap(int XP, int ND, int SoDia)
        {
            int TG = 3 - XP - ND;
            if (SoDia > 1)
            {
                DiChuyenThap(XP, TG, SoDia - 1);
                DiChuyenDia(XP, ND, SoDia);
                DiChuyenThap(TG, ND, SoDia - 1);
            }
            else
                DiChuyenDia(XP, ND, SoDia);
        }

        #endregion


    }
}
