
namespace day16_baloons
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.baloonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eJPRomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nācAtpakaļToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Survivors = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Hits = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baloonsToolStripMenuItem,
            this.eJPRomToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1072, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // baloonsToolStripMenuItem
            // 
            this.baloonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem});
            this.baloonsToolStripMenuItem.Name = "baloonsToolStripMenuItem";
            this.baloonsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.baloonsToolStripMenuItem.Text = "Baloons!";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // eJPRomToolStripMenuItem
            // 
            this.eJPRomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nācAtpakaļToolStripMenuItem});
            this.eJPRomToolStripMenuItem.Name = "eJPRomToolStripMenuItem";
            this.eJPRomToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.eJPRomToolStripMenuItem.Text = "EJ PRom !";
            this.eJPRomToolStripMenuItem.Click += new System.EventHandler(this.eJPRomToolStripMenuItem_Click);
            // 
            // nācAtpakaļToolStripMenuItem
            // 
            this.nācAtpakaļToolStripMenuItem.Name = "nācAtpakaļToolStripMenuItem";
            this.nācAtpakaļToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.nācAtpakaļToolStripMenuItem.Text = "Nāc Atpakaļ !";
            this.nācAtpakaļToolStripMenuItem.Click += new System.EventHandler(this.nācAtpakaļToolStripMenuItem_Click);
            // 
            // Survivors
            // 
            this.Survivors.AutoSize = true;
            this.Survivors.Location = new System.Drawing.Point(346, 10);
            this.Survivors.Name = "Survivors";
            this.Survivors.Size = new System.Drawing.Size(75, 17);
            this.Survivors.TabIndex = 1;
            this.Survivors.Text = "Survivors :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Hits
            // 
            this.Hits.AutoSize = true;
            this.Hits.Location = new System.Drawing.Point(447, 9);
            this.Hits.Name = "Hits";
            this.Hits.Size = new System.Drawing.Size(40, 17);
            this.Hits.TabIndex = 2;
            this.Hits.Text = "Hits :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 574);
            this.Controls.Add(this.Hits);
            this.Controls.Add(this.Survivors);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baloons !";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baloonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eJPRomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nācAtpakaļToolStripMenuItem;
        private System.Windows.Forms.Label Survivors;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Hits;
    }
}

