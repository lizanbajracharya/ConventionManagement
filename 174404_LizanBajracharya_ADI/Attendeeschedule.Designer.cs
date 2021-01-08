namespace _174404_LizanBajracharya_ADI
{
    partial class Attendeeschedule
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
            this.dgAttendee = new System.Windows.Forms.DataGridView();
            this.aid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAttendee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAttendee
            // 
            this.dgAttendee.AllowUserToDeleteRows = false;
            this.dgAttendee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAttendee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aid,
            this.Column2,
            this.Column1,
            this.Column3});
            this.dgAttendee.Location = new System.Drawing.Point(0, 0);
            this.dgAttendee.Name = "dgAttendee";
            this.dgAttendee.ReadOnly = true;
            this.dgAttendee.Size = new System.Drawing.Size(444, 251);
            this.dgAttendee.TabIndex = 0;
            this.dgAttendee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // aid
            // 
            this.aid.DataPropertyName = "Attendeeid";
            this.aid.HeaderText = "SN";
            this.aid.Name = "aid";
            this.aid.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Firstname";
            this.Column2.HeaderText = "Firstname";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Lastname";
            this.Column1.HeaderText = "Lastname";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Numberofdays";
            this.Column3.HeaderText = "Duration";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Attendeeschedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 249);
            this.Controls.Add(this.dgAttendee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Attendeeschedule";
            this.Text = "Attendeeschedule";
            this.Load += new System.EventHandler(this.Attendeeschedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAttendee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAttendee;
        private System.Windows.Forms.DataGridViewTextBoxColumn aid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}