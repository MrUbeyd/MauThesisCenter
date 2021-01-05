
namespace MauThesisCenter
{
    partial class frmEditUni
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
            this.dtEditUni = new System.Windows.Forms.DataGridView();
            this.txtUniversityName = new System.Windows.Forms.TextBox();
            this.lblUniversityName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditUni)).BeginInit();
            this.SuspendLayout();
            // 
            // dtEditUni
            // 
            this.dtEditUni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtEditUni.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtEditUni.BackgroundColor = System.Drawing.Color.White;
            this.dtEditUni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEditUni.Location = new System.Drawing.Point(91, 24);
            this.dtEditUni.Name = "dtEditUni";
            this.dtEditUni.RowHeadersWidth = 51;
            this.dtEditUni.RowTemplate.Height = 24;
            this.dtEditUni.Size = new System.Drawing.Size(628, 150);
            this.dtEditUni.TabIndex = 5;
            this.dtEditUni.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtEditUni_CellClick);
            // 
            // txtUniversityName
            // 
            this.txtUniversityName.Location = new System.Drawing.Point(289, 227);
            this.txtUniversityName.Name = "txtUniversityName";
            this.txtUniversityName.Size = new System.Drawing.Size(223, 22);
            this.txtUniversityName.TabIndex = 11;
            // 
            // lblUniversityName
            // 
            this.lblUniversityName.AutoSize = true;
            this.lblUniversityName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUniversityName.Location = new System.Drawing.Point(317, 201);
            this.lblUniversityName.Name = "lblUniversityName";
            this.lblUniversityName.Size = new System.Drawing.Size(166, 23);
            this.lblUniversityName.TabIndex = 10;
            this.lblUniversityName.Text = "University Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(524, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 55);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(359, 299);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 55);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(178, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 55);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmEditUni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtUniversityName);
            this.Controls.Add(this.lblUniversityName);
            this.Controls.Add(this.dtEditUni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmEditUni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Universities";
            this.Load += new System.EventHandler(this.frmEditUni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtEditUni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtEditUni;
        private System.Windows.Forms.TextBox txtUniversityName;
        private System.Windows.Forms.Label lblUniversityName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}