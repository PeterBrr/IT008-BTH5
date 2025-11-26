namespace BTH5
{
    partial class Bai04
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
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpAlign = new System.Windows.Forms.GroupBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkUnder = new System.Windows.Forms.CheckBox();
            this.radLeft = new System.Windows.Forms.RadioButton();
            this.radCenter = new System.Windows.Forms.RadioButton();
            this.radRight = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblPreview = new System.Windows.Forms.Label();
            this.grpAlign.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboFont
            // 
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(66, 32);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(152, 24);
            this.cboFont.TabIndex = 0;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.Control_Changed);
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(316, 32);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(121, 24);
            this.cboSize.TabIndex = 1;
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.Control_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Font";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // grpAlign
            // 
            this.grpAlign.Controls.Add(this.radRight);
            this.grpAlign.Controls.Add(this.radCenter);
            this.grpAlign.Controls.Add(this.radLeft);
            this.grpAlign.Location = new System.Drawing.Point(27, 118);
            this.grpAlign.Name = "grpAlign";
            this.grpAlign.Size = new System.Drawing.Size(164, 100);
            this.grpAlign.TabIndex = 4;
            this.grpAlign.TabStop = false;
            this.grpAlign.Text = "Align Text";
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.Location = new System.Drawing.Point(15, 73);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(39, 20);
            this.chkBold.TabIndex = 5;
            this.chkBold.Text = "B";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.Control_Changed);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalic.Location = new System.Drawing.Point(69, 73);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(33, 20);
            this.chkItalic.TabIndex = 6;
            this.chkItalic.Text = "I";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.Control_Changed);
            // 
            // chkUnder
            // 
            this.chkUnder.AutoSize = true;
            this.chkUnder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnder.Location = new System.Drawing.Point(116, 73);
            this.chkUnder.Name = "chkUnder";
            this.chkUnder.Size = new System.Drawing.Size(40, 20);
            this.chkUnder.TabIndex = 7;
            this.chkUnder.Text = "U";
            this.chkUnder.UseVisualStyleBackColor = true;
            this.chkUnder.CheckedChanged += new System.EventHandler(this.Control_Changed);
            // 
            // radLeft
            // 
            this.radLeft.AutoSize = true;
            this.radLeft.Location = new System.Drawing.Point(21, 22);
            this.radLeft.Name = "radLeft";
            this.radLeft.Size = new System.Drawing.Size(49, 20);
            this.radLeft.TabIndex = 0;
            this.radLeft.TabStop = true;
            this.radLeft.Text = "Left";
            this.radLeft.UseVisualStyleBackColor = true;
            this.radLeft.CheckedChanged += new System.EventHandler(this.Control_Changed);
            // 
            // radCenter
            // 
            this.radCenter.AutoSize = true;
            this.radCenter.Location = new System.Drawing.Point(21, 49);
            this.radCenter.Name = "radCenter";
            this.radCenter.Size = new System.Drawing.Size(67, 20);
            this.radCenter.TabIndex = 1;
            this.radCenter.TabStop = true;
            this.radCenter.Text = "Center";
            this.radCenter.UseVisualStyleBackColor = true;
            this.radCenter.CheckedChanged += new System.EventHandler(this.Control_Changed);
            // 
            // radRight
            // 
            this.radRight.AutoSize = true;
            this.radRight.Location = new System.Drawing.Point(21, 76);
            this.radRight.Name = "radRight";
            this.radRight.Size = new System.Drawing.Size(59, 20);
            this.radRight.TabIndex = 2;
            this.radRight.TabStop = true;
            this.radRight.Text = "Right";
            this.radRight.UseVisualStyleBackColor = true;
            this.radRight.CheckedChanged += new System.EventHandler(this.Control_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Color";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(318, 70);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(35, 23);
            this.btnColor.TabIndex = 9;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblPreview
            // 
            this.lblPreview.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPreview.Location = new System.Drawing.Point(228, 140);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(209, 58);
            this.lblPreview.TabIndex = 10;
            this.lblPreview.Text = "Hello";
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 239);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkUnder);
            this.Controls.Add(this.chkItalic);
            this.Controls.Add(this.chkBold);
            this.Controls.Add(this.grpAlign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.cboFont);
            this.Name = "Bai04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Bai04_Load);
            this.grpAlign.ResumeLayout(false);
            this.grpAlign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpAlign;
        private System.Windows.Forms.RadioButton radRight;
        private System.Windows.Forms.RadioButton radCenter;
        private System.Windows.Forms.RadioButton radLeft;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkUnder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblPreview;
    }
}

