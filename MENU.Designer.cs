namespace employeemanagment
{
    partial class MENU
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eMPLOYEEMANAGMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTMANAGMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eMPLOYEEMANAGMENTToolStripMenuItem,
            this.pRODUCTMANAGMENTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eMPLOYEEMANAGMENTToolStripMenuItem
            // 
            this.eMPLOYEEMANAGMENTToolStripMenuItem.Name = "eMPLOYEEMANAGMENTToolStripMenuItem";
            this.eMPLOYEEMANAGMENTToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.eMPLOYEEMANAGMENTToolStripMenuItem.Text = "EMPLOYEE MANAGMENT";
            this.eMPLOYEEMANAGMENTToolStripMenuItem.Click += new System.EventHandler(this.eMPLOYEEMANAGMENTToolStripMenuItem_Click);
            // 
            // pRODUCTMANAGMENTToolStripMenuItem
            // 
            this.pRODUCTMANAGMENTToolStripMenuItem.Name = "pRODUCTMANAGMENTToolStripMenuItem";
            this.pRODUCTMANAGMENTToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.pRODUCTMANAGMENTToolStripMenuItem.Text = " PRODUCT MANAGMENT";
            this.pRODUCTMANAGMENTToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTMANAGMENTToolStripMenuItem_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MENU";
            this.Text = "MENU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eMPLOYEEMANAGMENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTMANAGMENTToolStripMenuItem;
    }
}