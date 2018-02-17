namespace CKD
{
    partial class startUpForm
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
            this.txtHN = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblsearch = new System.Windows.Forms.Label();
            this.gvPatient = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNewPatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHN
            // 
            this.txtHN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtHN.Location = new System.Drawing.Point(374, 147);
            this.txtHN.MaxLength = 100;
            this.txtHN.Name = "txtHN";
            this.txtHN.Size = new System.Drawing.Size(350, 32);
            this.txtHN.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(752, 146);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 39);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblsearch.Location = new System.Drawing.Point(253, 150);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(115, 26);
            this.lblsearch.TabIndex = 2;
            this.lblsearch.Text = "HN,ชื่อ,สกุล";
            // 
            // gvPatient
            // 
            this.gvPatient.AllowUserToAddRows = false;
            this.gvPatient.AllowUserToDeleteRows = false;
            this.gvPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvPatient.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.gvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnView});
            this.gvPatient.Location = new System.Drawing.Point(175, 249);
            this.gvPatient.Name = "gvPatient";
            this.gvPatient.ReadOnly = true;
            this.gvPatient.Size = new System.Drawing.Size(923, 316);
            this.gvPatient.TabIndex = 4;
            this.gvPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPatient_CellContentClick);
            this.gvPatient.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvPatient_CellFormatting);
            // 
            // btnView
            // 
            this.btnView.HeaderText = "";
            this.btnView.Name = "btnView";
            this.btnView.ReadOnly = true;
            this.btnView.Text = "View";
            this.btnView.UseColumnTextForButtonValue = true;
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewPatient.BackColor = System.Drawing.SystemColors.Info;
            this.btnNewPatient.Location = new System.Drawing.Point(869, 146);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(82, 39);
            this.btnNewPatient.TabIndex = 5;
            this.btnNewPatient.Text = "เพิ่มข้อมูล";
            this.btnNewPatient.UseVisualStyleBackColor = false;
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // startUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnNewPatient);
            this.Controls.Add(this.gvPatient);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtHN);
            this.Name = "startUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CKD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gvPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHN;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.DataGridView gvPatient;
        private System.Windows.Forms.DataGridViewButtonColumn btnView;
        private System.Windows.Forms.Button btnNewPatient;
    }
}

