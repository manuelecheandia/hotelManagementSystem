namespace hotelaubergehotel.WinFrontEnd
{
    partial class MDIParent
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
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            hotelToolStripMenuItem = new ToolStripMenuItem();
            findAvailableRoomToolStripMenuItem = new ToolStripMenuItem();
            viewReservationToolStripMenuItem = new ToolStripMenuItem();
            createGuestToolStripMenuItem = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { hotelToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(1236, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // hotelToolStripMenuItem
            // 
            hotelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findAvailableRoomToolStripMenuItem, viewReservationToolStripMenuItem, createGuestToolStripMenuItem });
            hotelToolStripMenuItem.Name = "hotelToolStripMenuItem";
            hotelToolStripMenuItem.Size = new Size(48, 20);
            hotelToolStripMenuItem.Text = "Hotel";
            // 
            // findAvailableRoomToolStripMenuItem
            // 
            findAvailableRoomToolStripMenuItem.Name = "findAvailableRoomToolStripMenuItem";
            findAvailableRoomToolStripMenuItem.Size = new Size(183, 22);
            findAvailableRoomToolStripMenuItem.Tag = "FindAvailableRoom";
            findAvailableRoomToolStripMenuItem.Text = "Find Available Room";
            findAvailableRoomToolStripMenuItem.Click += ShowNewForm;
            // 
            // viewReservationToolStripMenuItem
            // 
            viewReservationToolStripMenuItem.Name = "viewReservationToolStripMenuItem";
            viewReservationToolStripMenuItem.Size = new Size(183, 22);
            viewReservationToolStripMenuItem.Tag = "ViewReservation";
            viewReservationToolStripMenuItem.Text = "View Reservation";
            viewReservationToolStripMenuItem.Click += ShowNewForm;
            // 
            // createGuestToolStripMenuItem
            // 
            createGuestToolStripMenuItem.Name = "createGuestToolStripMenuItem";
            createGuestToolStripMenuItem.Size = new Size(183, 22);
            createGuestToolStripMenuItem.Tag = "CreateGuest";
            createGuestToolStripMenuItem.Text = "Create Guest";
            createGuestToolStripMenuItem.Click += ShowNewForm;
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripSeparator2 });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(1236, 25);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 725);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 17, 0);
            statusStrip.Size = new Size(1236, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // MDIParent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 747);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4);
            Name = "MDIParent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MDIParent1";
            Load += MDIParent_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem hotelToolStripMenuItem;
        private ToolStripMenuItem findAvailableRoomToolStripMenuItem;
        private ToolStripMenuItem viewReservationToolStripMenuItem;
        private ToolStripMenuItem createGuestToolStripMenuItem;
    }
}



