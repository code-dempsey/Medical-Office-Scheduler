namespace OfficeScheduler.Forms
{
    partial class formAppsByPhysMonth
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
            this.lblAppsByUser = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvAppsByPhysMonth = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppsByPhysMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppsByUser
            // 
            this.lblAppsByUser.AutoSize = true;
            this.lblAppsByUser.Location = new System.Drawing.Point(23, 21);
            this.lblAppsByUser.Name = "lblAppsByUser";
            this.lblAppsByUser.Size = new System.Drawing.Size(99, 13);
            this.lblAppsByUser.TabIndex = 6;
            this.lblAppsByUser.Text = "All appointments for";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(269, 322);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvAppsByPhysMonth
            // 
            this.dgvAppsByPhysMonth.AllowUserToAddRows = false;
            this.dgvAppsByPhysMonth.AllowUserToDeleteRows = false;
            this.dgvAppsByPhysMonth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppsByPhysMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppsByPhysMonth.Location = new System.Drawing.Point(25, 49);
            this.dgvAppsByPhysMonth.MultiSelect = false;
            this.dgvAppsByPhysMonth.Name = "dgvAppsByPhysMonth";
            this.dgvAppsByPhysMonth.RowHeadersVisible = false;
            this.dgvAppsByPhysMonth.Size = new System.Drawing.Size(318, 248);
            this.dgvAppsByPhysMonth.TabIndex = 4;
            // 
            // formAppsByPhysMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 357);
            this.Controls.Add(this.lblAppsByUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvAppsByPhysMonth);
            this.Name = "formAppsByPhysMonth";
            this.Text = "Monthly Appointments by Physician";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppsByPhysMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppsByUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvAppsByPhysMonth;
    }
}