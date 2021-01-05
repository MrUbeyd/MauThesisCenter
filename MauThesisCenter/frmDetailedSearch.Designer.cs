
namespace MauThesisCenter
{
    partial class frmDetailedSearch
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
            this.cmbUniversity = new System.Windows.Forms.ComboBox();
            this.lblUniversity = new System.Windows.Forms.Label();
            this.cmbInstitute = new System.Windows.Forms.ComboBox();
            this.lblInstitute = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThesisNO = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.dtDetailedSearch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetailedSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUniversity
            // 
            this.cmbUniversity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUniversity.FormattingEnabled = true;
            this.cmbUniversity.Location = new System.Drawing.Point(79, 57);
            this.cmbUniversity.Name = "cmbUniversity";
            this.cmbUniversity.Size = new System.Drawing.Size(206, 31);
            this.cmbUniversity.TabIndex = 14;
            this.cmbUniversity.SelectedIndexChanged += new System.EventHandler(this.cmbUniversity_SelectedIndexChanged);
            // 
            // lblUniversity
            // 
            this.lblUniversity.AutoSize = true;
            this.lblUniversity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUniversity.Location = new System.Drawing.Point(127, 31);
            this.lblUniversity.Name = "lblUniversity";
            this.lblUniversity.Size = new System.Drawing.Size(99, 23);
            this.lblUniversity.TabIndex = 15;
            this.lblUniversity.Text = "University";
            // 
            // cmbInstitute
            // 
            this.cmbInstitute.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbInstitute.FormattingEnabled = true;
            this.cmbInstitute.Location = new System.Drawing.Point(79, 145);
            this.cmbInstitute.Name = "cmbInstitute";
            this.cmbInstitute.Size = new System.Drawing.Size(206, 31);
            this.cmbInstitute.TabIndex = 16;
            this.cmbInstitute.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbInstitute_MouseClick);
            // 
            // lblInstitute
            // 
            this.lblInstitute.AutoSize = true;
            this.lblInstitute.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInstitute.Location = new System.Drawing.Point(127, 119);
            this.lblInstitute.Name = "lblInstitute";
            this.lblInstitute.Size = new System.Drawing.Size(84, 23);
            this.lblInstitute.TabIndex = 17;
            this.lblInstitute.Text = "Institute";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(360, 57);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(206, 22);
            this.txtYear.TabIndex = 18;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYear.Location = new System.Drawing.Point(435, 31);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(56, 23);
            this.lblYear.TabIndex = 19;
            this.lblYear.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(406, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thesis NO";
            // 
            // txtThesisNO
            // 
            this.txtThesisNO.Location = new System.Drawing.Point(360, 145);
            this.txtThesisNO.Name = "txtThesisNO";
            this.txtThesisNO.Size = new System.Drawing.Size(206, 22);
            this.txtThesisNO.TabIndex = 20;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(702, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 51);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(702, 34);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(131, 45);
            this.btnFind.TabIndex = 22;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dtDetailedSearch
            // 
            this.dtDetailedSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtDetailedSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtDetailedSearch.BackgroundColor = System.Drawing.Color.White;
            this.dtDetailedSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDetailedSearch.Location = new System.Drawing.Point(53, 197);
            this.dtDetailedSearch.Name = "dtDetailedSearch";
            this.dtDetailedSearch.RowHeadersWidth = 51;
            this.dtDetailedSearch.RowTemplate.Height = 24;
            this.dtDetailedSearch.Size = new System.Drawing.Size(780, 299);
            this.dtDetailedSearch.TabIndex = 24;
            // 
            // frmDetailedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 646);
            this.Controls.Add(this.dtDetailedSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThesisNO);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.cmbInstitute);
            this.Controls.Add(this.lblInstitute);
            this.Controls.Add(this.cmbUniversity);
            this.Controls.Add(this.lblUniversity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetailedSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetailedSearch";
            this.Load += new System.EventHandler(this.frmDetailedSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDetailedSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUniversity;
        private System.Windows.Forms.Label lblUniversity;
        private System.Windows.Forms.ComboBox cmbInstitute;
        private System.Windows.Forms.Label lblInstitute;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThesisNO;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dtDetailedSearch;
    }
}