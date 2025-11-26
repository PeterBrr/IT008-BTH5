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
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private void Bai04_Load(object sender, EventArgs e)
        {
            LoadFonts();
            LoadFontSizes();

            radCenter.Checked = true;
            btnColor.BackColor = Color.Black;
            lblPreview.ForeColor = btnColor.BackColor;

            UpdatePreview();
        }

        private void LoadFonts()
        {
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            foreach (FontFamily font in installedFontCollection.Families)
            {
                cboFont.Items.Add(font.Name);
            }
            cboFont.SelectedItem = "Arial";
        }

        private void LoadFontSizes()
        {
            int[] sizes = { 8, 10, 12, 14, 16, 18, 20, 24, 28, 36, 48, 72 };
            foreach (int s in sizes)
            {
                cboSize.Items.Add(s);
            }
            cboSize.SelectedItem = 28;
        }

        private void UpdatePreview()
        {
            if (cboFont.SelectedItem == null || cboSize.SelectedItem == null)
                return;

            string fontName = cboFont.SelectedItem.ToString();
            float fontSize = float.Parse(cboSize.SelectedItem.ToString());

            FontStyle fontStyle = FontStyle.Regular;
            if (chkBold.Checked)
                fontStyle |= FontStyle.Bold;
            if (chkItalic.Checked)
                fontStyle |= FontStyle.Italic;
            if (chkUnder.Checked)
                fontStyle |= FontStyle.Underline;

            lblPreview.Font = new Font(fontName, fontSize, fontStyle);

            lblPreview.ForeColor = btnColor.BackColor;

            if (radLeft.Checked)
                lblPreview.TextAlign = ContentAlignment.MiddleLeft;
            else if (radCenter.Checked)
                lblPreview.TextAlign = ContentAlignment.MiddleCenter;
            else if (radRight.Checked)
                lblPreview.TextAlign = ContentAlignment.MiddleRight;
        }

        private void Control_Changed(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog.Color;
                UpdatePreview();
            }
        }
    }
}
