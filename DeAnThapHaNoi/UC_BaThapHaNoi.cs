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
    public partial class UC_BaThapHaNoi : UserControl
    {
        public UC_BaThapHaNoi()
        {
            InitializeComponent();
            uc_Thap_list = new List<UC_ThapHaNoi>() { uc_ThapHaNoi0, uc_ThapHaNoi1, uc_ThapHaNoi2 };

        }
        #region Khai Báo Biến 
        const int CellHeight = 20;
        const int UnitWidth = 10;
        const int SoThapToiDa = 3;
        private List<UC_ThapHaNoi> uc_Thap_list;
        #endregion
        #region Các Phương Thức 
        public void XoaSach()
        {
            for (int i = 0; i < SoThapToiDa; i++)
            {
                uc_Thap_list[i].XoaSach();
            }
        }
        public void Them(int soThap, int a)
        {
            uc_Thap_list[soThap].Them(a);
        }
        public void Bot(int soThap)
        {
            uc_Thap_list[soThap].Bot();
        }
        #endregion

        private void UC_BaThapHaNoi_Paint(object sender, PaintEventArgs e)
        {
            for (int SoThap = 0; SoThap < SoThapToiDa; SoThap++)
                uc_Thap_list[SoThap].Refresh();
            Application.DoEvents();
        }
    }
}
