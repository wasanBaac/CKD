namespace CKD
{
    partial class FormDisease
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
            this.lbDisease = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbDiseaseSelected = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbDisease
            // 
            this.lbDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbDisease.FormattingEnabled = true;
            this.lbDisease.ItemHeight = 24;
            this.lbDisease.Location = new System.Drawing.Point(12, 12);
            this.lbDisease.Name = "lbDisease";
            this.lbDisease.Size = new System.Drawing.Size(237, 364);
            this.lbDisease.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(255, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "เพิ่ม";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(255, 167);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "ลบ";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lbDiseaseSelected
            // 
            this.lbDiseaseSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbDiseaseSelected.FormattingEnabled = true;
            this.lbDiseaseSelected.ItemHeight = 24;
            this.lbDiseaseSelected.Location = new System.Drawing.Point(336, 12);
            this.lbDiseaseSelected.Name = "lbDiseaseSelected";
            this.lbDiseaseSelected.Size = new System.Drawing.Size(237, 364);
            this.lbDiseaseSelected.TabIndex = 3;
            // 
            // FormDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 415);
            this.Controls.Add(this.lbDiseaseSelected);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbDisease);
            this.Name = "FormDisease";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDisease";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDisease;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lbDiseaseSelected;
    }
}