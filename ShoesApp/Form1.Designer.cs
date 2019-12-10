namespace ShoesApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxId = new System.Windows.Forms.ComboBox();
            this.cboxName = new System.Windows.Forms.ComboBox();
            this.btnFindId = new System.Windows.Forms.Button();
            this.btnFindName = new System.Windows.Forms.Button();
            this.ShoesList = new System.Windows.Forms.DataGridView();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShoesList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // cboxId
            // 
            this.cboxId.FormattingEnabled = true;
            this.cboxId.Location = new System.Drawing.Point(126, 50);
            this.cboxId.Name = "cboxId";
            this.cboxId.Size = new System.Drawing.Size(156, 28);
            this.cboxId.TabIndex = 2;
            // 
            // cboxName
            // 
            this.cboxName.FormattingEnabled = true;
            this.cboxName.Location = new System.Drawing.Point(126, 104);
            this.cboxName.Name = "cboxName";
            this.cboxName.Size = new System.Drawing.Size(156, 28);
            this.cboxName.TabIndex = 3;
            // 
            // btnFindId
            // 
            this.btnFindId.Location = new System.Drawing.Point(307, 46);
            this.btnFindId.Name = "btnFindId";
            this.btnFindId.Size = new System.Drawing.Size(75, 35);
            this.btnFindId.TabIndex = 4;
            this.btnFindId.Text = "Find";
            this.btnFindId.UseVisualStyleBackColor = true;
            // 
            // btnFindName
            // 
            this.btnFindName.Location = new System.Drawing.Point(307, 100);
            this.btnFindName.Name = "btnFindName";
            this.btnFindName.Size = new System.Drawing.Size(75, 35);
            this.btnFindName.TabIndex = 5;
            this.btnFindName.Text = "Find";
            this.btnFindName.UseVisualStyleBackColor = true;
            // 
            // ShoesList
            // 
            this.ShoesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShoesList.Location = new System.Drawing.Point(34, 172);
            this.ShoesList.Name = "ShoesList";
            this.ShoesList.RowTemplate.Height = 28;
            this.ShoesList.Size = new System.Drawing.Size(746, 235);
            this.ShoesList.TabIndex = 6;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(615, 425);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 38);
            this.BtnEdit.TabIndex = 7;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(705, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 38);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.ShoesList);
            this.Controls.Add(this.btnFindName);
            this.Controls.Add(this.btnFindId);
            this.Controls.Add(this.cboxName);
            this.Controls.Add(this.cboxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ShoesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxId;
        private System.Windows.Forms.ComboBox cboxName;
        private System.Windows.Forms.Button btnFindId;
        private System.Windows.Forms.Button btnFindName;
        private System.Windows.Forms.DataGridView ShoesList;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}

