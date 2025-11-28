using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH5
{
    public partial class Bai08 : Form
    {
        private Timer timer;
        public Bai08()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += (s, e) =>
            {
                this.Invalidate(); // Trigger a repaint
            };
            timer.Start();
        }

        private void Bai08_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Lấy kích thước trung tâm
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;
            int cx = w / 2;
            int cy = h / 2;
            int radius = Math.Min(cx, cy) - 40; // Bán kính mặt đồng hồ

            // --- BƯỚC 1: DỜI GỐC TỌA ĐỘ VỀ GIỮA TÂM ---
            g.TranslateTransform(cx, cy);

            // Lưu trạng thái ban đầu của Graphics
            GraphicsState state = g.Save();

            using (Brush brush = new SolidBrush(Color.White))
            {
                for (int i = 0; i < 60; i++)
                {
                    // Nếu là giờ chẵn (chia hết cho 5) thì vẽ chấm to, ngược lại chấm nhỏ
                    int tickSize = (i % 5 == 0) ? 10 : 4;

                    // Vẽ chấm tròn ở vị trí đỉnh trên (trục Y âm)
                    // Ta vẽ tại (0, -radius)
                    g.FillEllipse(brush, -tickSize / 2, -radius - tickSize / 2, tickSize, tickSize);

                    // Xoay trục tọa độ 6 độ (360 / 60 = 6)
                    g.RotateTransform(6);
                }
            }
            // Khôi phục trạng thái (để reset góc xoay về 0)
            g.Restore(state);

            // --- BƯỚC 3: LẤY GIỜ HỆ THỐNG ---
            DateTime now = DateTime.Now;
            float hour = now.Hour;
            float minute = now.Minute;
            float second = now.Second; 

            // --- BƯỚC 4: VẼ KIM GIỜ ---
            // Góc kim giờ: (Giờ * 30) + (Phút * 0.5)
            // Ví dụ: 6h30 thì kim giờ nằm giữa số 6 và 7
            state = g.Save();
            float hourAngle = (hour % 12) * 30 + (minute * 0.5f);
            g.RotateTransform(hourAngle);

            // Vẽ kim giờ (Hình thoi ngắn và mập)
            DrawHand(g, Pens.White, 70, 15);

            g.Restore(state);

            // --- BƯỚC 5: VẼ KIM PHÚT ---
            // Góc kim phút: Phút * 6
            state = g.Save();
            float minAngle = minute * 6;
            g.RotateTransform(minAngle);

            // Vẽ kim phút (Hình thoi dài và mảnh)
            DrawHand(g, Pens.White, 90, 8);

            g.Restore(state);

            // --- 4. VẼ KIM GIÂY (MỚI) ---
            state = g.Save();
            float secAngle = second * 6; // Mỗi giây quay 6 độ (360 / 60)
            g.RotateTransform(secAngle);

            g.DrawLine(Pens.White, 0, 10, 0, -90);

            g.Restore(state);

            // Vẽ tâm đồng hồ (cho đẹp)
            g.FillEllipse(Brushes.White, -5, -5, 10, 10);
        }

        private void DrawHand(Graphics g, Pen pen, int length, int width)
        {
            // Tạo 4 điểm của hình thoi
            Point[] points = new Point[]
            {
                new Point(0, 20),        // Đuôi kim (thụt lùi xuống dưới tâm một chút)
                new Point(-width, 0),    // Cạnh trái
                new Point(0, -length),   // Đỉnh kim (hướng lên trên)
                new Point(width, 0)      // Cạnh phải
            };

            // Vẽ viền (DrawPolygon) thay vì tô đặc (FillPolygon) để giống hình mẫu
            g.DrawPolygon(pen, points);
        }
    }
}
