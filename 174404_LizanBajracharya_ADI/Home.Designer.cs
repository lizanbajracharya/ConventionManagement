namespace _174404_LizanBajracharya_ADI
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.attendeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAttendeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAttendeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSeminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaySeminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomAndStallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEventScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stallScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 261);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(892, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO DASHBOARD";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendeeToolStripMenuItem,
            this.seminarToolStripMenuItem,
            this.roomAndStallToolStripMenuItem,
            this.eventToolStripMenuItem,
            this.stallToolStripMenuItem,
            this.addUserToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // attendeeToolStripMenuItem
            // 
            this.attendeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAttendeeToolStripMenuItem,
            this.displayAttendeeToolStripMenuItem});
            this.attendeeToolStripMenuItem.Name = "attendeeToolStripMenuItem";
            this.attendeeToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.attendeeToolStripMenuItem.Text = "Attendee";
            // 
            // addAttendeeToolStripMenuItem
            // 
            this.addAttendeeToolStripMenuItem.Name = "addAttendeeToolStripMenuItem";
            this.addAttendeeToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.addAttendeeToolStripMenuItem.Text = "Add Attendee";
            this.addAttendeeToolStripMenuItem.Click += new System.EventHandler(this.addAttendeeToolStripMenuItem_Click);
            // 
            // displayAttendeeToolStripMenuItem
            // 
            this.displayAttendeeToolStripMenuItem.Name = "displayAttendeeToolStripMenuItem";
            this.displayAttendeeToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.displayAttendeeToolStripMenuItem.Text = "Display Attendee";
            this.displayAttendeeToolStripMenuItem.Click += new System.EventHandler(this.displayAttendeeToolStripMenuItem_Click);
            // 
            // seminarToolStripMenuItem
            // 
            this.seminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSeminarToolStripMenuItem,
            this.displaySeminarToolStripMenuItem});
            this.seminarToolStripMenuItem.Name = "seminarToolStripMenuItem";
            this.seminarToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.seminarToolStripMenuItem.Text = "Seminar";
            // 
            // addSeminarToolStripMenuItem
            // 
            this.addSeminarToolStripMenuItem.Name = "addSeminarToolStripMenuItem";
            this.addSeminarToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.addSeminarToolStripMenuItem.Text = "Add Seminar";
            this.addSeminarToolStripMenuItem.Click += new System.EventHandler(this.addSeminarToolStripMenuItem_Click);
            // 
            // displaySeminarToolStripMenuItem
            // 
            this.displaySeminarToolStripMenuItem.Name = "displaySeminarToolStripMenuItem";
            this.displaySeminarToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.displaySeminarToolStripMenuItem.Text = "Display Seminar";
            this.displaySeminarToolStripMenuItem.Click += new System.EventHandler(this.displaySeminarToolStripMenuItem_Click);
            // 
            // roomAndStallToolStripMenuItem
            // 
            this.roomAndStallToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLocationToolStripMenuItem,
            this.addEventLocationToolStripMenuItem});
            this.roomAndStallToolStripMenuItem.Name = "roomAndStallToolStripMenuItem";
            this.roomAndStallToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.roomAndStallToolStripMenuItem.Text = "Location";
            this.roomAndStallToolStripMenuItem.Click += new System.EventHandler(this.roomAndStallToolStripMenuItem_Click);
            // 
            // addLocationToolStripMenuItem
            // 
            this.addLocationToolStripMenuItem.Name = "addLocationToolStripMenuItem";
            this.addLocationToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.addLocationToolStripMenuItem.Text = "Add Room location";
            this.addLocationToolStripMenuItem.Click += new System.EventHandler(this.addLocationToolStripMenuItem_Click);
            // 
            // addEventLocationToolStripMenuItem
            // 
            this.addEventLocationToolStripMenuItem.Name = "addEventLocationToolStripMenuItem";
            this.addEventLocationToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.addEventLocationToolStripMenuItem.Text = "Add Stall Location";
            this.addEventLocationToolStripMenuItem.Click += new System.EventHandler(this.addEventLocationToolStripMenuItem_Click);
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEventToolStripMenuItem,
            this.viewEventScheduleToolStripMenuItem});
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.eventToolStripMenuItem.Text = "Event";
            // 
            // addEventToolStripMenuItem
            // 
            this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.addEventToolStripMenuItem.Text = "Add event";
            this.addEventToolStripMenuItem.Click += new System.EventHandler(this.addEventToolStripMenuItem_Click);
            // 
            // viewEventScheduleToolStripMenuItem
            // 
            this.viewEventScheduleToolStripMenuItem.Name = "viewEventScheduleToolStripMenuItem";
            this.viewEventScheduleToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.viewEventScheduleToolStripMenuItem.Text = "View Event Schedule";
            this.viewEventScheduleToolStripMenuItem.Click += new System.EventHandler(this.viewEventScheduleToolStripMenuItem_Click);
            // 
            // stallToolStripMenuItem
            // 
            this.stallToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStallToolStripMenuItem,
            this.stallScheduleToolStripMenuItem});
            this.stallToolStripMenuItem.Name = "stallToolStripMenuItem";
            this.stallToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.stallToolStripMenuItem.Text = "Stall";
            // 
            // addStallToolStripMenuItem
            // 
            this.addStallToolStripMenuItem.Name = "addStallToolStripMenuItem";
            this.addStallToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.addStallToolStripMenuItem.Text = "Add Stall";
            this.addStallToolStripMenuItem.Click += new System.EventHandler(this.addStallToolStripMenuItem_Click);
            // 
            // stallScheduleToolStripMenuItem
            // 
            this.stallScheduleToolStripMenuItem.Name = "stallScheduleToolStripMenuItem";
            this.stallScheduleToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.stallScheduleToolStripMenuItem.Text = "Stall Schedule";
            this.stallScheduleToolStripMenuItem.Click += new System.EventHandler(this.stallScheduleToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.addUserToolStripMenuItem.Text = "AddUser";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(62, 23);
            this.logOutToolStripMenuItem1.Text = "LogOut";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 261);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem attendeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAttendeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAttendeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSeminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displaySeminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomAndStallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEventScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addEventLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stallScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}