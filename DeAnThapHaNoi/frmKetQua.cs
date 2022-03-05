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
    public partial class frmKetQua : Form
    {
        public frmKetQua()
        {
            InitializeComponent();
            SeqNo = 0;
        }
        #region Khai Báo Biến 
        private static int SeqNo;
        public frmThapHaNoiNangCao frmRef;
        #endregion
        #region Các Phương Thức 
        public void Add(string s)
        {
            SeqNo++;
            lbKetQua.Items.Add(SeqNo.ToString() + ". " + s);
            nudSoBuocThucHien.Value = SeqNo;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            frmRef.ResetParam();
        }
            #endregion
        }
    }
