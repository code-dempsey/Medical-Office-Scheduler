
namespace OfficeScheduler.Forms
{
    partial class formAppsByPatientReport
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
            this.dgvAppsByCust = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAppsByCust = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppsByCust)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppsByCust
            // 
            this.dgvAppsByCust.AllowUserToAddRows = false;
            this.dgvAppsByCust.AllowUserToDeleteRows = false;
            this.dgvAppsByCust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppsByCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppsByCust.Location = new System.Drawing.Point(28, 49);
            this.dgvAppsByCust.MultiSelect = false;
            this.dgvAppsByCust.Name = "dgvAppsByCust";
            this.dgvAppsByCust.ReadOnly = true;
            this.dgvAppsByCust.RowHeadersVisible = false;
            this.dgvAppsByCust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppsByCust.Size = new System.Drawing.Size(315, 256);
            this.dgvAppsByCust.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(268, 322);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAppsByCust
            // 
            this.lblAppsByCust.AutoSize = true;
            this.lblAppsByCust.Location = new System.Drawing.Point(25, 22);
            this.lblAppsByCust.Name = "lblAppsByCust";
            this.lblAppsByCust.Size = new System.Drawing.Size(99, 13);
            this.lblAppsByCust.TabIndex = 2;
            this.lblAppsByCust.Text = "All appointments for";
            // 
            // formAppsByPatientReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 357);
            this.Controls.Add(this.lblAppsByCust);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvAppsByCust);
            this.Name = "formAppsByPatientReport";
            this.Text = "Appointments by Patient";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppsByCust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppsByCust;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAppsByCust;
    }
}