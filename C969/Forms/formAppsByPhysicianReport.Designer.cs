
namespace OfficeScheduler.Forms
{
    partial class formAppsByPhysicianReport
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
            this.dgvAppsByUser = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAppsByUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppsByUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppsByUser
            // 
            this.dgvAppsByUser.AllowUserToAddRows = false;
            this.dgvAppsByUser.AllowUserToDeleteRows = false;
            this.dgvAppsByUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppsByUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppsByUser.Location = new System.Drawing.Point(28, 49);
            this.dgvAppsByUser.MultiSelect = false;
            this.dgvAppsByUser.Name = "dgvAppsByUser";
            this.dgvAppsByUser.RowHeadersVisible = false;
            this.dgvAppsByUser.Size = new System.Drawing.Size(315, 255);
            this.dgvAppsByUser.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(268, 322);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAppsByUser
            // 
            this.lblAppsByUser.AutoSize = true;
            this.lblAppsByUser.Location = new System.Drawing.Point(25, 22);
            this.lblAppsByUser.Name = "lblAppsByUser";
            this.lblAppsByUser.Size = new System.Drawing.Size(99, 13);
            this.lblAppsByUser.TabIndex = 3;
            this.lblAppsByUser.Text = "All appointments for";
            // 
            // formAppsByPhysicianReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 357);
            this.Controls.Add(this.lblAppsByUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvAppsByUser);
            this.Name = "formAppsByPhysicianReport";
            this.Text = "Appointments by Physician";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppsByUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppsByUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAppsByUser;
    }
}