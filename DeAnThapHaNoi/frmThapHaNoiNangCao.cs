using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace DeAnThapHaNoi
{
    public partial class frmThapHaNoiNangCao : Form
    {
        public frmThapHaNoiNangCao()
        {
            InitializeComponent();
        }
        #region Khai Báo Biến 
        private static int Visit_Enter = 0;
        private static int Calc1_Done = 0, Calc2_Done = 0, Calc3_Done = 0, Calc4_Done = 0;

        private static int DoCao = 5;
        private frmBaThapHaNoi frmXP = new frmBaThapHaNoi(DoCao, 0);
        private frmBaThapHaNoi frmDD = new frmBaThapHaNoi(DoCao, 2);
        private frmBaThapHaNoi frmTH = new frmBaThapHaNoi(DoCao, 1);
        private frmKetQua frm;
        private bool XuatPhat_Ready = false;
        private bool DichDen_Ready = false;
        private bool ThucHien_Ready = false;
        public static bool DangThoatRa = false;

        private List<String> dsTrangThai = new List<string>();

        #endregion
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (!ThucHien_Ready)
            {
                ThucHien_Ready = true;
                DangThoatRa = false;
                frm = new frmKetQua();
                frm.MdiParent = this.ParentForm;
                frm.nudSoBuocThucHien.Maximum = (1 << DoCao) - 1 ;
                frm.frmRef = this;
                nudDoCao.Enabled = false;
                dsTrangThai = new List<string>() { frmXP.TrangThai };
                BaiToanThapHaNoi btthn = new BaiToanThapHaNoi("", frmXP.TrangThai, frmDD.TrangThai, frm, dsTrangThai);
                frmTH.TrangThai = frmXP.TrangThai;
                frmXP.nudEnabled = false;
                frmDD.nudEnabled = false;
                frmTH.nudEnabled = false;
                frmTH.Focus();
                btthn.GiaiBaiToan();
                // MessageBox.Show(BaiToanThapHaNoi.KetQua, this.Text);
                frm.Show();
                //them 141 
                if (Calc4_Done == 0)
                {
                    Calc4_Done = frmDeAnThapHaNoi.Calculated_NangCao / 4;
                    frmDeAnThapHaNoi.Visit_Point += Calc4_Done;
                    ((frmDeAnThapHaNoi)this.MdiParent).TienDo_Refresh();
                }
                foreach (String tt in dsTrangThai)
                {
                    frmTH.TrangThai = tt;
                    if (frmTH.nudEnabled)
                        break;
                    Application.DoEvents();
                    Thread.Sleep(100);
                }
            }
            else
                frmTH.Focus();

        }

        private void btnDichDen_Click(object sender, EventArgs e)
        {
            DichDen_Ready = true;
            btnThucHien.Enabled = XuatPhat_Ready && DichDen_Ready;
            frmDD.Focus();
            //
            if (Calc3_Done == 0)
            {
                Calc3_Done = frmDeAnThapHaNoi.Calculated_NangCao / 4;
                frmDeAnThapHaNoi.Visit_Point += Calc3_Done;
                ((frmDeAnThapHaNoi)this.MdiParent).TienDo_Refresh();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudDoCao_ValueChanged(object sender, EventArgs e)
        {
            DoCao = (int)nudDoCao.Value;
            nudSoBuocToiDa.Value = (1 << DoCao) - 1;
            frmXP.DoCao = frmTH.DoCao = frmDD.DoCao = DoCao;
            //them vao 138
            if (Calc1_Done == 0)
            {
                Calc1_Done = frmDeAnThapHaNoi.Calculated_NangCao / 4;
                frmDeAnThapHaNoi.Visit_Point += Calc1_Done;
                ((frmDeAnThapHaNoi)this.MdiParent).TienDo_Refresh();
            }
        }

        private void frmThapHaNoiNangCao_Activated(object sender, EventArgs e)
        {
            if (Visit_Enter == 0)
            {
                Visit_Enter = frmDeAnThapHaNoi.Entered_DonGian;
                frmDeAnThapHaNoi.Visit_Point += Visit_Enter;
                ((frmDeAnThapHaNoi)this.MdiParent).TienDo_Refresh();
            }
            frmXP.Title = "Xuất phát";
            frmXP.MdiParent = this.ParentForm;
            frmDD.Title = "Đích đến";
            frmDD.MdiParent = this.ParentForm;
            frmDD.TrangThai = MyLib.Replicate('2', DoCao);
            frmTH.Title = "Thực hiện";
            frmTH.MdiParent = this.ParentForm;
        }
        private void btnXuatPhat_Click(object sender, EventArgs e)
        {
            XuatPhat_Ready = true;
            btnThucHien.Enabled = XuatPhat_Ready && DichDen_Ready;
            frmXP.Focus();
            if (Calc2_Done == 0)
            {
                Calc2_Done = frmDeAnThapHaNoi.Calculated_NangCao / 4;
                frmDeAnThapHaNoi.Visit_Point += Calc2_Done;
                ((frmDeAnThapHaNoi)this.MdiParent).TienDo_Refresh();
            }
        }
        #region Các Phương thức 
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DangThoatRa = true;
            if (frm != null) frm.Close();
            frmTH.Close();
            frmXP.Close();
            frmDD.Close();
        }
        public void ResetParam()
        {
            frmXP.nudEnabled = true;
            frmDD.nudEnabled = true;
            frmTH.nudEnabled = true;
            ThucHien_Ready = false;
            nudDoCao.Enabled = true;
            frmTH.Hide();
        }
        #endregion
    }
}
