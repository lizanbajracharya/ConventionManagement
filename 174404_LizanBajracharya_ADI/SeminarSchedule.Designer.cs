namespace _174404_LizanBajracharya_ADI
{
    partial class SeminarSchedule
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
            this.dgSeminar = new System.Windows.Forms.DataGridView();
            this.eid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberRegistered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgSeminar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSeminar
            // 
            this.dgSeminar.AllowUserToDeleteRows = false;
            this.dgSeminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSeminar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eid,
            this.Title,
            this.Presenter,
            this.Duration,
            this.NumberRegistered});
            this.dgSeminar.Location = new System.Drawing.Point(1, 1);
            this.dgSeminar.Name = "dgSeminar";
            this.dgSeminar.ReadOnly = true;
            this.dgSeminar.Size = new System.Drawing.Size(546, 314);
            this.dgSeminar.TabIndex = 0;
            // 
            // eid
            // 
            this.eid.DataPropertyName = "Seminarid";
            this.eid.HeaderText = "id";
            this.eid.Name = "eid";
            this.eid.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Presenter
            // 
            this.Presenter.DataPropertyName = "Firstname";
            this.Presenter.HeaderText = "Presenter";
            this.Presenter.Name = "Presenter";
            this.Presenter.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // NumberRegistered
            // 
            this.NumberRegistered.DataPropertyName = "Audienceid";
            this.NumberRegistered.HeaderText = "NumberRegistered";
            this.NumberRegistered.Name = "NumberRegistered";
            this.NumberRegistered.ReadOnly = true;
            // 
            // SeminarSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 317);
            this.Controls.Add(this.dgSeminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SeminarSchedule";
            this.Text = "SeminarSchedule";
            this.Load += new System.EventHandler(this.SeminarSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSeminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSeminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn eid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberRegistered;
    }
}