namespace StoreInventory
{
    partial class UserDashboard
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
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelAppLName = new System.Windows.Forms.Label();
            this.labelAppFName = new System.Windows.Forms.Label();
            this.labelLoggedInUser = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelFooter = new System.Windows.Forms.Label();
            this.menuStripTop.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(890, 24);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelAppLName
            // 
            this.labelAppLName.AutoSize = true;
            this.labelAppLName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppLName.Location = new System.Drawing.Point(641, 296);
            this.labelAppLName.Name = "labelAppLName";
            this.labelAppLName.Size = new System.Drawing.Size(169, 37);
            this.labelAppLName.TabIndex = 10;
            this.labelAppLName.Text = "INVENTORY";
            // 
            // labelAppFName
            // 
            this.labelAppFName.AutoSize = true;
            this.labelAppFName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppFName.Location = new System.Drawing.Point(558, 296);
            this.labelAppFName.Name = "labelAppFName";
            this.labelAppFName.Size = new System.Drawing.Size(94, 37);
            this.labelAppFName.TabIndex = 9;
            this.labelAppFName.Text = "STORE";
            // 
            // labelLoggedInUser
            // 
            this.labelLoggedInUser.AutoSize = true;
            this.labelLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggedInUser.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelLoggedInUser.Location = new System.Drawing.Point(60, 38);
            this.labelLoggedInUser.Name = "labelLoggedInUser";
            this.labelLoggedInUser.Size = new System.Drawing.Size(0, 17);
            this.labelLoggedInUser.TabIndex = 8;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(12, 38);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(42, 17);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "User: ";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.Teal;
            this.panelFooter.Controls.Add(this.labelFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 429);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(890, 21);
            this.panelFooter.TabIndex = 6;
            // 
            // labelFooter
            // 
            this.labelFooter.AutoSize = true;
            this.labelFooter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFooter.ForeColor = System.Drawing.Color.White;
            this.labelFooter.Location = new System.Drawing.Point(607, 4);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(169, 13);
            this.labelFooter.TabIndex = 0;
            this.labelFooter.Text = "Developed By: Gurpreet Kamboj";
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.labelAppLName);
            this.Controls.Add(this.labelAppFName);
            this.Controls.Add(this.labelLoggedInUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.menuStripTop);
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserDashboard_FormClosed);
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelAppLName;
        private System.Windows.Forms.Label labelAppFName;
        private System.Windows.Forms.Label labelLoggedInUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelFooter;
    }
}