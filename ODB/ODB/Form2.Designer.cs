namespace ODB
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.розміриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вагаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.льотніДаніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.салонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(333, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Назад";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.розміриToolStripMenuItem,
            this.вагаToolStripMenuItem,
            this.льотніДаніToolStripMenuItem,
            this.салонToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(333, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // розміриToolStripMenuItem
            // 
            this.розміриToolStripMenuItem.Name = "розміриToolStripMenuItem";
            this.розміриToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.розміриToolStripMenuItem.Text = "Розміри";
            this.розміриToolStripMenuItem.Click += new System.EventHandler(this.розміриToolStripMenuItem_Click);
            // 
            // вагаToolStripMenuItem
            // 
            this.вагаToolStripMenuItem.Name = "вагаToolStripMenuItem";
            this.вагаToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.вагаToolStripMenuItem.Text = "Вага";
            this.вагаToolStripMenuItem.Click += new System.EventHandler(this.вагаToolStripMenuItem_Click);
            // 
            // льотніДаніToolStripMenuItem
            // 
            this.льотніДаніToolStripMenuItem.Name = "льотніДаніToolStripMenuItem";
            this.льотніДаніToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.льотніДаніToolStripMenuItem.Text = "Льотні дані";
            this.льотніДаніToolStripMenuItem.Click += new System.EventHandler(this.льотніДаніToolStripMenuItem_Click);
            // 
            // салонToolStripMenuItem
            // 
            this.салонToolStripMenuItem.Name = "салонToolStripMenuItem";
            this.салонToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.салонToolStripMenuItem.Text = "Салон";
            this.салонToolStripMenuItem.Click += new System.EventHandler(this.салонToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(32, 217);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(32, 49);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(301, 217);
            this.listBox2.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 266);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Інформація про літаки";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem розміриToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вагаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem льотніДаніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem салонToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}