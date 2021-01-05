
namespace MauThesisCenter
{
    partial class frmSearch
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
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbSearchArea = new System.Windows.Forms.ComboBox();
            this.lblSearchArea = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTypeToSearch = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dtSearch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.ItemHeight = 23;
            this.cmbLanguage.Location = new System.Drawing.Point(723, 125);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(206, 31);
            this.cmbLanguage.TabIndex = 4;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLanguage.Location = new System.Drawing.Point(764, 99);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(110, 23);
            this.lblLanguage.TabIndex = 17;
            this.lblLanguage.Text = "Language";
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ItemHeight = 23;
            this.cmbType.Location = new System.Drawing.Point(447, 125);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(206, 31);
            this.cmbType.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblType.Location = new System.Drawing.Point(523, 99);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(56, 23);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "Type";
            // 
            // cmbSearchArea
            // 
            this.cmbSearchArea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSearchArea.FormattingEnabled = true;
            this.cmbSearchArea.Items.AddRange(new object[] {
            "Author",
            "Supervisor",
            "Topic",
            "Title",
            "Abstract"});
            this.cmbSearchArea.Location = new System.Drawing.Point(162, 125);
            this.cmbSearchArea.Name = "cmbSearchArea";
            this.cmbSearchArea.Size = new System.Drawing.Size(206, 31);
            this.cmbSearchArea.TabIndex = 2;
            // 
            // lblSearchArea
            // 
            this.lblSearchArea.AutoSize = true;
            this.lblSearchArea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchArea.Location = new System.Drawing.Point(193, 99);
            this.lblSearchArea.Name = "lblSearchArea";
            this.lblSearchArea.Size = new System.Drawing.Size(132, 23);
            this.lblSearchArea.TabIndex = 13;
            this.lblSearchArea.Text = "Search Area";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(371, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(357, 32);
            this.txtSearch.TabIndex = 1;
            // 
            // lblTypeToSearch
            // 
            this.lblTypeToSearch.AutoSize = true;
            this.lblTypeToSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTypeToSearch.Location = new System.Drawing.Point(473, 13);
            this.lblTypeToSearch.Name = "lblTypeToSearch";
            this.lblTypeToSearch.Size = new System.Drawing.Size(156, 23);
            this.lblTypeToSearch.TabIndex = 19;
            this.lblTypeToSearch.Text = "Type to Search";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(371, 192);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(131, 74);
            this.btnFind.TabIndex = 20;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(597, 192);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 74);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtSearch
            // 
            this.dtSearch.AllowUserToAddRows = false;
            this.dtSearch.AllowUserToDeleteRows = false;
            this.dtSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtSearch.BackgroundColor = System.Drawing.Color.White;
            this.dtSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSearch.Location = new System.Drawing.Point(12, 295);
            this.dtSearch.Name = "dtSearch";
            this.dtSearch.ReadOnly = true;
            this.dtSearch.RowHeadersWidth = 51;
            this.dtSearch.RowTemplate.Height = 24;
            this.dtSearch.Size = new System.Drawing.Size(1055, 351);
            this.dtSearch.TabIndex = 22;
            // 
            // frmSearch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 658);
            this.Controls.Add(this.dtSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblTypeToSearch);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbSearchArea);
            this.Controls.Add(this.lblSearchArea);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearch";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbSearchArea;
        private System.Windows.Forms.Label lblSearchArea;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTypeToSearch;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dtSearch;
    }
}