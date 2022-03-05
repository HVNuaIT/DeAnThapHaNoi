using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace DeAnThapHaNoi
{
    public partial class UC_ThapHaNoi : UserControl
    {
        public UC_ThapHaNoi()
        {
            InitializeComponent();
            ds = new Stack<int>();
        }

        #region Khai Báo Biến 
        const int CellHeight = 20;
        const int UnitWidth = 10;
        private Stack<int> ds;
        private ArrayList Points = new ArrayList();
        #endregion


        #region Các Phương Thức 
        private void DrawShape(Graphics g, Rectangle shape)
        {
            Pen DrawingPen = new Pen(Color.Blue, 2);
            g.DrawRectangle(DrawingPen, shape);
        }
        public void XoaSach()
        {
            Points.Clear();
            ds.Clear();
            this.Refresh();
        }
        public void Them(int a)
        {
            ds.Push(a);
            Rectangle Point = new Rectangle((this.Width - UnitWidth * a) / 2,
            this.Height - ds.Count * CellHeight, UnitWidth * a, CellHeight);
            Points.Add(Point);
            Graphics g = this.CreateGraphics();
            DrawShape(g, Point);
            g.Dispose();
        }
        public void Bot()
        {
            if (ds.Count > 0)
            {
                int a = ds.Pop();
                Points.RemoveAt(ds.Count);
                this.Refresh();
            }
        }
        #endregion

        private void UC_ThapHaNoi_Paint(object sender, PaintEventArgs e)
        {
            Pen DrawingPen = new Pen(Color.Blue, 2);
            foreach (Rectangle Point in Points)
                e.Graphics.DrawRectangle(DrawingPen, Point);

            Application.DoEvents();
        }
    }
}
