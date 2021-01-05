
namespace MauThesisCenter
{
    partial class frmMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDetailedSearch = new System.Windows.Forms.Button();
            this.btnLastTheses = new System.Windows.Forms.Button();
            this.btnAddThesis = new System.Windows.Forms.Button();
            this.pContainer = new System.Windows.Forms.Panel();
            this.btnUpdateEditData = new System.Windows.Forms.Button();
            this.btnAuthorLogin = new System.Windows.Forms.Button();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.lblAuthorName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(12, 145);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(213, 66);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDetailedSearch
            // 
            this.btnDetailedSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDetailedSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailedSearch.ForeColor = System.Drawing.Color.White;
            this.btnDetailedSearch.Location = new System.Drawing.Point(12, 217);
            this.btnDetailedSearch.Name = "btnDetailedSearch";
            this.btnDetailedSearch.Size = new System.Drawing.Size(213, 66);
            this.btnDetailedSearch.TabIndex = 3;
            this.btnDetailedSearch.Text = "Detailed Search";
            this.btnDetailedSearch.UseVisualStyleBackColor = false;
            this.btnDetailedSearch.Click += new System.EventHandler(this.btnDetailedSearch_Click);
            // 
            // btnLastTheses
            // 
            this.btnLastTheses.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLastTheses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastTheses.ForeColor = System.Drawing.Color.White;
            this.btnLastTheses.Location = new System.Drawing.Point(12, 289);
            this.btnLastTheses.Name = "btnLastTheses";
            this.btnLastTheses.Size = new System.Drawing.Size(213, 66);
            this.btnLastTheses.TabIndex = 4;
            this.btnLastTheses.Text = "Last Theses";
            this.btnLastTheses.UseVisualStyleBackColor = false;
            this.btnLastTheses.Click += new System.EventHandler(this.btnLastThesis_Click);
            // 
            // btnAddThesis
            // 
            this.btnAddThesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddThesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddThesis.ForeColor = System.Drawing.Color.White;
            this.btnAddThesis.Location = new System.Drawing.Point(12, 385);
            this.btnAddThesis.Name = "btnAddThesis";
            this.btnAddThesis.Size = new System.Drawing.Size(213, 66);
            this.btnAddThesis.TabIndex = 5;
            this.btnAddThesis.Text = "Add New Thesis";
            this.btnAddThesis.UseVisualStyleBackColor = false;
            this.btnAddThesis.Click += new System.EventHandler(this.btnAddThesis_Click);
            // 
            // pContainer
            // 
            this.pContainer.Location = new System.Drawing.Point(231, 12);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1090, 663);
            this.pContainer.TabIndex = 1;
            // 
            // btnUpdateEditData
            // 
            this.btnUpdateEditData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdateEditData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEditData.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEditData.Location = new System.Drawing.Point(12, 457);
            this.btnUpdateEditData.Name = "btnUpdateEditData";
            this.btnUpdateEditData.Size = new System.Drawing.Size(213, 66);
            this.btnUpdateEditData.TabIndex = 6;
            this.btnUpdateEditData.Text = "Update/Edit Data";
            this.btnUpdateEditData.UseVisualStyleBackColor = false;
            this.btnUpdateEditData.Click += new System.EventHandler(this.btnUpdateEditData_Click);
            // 
            // btnAuthorLogin
            // 
            this.btnAuthorLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAuthorLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthorLogin.ForeColor = System.Drawing.Color.White;
            this.btnAuthorLogin.Location = new System.Drawing.Point(12, 609);
            this.btnAuthorLogin.Name = "btnAuthorLogin";
            this.btnAuthorLogin.Size = new System.Drawing.Size(213, 66);
            this.btnAuthorLogin.TabIndex = 8;
            this.btnAuthorLogin.Text = "Author Login";
            this.btnAuthorLogin.UseVisualStyleBackColor = false;
            this.btnAuthorLogin.Click += new System.EventHandler(this.btnAuthorLogin_Click);
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(12, 571);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(213, 32);
            this.txtAuthorName.TabIndex = 7;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Location = new System.Drawing.Point(47, 545);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(142, 23);
            this.lblAuthorName.TabIndex = 10;
            this.lblAuthorName.Text = "Author Name";
            // 
            // frmMainPage
            // 
            this.AcceptButton = this.btnAuthorLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 687);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.btnAuthorLogin);
            this.Controls.Add(this.btnUpdateEditData);
            this.Controls.Add(this.btnAddThesis);
            this.Controls.Add(this.btnLastTheses);
            this.Controls.Add(this.btnDetailedSearch);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "- MAU Thesis Center -";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDetailedSearch;
        private System.Windows.Forms.Button btnLastTheses;
        private System.Windows.Forms.Button btnAddThesis;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Button btnUpdateEditData;
        private System.Windows.Forms.Button btnAuthorLogin;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label lblAuthorName;
    }
}

