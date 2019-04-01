namespace AutoCaptive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AutoCaptive_Noty = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoCaptive_Noty
            // 
            this.AutoCaptive_Noty.BalloonTipText = "AutoCaptive is running";
            this.AutoCaptive_Noty.BalloonTipTitle = "AutoCaptive";
            this.AutoCaptive_Noty.ContextMenuStrip = this.contextMenuStrip1;
            this.AutoCaptive_Noty.Icon = ((System.Drawing.Icon)(resources.GetObject("AutoCaptive_Noty.Icon")));
            this.AutoCaptive_Noty.Text = "AutoCaptive";
            this.AutoCaptive_Noty.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureAccountsToolStripMenuItem,
            this.reLoginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reLoginToolStripMenuItem
            // 
            this.reLoginToolStripMenuItem.Name = "reLoginToolStripMenuItem";
            this.reLoginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reLoginToolStripMenuItem.Text = "Re-Login";
            this.reLoginToolStripMenuItem.Click += new System.EventHandler(this.reLoginToolStripMenuItem_Click);
            // 
            // configureAccountsToolStripMenuItem
            // 
            this.configureAccountsToolStripMenuItem.Name = "configureAccountsToolStripMenuItem";
            this.configureAccountsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configureAccountsToolStripMenuItem.Text = "Configure Accounts";
            this.configureAccountsToolStripMenuItem.Click += new System.EventHandler(this.configureAccountsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon AutoCaptive_Noty;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureAccountsToolStripMenuItem;
    }
}

