
namespace MauThesisCenter
{
    partial class frmEditInstitutes
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtEditInstitutes = new System.Windows.Forms.DataGridView();
            this.txtInstituteName = new System.Windows.Forms.TextBox();
            this.lblInstituteName = new System.Windows.Forms.Label();
            this.lblUniversity = new System.Windows.Forms.Label();
            this.cmbUniversity = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditInstitutes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(519, 335);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 55);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(354, 335);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 55);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(173, 335);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 55);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtEditInstitutes
            // 
            this.dtEditInstitutes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtEditInstitutes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtEditInstitutes.BackgroundColor = System.Drawing.Color.White;
            this.dtEditInstitutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEditInstitutes.Location = new System.Drawing.Point(86, 60);
            this.dtEditInstitutes.Name = "dtEditInstitutes";
            this.dtEditInstitutes.RowHeadersWidth = 51;
            this.dtEditInstitutes.RowTemplate.Height = 24;
            this.dtEditInstitutes.Size = new System.Drawing.Size(628, 150);
            this.dtEditInstitutes.TabIndex = 15;
            this.dtEditInstitutes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtEditInstitutes_CellClick);
            // 
            // txtInstituteName
            // 
            this.txtInstituteName.Location = new System.Drawing.Point(436, 263);
            this.txtInstituteName.Name = "txtInstituteName";
            this.txtInstituteName.Size = new System.Drawing.Size(223, 22);
            this.txtInstituteName.TabIndex = 22;
            // 
            // lblInstituteName
            // 
            this.lblInstituteName.AutoSize = true;
            this.lblInstituteName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInstituteName.Location = new System.Drawing.Point(464, 237);
            this.lblInstituteName.Name = "lblInstituteName";
            this.lblInstituteName.Size = new System.Drawing.Size(151, 23);
            this.lblInstituteName.TabIndex = 21;
            this.lblInstituteName.Text = "Institute Name";
            // 
            // lblUniversity
            // 
            this.lblUniversity.AutoSize = true;
            this.lblUniversity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUniversity.Location = new System.Drawing.Point(169, 237);
            this.lblUniversity.Name = "lblUniversity";
            this.lblUniversity.Size = new System.Drawing.Size(166, 23);
            this.lblUniversity.TabIndex = 23;
            this.lblUniversity.Text = "University Name";
            // 
            // cmbUniversity
            // 
            this.cmbUniversity.FormattingEnabled = true;
            this.cmbUniversity.Location = new System.Drawing.Point(131, 263);
            this.cmbUniversity.Name = "cmbUniversity";
            this.cmbUniversity.Size = new System.Drawing.Size(223, 24);
            this.cmbUniversity.TabIndex = 24;
            // 
            // frmEditInstitutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbUniversity);
            this.Controls.Add(this.lblUniversity);
            this.Controls.Add(this.txtInstituteName);
            this.Controls.Add(this.lblInstituteName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtEditInstitutes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditInstitutes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Institutes";
            this.Load += new System.EventHandler(this.frmEditInstitutes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtEditInstitutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtEditInstitutes;
        private System.Windows.Forms.TextBox txtInstituteName;
        private System.Windows.Forms.Label lblInstituteName;
        private System.Windows.Forms.Label lblUniversity;
        private System.Windows.Forms.ComboBox cmbUniversity;
    }
}