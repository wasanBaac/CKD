namespace CKD
{
    partial class startForm
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHN
            // 
            this.txtHN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtHN.Location = new System.Drawing.Point(384, 157);
            this.txtHN.MaxLength = 100;
            this.txtHN.Name = "txtHN";
            this.txtHN.Size = new System.Drawing.Size(350, 32);
            this.txtHN.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.Orange;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(808, 154);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 39);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblsearch.Location = new System.Drawing.Point(231, 159);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(147, 29);
            this.lblsearch.TabIndex = 2;
            this.lblsearch.Text = "HN, ชื่อ, สกุล";
            // 
            // gvPatient
            // 
            this.gvPatient.AllowUserToAddRows = false;
            this.gvPatient.AllowUserToDeleteRows = false;
            this.gvPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvPatient.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.gvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnView});
            this.gvPatient.Location = new System.Drawing.Point(173, 237);
            this.gvPatient.Name = "gvPatient";
            this.gvPatient.ReadOnly = true;
            this.gvPatient.Size = new System.Drawing.Size(935, 399);
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
            this.btnNewPatient.BackColor = System.Drawing.Color.Turquoise;
            this.btnNewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnNewPatient.Location = new System.Drawing.Point(946, 154);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(101, 39);
            this.btnNewPatient.TabIndex = 5;
            this.btnNewPatient.Text = "เพิ่มข้อมูล";
            this.btnNewPatient.UseVisualStyleBackColor = false;
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(227, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(827, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "โปรแกรมบันทึกข้อมูลผู้ป่วยโรคไตวายเรื้อรัง";
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewPatient);
            this.Controls.Add(this.gvPatient);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtHN);
            this.Name = "startForm";
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
        private System.Windows.Forms.Label label1;
    }
}

