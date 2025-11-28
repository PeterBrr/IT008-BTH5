namespace BTH5
{
    partial class Bai10
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cboEndCap = new System.Windows.Forms.ComboBox();
            this.cboStartCap = new System.Windows.Forms.ComboBox();
            this.cboDashCap = new System.Windows.Forms.ComboBox();
            this.cboLineJoin = new System.Windows.Forms.ComboBox();
            this.cboWidth = new System.Windows.Forms.ComboBox();
            this.cboDashStyle = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.splitContainer1.Panel1.Controls.Add(this.cboEndCap);
            this.splitContainer1.Panel1.Controls.Add(this.cboStartCap);
            this.splitContainer1.Panel1.Controls.Add(this.cboDashCap);
            this.splitContainer1.Panel1.Controls.Add(this.cboLineJoin);
            this.splitContainer1.Panel1.Controls.Add(this.cboWidth);
            this.splitContainer1.Panel1.Controls.Add(this.cboDashStyle);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(757, 314);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 12;
            // 
            // cboEndCap
            // 
            this.cboEndCap.FormattingEnabled = true;
            this.cboEndCap.Location = new System.Drawing.Point(106, 264);
            this.cboEndCap.Name = "cboEndCap";
            this.cboEndCap.Size = new System.Drawing.Size(169, 24);
            this.cboEndCap.TabIndex = 23;
            this.cboEndCap.SelectedIndexChanged += new System.EventHandler(this.Control_Changed);
            // 
            // cboStartCap
            // 
            this.cboStartCap.FormattingEnabled = true;
            this.cboStartCap.Location = new System.Drawing.Point(106, 216);
            this.cboStartCap.Name = "cboStartCap";
            this.cboStartCap.Size = new System.Drawing.Size(169, 24);
            this.cboStartCap.TabIndex = 22;
            this.cboStartCap.SelectedIndexChanged += new System.EventHandler(this.Control_Changed);
            // 
            // cboDashCap
            // 
            this.cboDashCap.FormattingEnabled = true;
            this.cboDashCap.Location = new System.Drawing.Point(106, 168);
            this.cboDashCap.Name = "cboDashCap";
            this.cboDashCap.Size = new System.Drawing.Size(169, 24);
            this.cboDashCap.TabIndex = 21;
            this.cboDashCap.SelectedIndexChanged += new System.EventHandler(this.Control_Changed);
            // 
            // cboLineJoin
            // 
            this.cboLineJoin.FormattingEnabled = true;
            this.cboLineJoin.Location = new System.Drawing.Point(106, 120);
            this.cboLineJoin.Name = "cboLineJoin";
            this.cboLineJoin.Size = new System.Drawing.Size(169, 24);
            this.cboLineJoin.TabIndex = 20;
            this.cboLineJoin.SelectedIndexChanged += new System.EventHandler(this.Control_Changed);
            // 
            // cboWidth
            // 
            this.cboWidth.FormattingEnabled = true;
            this.cboWidth.Location = new System.Drawing.Point(106, 72);
            this.cboWidth.Name = "cboWidth";
            this.cboWidth.Size = new System.Drawing.Size(169, 24);
            this.cboWidth.TabIndex = 19;
            this.cboWidth.SelectedIndexChanged += new System.EventHandler(this.Control_Changed);
            // 
            // cboDashStyle
            // 
            this.cboDashStyle.FormattingEnabled = true;
            this.cboDashStyle.Location = new System.Drawing.Point(106, 24);
            this.cboDashStyle.Name = "cboDashStyle";
            this.cboDashStyle.Size = new System.Drawing.Size(169, 24);
            this.cboDashStyle.TabIndex = 18;
            this.cboDashStyle.SelectedIndexChanged += new System.EventHandler(this.Control_Changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "End Cap :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Start Cap :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Dash Cap :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Line Join :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Width :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dash Style :";
            // 
            // Bai10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 314);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Bai10";
            this.Text = "Pen Demo";
            this.Load += new System.EventHandler(this.Bai10_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cboEndCap;
        private System.Windows.Forms.ComboBox cboStartCap;
        private System.Windows.Forms.ComboBox cboDashCap;
        private System.Windows.Forms.ComboBox cboLineJoin;
        private System.Windows.Forms.ComboBox cboWidth;
        private System.Windows.Forms.ComboBox cboDashStyle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}