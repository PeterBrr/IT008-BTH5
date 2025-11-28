using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH5
{
    public partial class Bai09 : Form
    {
        public Bai09()
        {
            InitializeComponent();
        }

        private void Bai09_Load(object sender, EventArgs e)
        {
            string[] shapes = {
                "Circle", "Square", "Ellipse", "Pie",
                "Filled Circle", "Filled Square", "Filled Ellipse", "Filled Pie"
            };
            cboShape.Items.AddRange(shapes);
            cboShape.SelectedIndex = 0;
        }

        private void cboShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Bai09_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Khử răng cưa cho đẹp

            // Chuẩn bị bút vẽ (cho hình rỗng) và cọ tô (cho hình đặc)
            Pen myPen = new Pen(Color.Blue, 3);          // Viền xanh, dày 3px
            Brush myBrush = new SolidBrush(Color.DarkRed); // Ruột màu đỏ đậm (giống hình mẫu)

            // Xác định vùng vẽ (Hình chữ nhật bao quanh hình)
            // Canh giữa form, cách lề trên 80px (để tránh đè lên ComboBox)
            int x = 50;
            int y = 80;
            int width = this.ClientSize.Width - 100; // Chiều ngang hình
            int height = 150;                        // Chiều cao hình (dùng cho Ellipse)
            int size = 150;                          // Kích thước vuông (dùng cho Circle/Square)

            float[] dataValues = { 30, 20, 10, 40 };
            Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Orange };

            float startAngle = 0.0f;

            float total = 0;
            foreach (float val in dataValues) total += val;

            string selectedShape = cboShape.SelectedItem.ToString();

            // Xử lý vẽ dựa trên tên được chọn
            switch (selectedShape)
            {
                case "Circle":   
                    g.DrawEllipse(myPen, x, y, size, size);
                    break;

                case "Square":
                    g.DrawRectangle(myPen, x, y, size, size);
                    break;

                case "Ellipse":
                    g.DrawEllipse(myPen, x, y, width, height);
                    break;

                case "Pie":
                    for (int i = 0; i < dataValues.Length; i++)
                    {
                        float sweepAngle = (dataValues[i] / total) * 360;

                        using (Pen pen = new Pen(colors[i], 3))
                        {
                            g.DrawPie(pen, x, y, size, size, startAngle, sweepAngle);
                        }

                        startAngle += sweepAngle;
                    }             
                    break;

                case "Filled Circle":
                    g.FillEllipse(myBrush, x, y, size, size);
                    break;

                case "Filled Square":
                    g.FillRectangle(myBrush, x, y, size, size);
                    break;

                case "Filled Ellipse":
                    g.FillEllipse(myBrush, x, y, width, height);
                    break;

                case "Filled Pie":
                    for (int i = 0; i < dataValues.Length; i++)
                    {
                        float sweepAngle = (dataValues[i] / total) * 360;
                    
                        using (Brush brush = new SolidBrush(colors[i]))
                        {
                            g.FillPie(brush, x, y, size, size, startAngle, sweepAngle);
                        }

                        startAngle += sweepAngle;
                    }
                    break;
            }
        }
    }
}
