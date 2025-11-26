using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH5
{
    public partial class Bai06 : Form
    {        
        public Bai06()
        {
            InitializeComponent();

            lstFonts.ItemHeight = 30;
        }

        private void Bai06_Load(object sender, EventArgs e)
        {
            InstalledFontCollection installedFonts = new InstalledFontCollection();
            foreach (FontFamily font in installedFonts.Families)
            {
                lstFonts.Items.Add(font.Name);
            }
        }

        private void lstFonts_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            string fontName = lstFonts.Items[e.Index].ToString();

            Font fontToDraw;
            try
            {
                fontToDraw = new Font(fontName, 14, FontStyle.Regular);
            }
            catch
            {
                // Nếu font bị lỗi (ví dụ font ký hiệu), dùng font mặc định hệ thống
                fontToDraw = new Font("Arial", 14, FontStyle.Regular);
            }

            Brush textBrush;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                textBrush = Brushes.White;
            }
            else
            {
                textBrush = Brushes.Black;
            }

            e.Graphics.DrawString(fontName, fontToDraw, textBrush, e.Bounds.X + 5, e.Bounds.Y + 2);

            e.DrawFocusRectangle();
        }
    }
}
