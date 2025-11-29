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
    public partial class Bai11 : Form
    {
        // 1. Khai báo biến toàn cục
        private Bitmap _bitmapBuffer; // Lưu các hình đã vẽ
        private Point _startPoint;    // Điểm bắt đầu click chuột
        private Point _endPoint;      // Điểm hiện tại khi di chuột
        private bool _isDrawing = false; // Trạng thái đang giữ chuột
        private Color _penColor = Color.Black; // Màu mặc định cho Pen

        // Tạo ảnh texture mẫu (dùng cho TextureBrush)
        private Image _textureImage;
        public Bai11()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
        }

        private void Bai11_Load(object sender, EventArgs e)
        {
            // Khởi tạo Bitmap nền trắng bằng kích thước PictureBox
            _bitmapBuffer = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(_bitmapBuffer))
            {
                g.Clear(Color.White);
            }

            _textureImage = Properties.Resources.oii; 
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                _penColor = cd.Color;
                btnColor.BackColor = cd.Color; // Đổi màu nút để dễ nhìn
            }
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDrawing = true;
                _startPoint = e.Location;
            }
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                _endPoint = e.Location;
                picCanvas.Invalidate(); // Yêu cầu vẽ lại (gọi sự kiện Paint)
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                _isDrawing = false;
                _endPoint = e.Location;

                // Vẽ hình chính thức lên Bitmap Buffer
                using (Graphics g = Graphics.FromImage(_bitmapBuffer))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    DrawShape(g); // Gọi hàm vẽ chung
                }
                picCanvas.Invalidate();
            }
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (_bitmapBuffer == null) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Vẽ nền (những gì đã vẽ trước đó)
            e.Graphics.DrawImage(_bitmapBuffer, 0, 0);

            // Nếu đang kéo chuột, vẽ hình tạm thời đè lên trên
            if (_isDrawing)
            {
                DrawShape(e.Graphics);
            }
        }

        private void DrawShape(Graphics g)
        {
            // Lấy độ dày nét vẽ từ TextBox
            int penWidth = 1;
            int.TryParse(txtWidth.Text, out penWidth);

            // Tính hình chữ nhật bao quanh (dùng cho Rect và Ellipse)
            // Phải dùng Math.Min/Abs để vẽ được kể cả khi kéo chuột ngược từ dưới lên
            int x = Math.Min(_startPoint.X, _endPoint.X);
            int y = Math.Min(_startPoint.Y, _endPoint.Y);
            int w = Math.Abs(_endPoint.X - _startPoint.X);
            int h = Math.Abs(_endPoint.Y - _startPoint.Y);
            Rectangle rect = new Rectangle(x, y, w, h);

            // VẼ ĐƯỜNG THẲNG (LINE)
            if (radLine.Checked)
            {
                using (Pen p = new Pen(_penColor, penWidth))
                {
                    g.DrawLine(p, _startPoint, _endPoint);
                }
            }
            // VẼ HÌNH CHỮ NHẬT HOẶC ELLIPSE (CÓ TÔ MÀU)
            else
            {
                Brush brush = null;

                // Chọn loại Brush theo yêu cầu đề bài
                if (radSolid.Checked)
                {
                    // SolidBrush: Màu Green
                    brush = new SolidBrush(Color.Blue);
                }
                else if (radHatch.Checked)
                {
                    // HatchBrush: Horizontal, Blue & Green
                    brush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
                }
                else if (radTexture.Checked)
                {
                    // TextureBrush: Tô bằng ảnh bitmap
                    brush = new TextureBrush(_textureImage);
                }
                else if (radGradient.Checked)
                {
                    // LinearGradientBrush: Vertical, Red & Green                   
                    if (w > 0 && h > 0) // Tránh lỗi kích thước 0
                    {
                        brush = new LinearGradientBrush(rect, Color.Red, Color.Green, LinearGradientMode.Vertical);
                    }
                    else
                    {
                        brush = new SolidBrush(Color.Red); // Fallback nếu kích thước quá nhỏ
                    }
                }

                // Thực hiện vẽ tô màu (Fill)
                if (brush != null)
                {
                    if (radRect.Checked)
                    {
                        g.FillRectangle(brush, rect);
                    }
                    else if (radEllipse.Checked)
                    {
                        g.FillEllipse(brush, rect);
                    }
                    brush.Dispose(); // Giải phóng tài nguyên Brush
                }
            }
        }

        private void picCanvas_Resize(object sender, EventArgs e)
        {
            // Kiểm tra kích thước hợp lệ (để tránh lỗi khi thu nhỏ xuống Taskbar = 0)
            if (picCanvas.Width <= 0 || picCanvas.Height <= 0) return;

            // Nếu chưa có bitmap cũ (lần đầu chạy) thì không cần copy
            if (_bitmapBuffer == null)
            {
                _bitmapBuffer = new Bitmap(picCanvas.Width, picCanvas.Height);
                using (Graphics g = Graphics.FromImage(_bitmapBuffer)) g.Clear(Color.White);
                return;
            }

            // Nếu kích thước mới nhỏ hơn kích thước Bitmap hiện tại -> KHÔNG LÀM GÌ CẢ
            // (Giữ nguyên Bitmap to để bảo toàn hình vẽ)
            if (picCanvas.Width <= _bitmapBuffer.Width && picCanvas.Height <= _bitmapBuffer.Height)
            {
                picCanvas.Invalidate(); // Chỉ cần vẽ lại
                return;
            }

            // Tính kích thước mới: Phải là LỚN NHẤT giữa kích thước form và kích thước ảnh cũ
            // Để đảm bảo không chiều nào bị cắt bớt
            int newWidth = Math.Max(picCanvas.Width, _bitmapBuffer.Width);
            int newHeight = Math.Max(picCanvas.Height, _bitmapBuffer.Height);

            // Tạo Bitmap với kích thước bảo toàn dữ liệu
            Bitmap newBitmap = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                g.Clear(Color.White); // Xóa nền trắng

                // B. Vẽ lại (Copy) hình ảnh từ Bitmap cũ sang Bitmap mới
                // Để giữ lại những gì người dùng đã vẽ trước đó
                g.DrawImage(_bitmapBuffer, 0, 0);
            }

            // C. Giải phóng Bitmap cũ để đỡ tốn RAM
            _bitmapBuffer.Dispose();

            // D. Gán Bitmap mới vào biến toàn cục
            _bitmapBuffer = newBitmap;

            // E. Vẽ lại màn hình
            picCanvas.Invalidate();
        }
    }
}
