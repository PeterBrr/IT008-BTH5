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
    public partial class Bai10 : Form
    {
        public Bai10()
        {
            InitializeComponent();
        }

        private void Bai10_Load(object sender, EventArgs e)
        {
            // Nạp dữ liệu DashStyle (Solid, Dash, Dot...)
            cboDashStyle.DataSource = Enum.GetValues(typeof(DashStyle));
            cboDashStyle.SelectedItem = DashStyle.Dash; // Mặc định

            // Nạp dữ liệu Width (Độ dày)
            for (int i = 1; i <= 20; i++) cboWidth.Items.Add(i);
            cboWidth.SelectedItem = 10; // Mặc định dày 10

            // Nạp dữ liệu LineJoin (Nối góc: Miter, Round, Bevel)
            cboLineJoin.DataSource = Enum.GetValues(typeof(LineJoin));
            cboLineJoin.SelectedItem = LineJoin.Round;

            // Nạp dữ liệu DashCap (Đầu mút của nét đứt)
            cboDashCap.DataSource = Enum.GetValues(typeof(DashCap));
            cboDashCap.SelectedItem = DashCap.Round;

            // Nạp dữ liệu LineCap cho Start/End (Đầu mũi tên, hình tròn...)
            cboStartCap.DataSource = Enum.GetValues(typeof(LineCap));
            cboStartCap.SelectedItem = LineCap.RoundAnchor;

            cboEndCap.DataSource = Enum.GetValues(typeof(LineCap));
            cboEndCap.SelectedItem = LineCap.ArrowAnchor;
        }

        private void Control_Changed(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Invalidate();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            // Kiểm tra xem Form đã load xong dữ liệu chưa để tránh lỗi null
            if (cboDashStyle.SelectedItem == null) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Khử răng cưa

            // Lấy các giá trị từ giao diện
            float width = float.Parse(cboWidth.Text);
            DashStyle style = (DashStyle)cboDashStyle.SelectedItem;
            LineJoin join = (LineJoin)cboLineJoin.SelectedItem;
            DashCap dashCap = (DashCap)cboDashCap.SelectedItem;
            LineCap startCap = (LineCap)cboStartCap.SelectedItem;
            LineCap endCap = (LineCap)cboEndCap.SelectedItem;

            // TẠO PEN VỚI CÁC THUỘC TÍNH ĐÃ CHỌN
            using (Pen p = new Pen(Color.Red, width))
            {
                p.DashStyle = style;

                // Xử lý trường hợp đặc biệt: Custom Dash Style
                // (Nếu chọn Custom mà không định nghĩa DashPattern thì sẽ lỗi hoặc ra nét liền)
                if (style == DashStyle.Custom)
                {
                    p.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };
                }

                // Cài đặt các thuộc tính nâng cao
                p.LineJoin = join;      // Cách nối góc
                p.DashCap = dashCap;    // Cách bo đầu nét đứt
                p.StartCap = startCap;  // Hình dáng đầu đoạn dây
                p.EndCap = endCap;      // Hình dáng cuối đoạn dây

                // TẠO ĐƯỜNG GẤP KHÚC (Để demo LineJoin ở giữa)
                // Tính toán tọa độ dựa trên kích thước Panel vẽ
                int w = splitContainer1.Panel2.Width;
                int h = splitContainer1.Panel2.Height;

                Point[] points = {
                    new Point(20, 20),           // Điểm đầu (Góc trên trái)
                    new Point(w / 2, h - 50),    // Điểm giữa (Góc nhọn ở dưới)
                    new Point(w - 20, 50)        // Điểm cuối (Góc trên phải)
                };

                // Vẽ đường gấp khúc
                g.DrawLines(p, points);
            }
        }
    }
}
