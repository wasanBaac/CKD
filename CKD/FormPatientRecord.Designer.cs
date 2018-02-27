namespace CKD
{
    partial class FormPatientRecord
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
            this.dateBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateBirthDate
            // 
            this.dateBirthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateBirthDate.Location = new System.Drawing.Point(128, 60);
            this.dateBirthDate.Name = "dateBirthDate";
            this.dateBirthDate.Size = new System.Drawing.Size(222, 32);
            this.dateBirthDate.TabIndex = 14;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDate.Location = new System.Drawing.Point(72, 66);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 26);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "วันที่";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(371, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "eGFR /Stage ";
            // 
            // txtHN
            // 
            this.txtHN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtHN.Location = new System.Drawing.Point(522, 63);
            this.txtHN.MaxLength = 100;
            this.txtHN.Name = "txtHN";
            this.txtHN.Size = new System.Drawing.Size(246, 32);
            this.txtHN.TabIndex = 17;
            // 
            // FormPatientRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.txtHN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateBirthDate);
            this.Name = "FormPatientRecord";
            this.Text = "FormPatientRecord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateBirthDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHN;
    }
}