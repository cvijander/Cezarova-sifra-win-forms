namespace Cezarova_sifra
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaberiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakljucajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otkljucajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fajlToolStripMenuItem
            // 
            this.fajlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaberiToolStripMenuItem,
            this.zakljucajToolStripMenuItem,
            this.otkljucajToolStripMenuItem});
            this.fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            this.fajlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fajlToolStripMenuItem.Text = "Fajl";
            // 
            // odaberiToolStripMenuItem
            // 
            this.odaberiToolStripMenuItem.Name = "odaberiToolStripMenuItem";
            this.odaberiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.odaberiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.odaberiToolStripMenuItem.Text = "Odaberi";
            this.odaberiToolStripMenuItem.Click += new System.EventHandler(this.odaberiToolStripMenuItem_Click);
            // 
            // zakljucajToolStripMenuItem
            // 
            this.zakljucajToolStripMenuItem.Name = "zakljucajToolStripMenuItem";
            this.zakljucajToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.zakljucajToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zakljucajToolStripMenuItem.Text = "Zakljucaj";
            this.zakljucajToolStripMenuItem.Click += new System.EventHandler(this.zakljucajToolStripMenuItem_Click);
            // 
            // otkljucajToolStripMenuItem
            // 
            this.otkljucajToolStripMenuItem.Name = "otkljucajToolStripMenuItem";
            this.otkljucajToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.otkljucajToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otkljucajToolStripMenuItem.Text = "Otkljucaj";
            this.otkljucajToolStripMenuItem.Click += new System.EventHandler(this.otkljucajToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cezar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fajlToolStripMenuItem;
        private ToolStripMenuItem odaberiToolStripMenuItem;
        private ToolStripMenuItem zakljucajToolStripMenuItem;
        private ToolStripMenuItem otkljucajToolStripMenuItem;
        private Label label1;
    }
}