namespace tx_customized_ribbon
{
    partial class Form1
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
            this.textControl1 = new TXTextControl.TextControl();
            this.ribbon1 = new TXTextControl.Windows.Forms.Ribbon.Ribbon();
            this.ribbonFormattingTab1 = new TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab();
            this.ribbonInsertTab1 = new TXTextControl.Windows.Forms.Ribbon.RibbonInsertTab();
            this.ribbonReportingTab1 = new TXTextControl.Windows.Forms.Ribbon.RibbonReportingTab();
            this.rulerBar2 = new TXTextControl.RulerBar();
            this.statusBar1 = new TXTextControl.StatusBar();
            this.rulerBar1 = new TXTextControl.RulerBar();
            this.ribbon1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textControl1
            // 
            this.textControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.textControl1.Location = new System.Drawing.Point(25, 143);
            this.textControl1.Name = "textControl1";
            this.textControl1.Ribbon = this.ribbon1;
            this.textControl1.RulerBar = this.rulerBar2;
            this.textControl1.Size = new System.Drawing.Size(1037, 265);
            this.textControl1.StatusBar = this.statusBar1;
            this.textControl1.TabIndex = 0;
            this.textControl1.UserNames = null;
            this.textControl1.VerticalRulerBar = this.rulerBar1;
            // 
            // ribbon1
            // 
            this.ribbon1.Controls.Add(this.ribbonFormattingTab1);
            this.ribbon1.Controls.Add(this.ribbonInsertTab1);
            this.ribbon1.Controls.Add(this.ribbonReportingTab1);
            this.ribbon1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.HotTrack = true;
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Name = "ribbon1";
            this.ribbon1.SelectedIndex = 3;
            this.ribbon1.Size = new System.Drawing.Size(1062, 118);
            this.ribbon1.TabIndex = 1;
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonFormattingTab1
            // 
            this.ribbonFormattingTab1.Location = new System.Drawing.Point(4, 25);
            this.ribbonFormattingTab1.Name = "ribbonFormattingTab1";
            this.ribbonFormattingTab1.Size = new System.Drawing.Size(1054, 89);
            this.ribbonFormattingTab1.TabIndex = 1;
            // 
            // ribbonInsertTab1
            // 
            this.ribbonInsertTab1.Location = new System.Drawing.Point(4, 25);
            this.ribbonInsertTab1.Name = "ribbonInsertTab1";
            this.ribbonInsertTab1.Size = new System.Drawing.Size(1054, 89);
            this.ribbonInsertTab1.TabIndex = 2;
            // 
            // ribbonReportingTab1
            // 
            this.ribbonReportingTab1.Location = new System.Drawing.Point(4, 24);
            this.ribbonReportingTab1.Name = "ribbonReportingTab1";
            this.ribbonReportingTab1.Size = new System.Drawing.Size(1054, 90);
            this.ribbonReportingTab1.TabIndex = 3;
            // 
            // rulerBar2
            // 
            this.rulerBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rulerBar2.Location = new System.Drawing.Point(0, 118);
            this.rulerBar2.Name = "rulerBar2";
            this.rulerBar2.Size = new System.Drawing.Size(1062, 25);
            this.rulerBar2.TabIndex = 4;
            this.rulerBar2.Text = "rulerBar2";
            // 
            // statusBar1
            // 
            this.statusBar1.BackColor = System.Drawing.SystemColors.Control;
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar1.Location = new System.Drawing.Point(0, 408);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(1062, 22);
            this.statusBar1.TabIndex = 2;
            // 
            // rulerBar1
            // 
            this.rulerBar1.Alignment = TXTextControl.RulerBarAlignment.Left;
            this.rulerBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.rulerBar1.Location = new System.Drawing.Point(0, 143);
            this.rulerBar1.Name = "rulerBar1";
            this.rulerBar1.Size = new System.Drawing.Size(25, 265);
            this.rulerBar1.TabIndex = 3;
            this.rulerBar1.Text = "rulerBar1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 430);
            this.Controls.Add(this.textControl1);
            this.Controls.Add(this.rulerBar1);
            this.Controls.Add(this.rulerBar2);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.ribbon1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ribbon1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TXTextControl.TextControl textControl1;
        private TXTextControl.Windows.Forms.Ribbon.Ribbon ribbon1;
        private TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab ribbonFormattingTab1;
        private TXTextControl.Windows.Forms.Ribbon.RibbonInsertTab ribbonInsertTab1;
        private TXTextControl.RulerBar rulerBar2;
        private TXTextControl.StatusBar statusBar1;
        private TXTextControl.RulerBar rulerBar1;
        private TXTextControl.Windows.Forms.Ribbon.RibbonReportingTab ribbonReportingTab1;
    }
}

