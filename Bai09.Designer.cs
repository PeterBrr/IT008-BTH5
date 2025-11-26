namespace BTH5
{
    partial class Bai09
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
            this.cboShape = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboShape
            // 
            this.cboShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShape.FormattingEnabled = true;
            this.cboShape.Location = new System.Drawing.Point(70, 54);
            this.cboShape.Name = "cboShape";
            this.cboShape.Size = new System.Drawing.Size(121, 24);
            this.cboShape.TabIndex = 0;
            this.cboShape.SelectedIndexChanged += new System.EventHandler(this.cboShape_SelectedIndexChanged);
            // 
            // Bai09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboShape);
            this.Name = "Bai09";
            this.Text = "ComboBox Test";
            this.Load += new System.EventHandler(this.Bai09_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Bai09_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboShape;
    }
}