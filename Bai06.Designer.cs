namespace BTH5
{
    partial class Bai06
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstFonts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstFonts
            // 
            this.lstFonts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFonts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstFonts.FormattingEnabled = true;
            this.lstFonts.Location = new System.Drawing.Point(0, 0);
            this.lstFonts.Margin = new System.Windows.Forms.Padding(20);
            this.lstFonts.Name = "lstFonts";
            this.lstFonts.Size = new System.Drawing.Size(431, 450);
            this.lstFonts.TabIndex = 0;
            this.lstFonts.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstFonts_DrawItem);
            // 
            // Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.lstFonts);
            this.Name = "Bai06";
            this.Text = "All Fonts";
            this.Load += new System.EventHandler(this.Bai06_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFonts;
    }
}