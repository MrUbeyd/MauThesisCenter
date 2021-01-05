
namespace MauThesisCenter
{
    partial class frmAuthorLogin
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
            this.dtPublishedTheses = new System.Windows.Forms.DataGridView();
            this.lblPublishedTheses = new System.Windows.Forms.Label();
            this.txtAddKeyword = new System.Windows.Forms.TextBox();
            this.btnAddKeyword = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.btnAddTopic = new System.Windows.Forms.Button();
            this.cmbAddTopic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThesisDelete = new System.Windows.Forms.Button();
            this.dtThesisTopics = new System.Windows.Forms.DataGridView();
            this.dtThesisKeywords = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtPublishedTheses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtThesisTopics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtThesisKeywords)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPublishedTheses
            // 
            this.dtPublishedTheses.AllowUserToAddRows = false;
            this.dtPublishedTheses.AllowUserToDeleteRows = false;
            this.dtPublishedTheses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtPublishedTheses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtPublishedTheses.BackgroundColor = System.Drawing.Color.White;
            this.dtPublishedTheses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPublishedTheses.Location = new System.Drawing.Point(55, 75);
            this.dtPublishedTheses.Name = "dtPublishedTheses";
            this.dtPublishedTheses.ReadOnly = true;
            this.dtPublishedTheses.RowHeadersWidth = 51;
            this.dtPublishedTheses.RowTemplate.Height = 24;
            this.dtPublishedTheses.Size = new System.Drawing.Size(766, 153);
            this.dtPublishedTheses.TabIndex = 23;
            this.dtPublishedTheses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPublishedTheses_CellClick);
            // 
            // lblPublishedTheses
            // 
            this.lblPublishedTheses.AutoSize = true;
            this.lblPublishedTheses.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPublishedTheses.Location = new System.Drawing.Point(323, 38);
            this.lblPublishedTheses.Name = "lblPublishedTheses";
            this.lblPublishedTheses.Size = new System.Drawing.Size(240, 34);
            this.lblPublishedTheses.TabIndex = 24;
            this.lblPublishedTheses.Text = "Published Theses";
            // 
            // txtAddKeyword
            // 
            this.txtAddKeyword.Location = new System.Drawing.Point(55, 402);
            this.txtAddKeyword.Name = "txtAddKeyword";
            this.txtAddKeyword.Size = new System.Drawing.Size(195, 22);
            this.txtAddKeyword.TabIndex = 25;
            // 
            // btnAddKeyword
            // 
            this.btnAddKeyword.Location = new System.Drawing.Point(89, 430);
            this.btnAddKeyword.Name = "btnAddKeyword";
            this.btnAddKeyword.Size = new System.Drawing.Size(131, 50);
            this.btnAddKeyword.TabIndex = 26;
            this.btnAddKeyword.Text = "Add Keyword";
            this.btnAddKeyword.UseVisualStyleBackColor = true;
            this.btnAddKeyword.Click += new System.EventHandler(this.btnAddKeyword_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthor.Location = new System.Drawing.Point(12, 9);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(213, 34);
            this.lblAuthor.TabIndex = 27;
            this.lblAuthor.Text = "Author Name: ";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthorName.Location = new System.Drawing.Point(209, 9);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(0, 34);
            this.lblAuthorName.TabIndex = 28;
            // 
            // btnAddTopic
            // 
            this.btnAddTopic.Location = new System.Drawing.Point(351, 430);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.Size = new System.Drawing.Size(131, 50);
            this.btnAddTopic.TabIndex = 30;
            this.btnAddTopic.Text = "Add Topic";
            this.btnAddTopic.UseVisualStyleBackColor = true;
            this.btnAddTopic.Click += new System.EventHandler(this.btnAddTopic_Click);
            // 
            // cmbAddTopic
            // 
            this.cmbAddTopic.FormattingEnabled = true;
            this.cmbAddTopic.Items.AddRange(new object[] {
            "Psychology",
            "Social Services",
            "Education",
            "Architecture",
            "Biology",
            "Computer Engineering",
            "Mechanical Engineering",
            "Banking",
            "Science and Technology",
            "Mathematics"});
            this.cmbAddTopic.Location = new System.Drawing.Point(315, 400);
            this.cmbAddTopic.Name = "cmbAddTopic";
            this.cmbAddTopic.Size = new System.Drawing.Size(197, 24);
            this.cmbAddTopic.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(258, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 34);
            this.label1.TabIndex = 33;
            this.label1.Text = "Selected Thesis Operations";
            // 
            // btnThesisDelete
            // 
            this.btnThesisDelete.Location = new System.Drawing.Point(635, 402);
            this.btnThesisDelete.Name = "btnThesisDelete";
            this.btnThesisDelete.Size = new System.Drawing.Size(131, 50);
            this.btnThesisDelete.TabIndex = 34;
            this.btnThesisDelete.Text = "Delete";
            this.btnThesisDelete.UseVisualStyleBackColor = true;
            this.btnThesisDelete.Click += new System.EventHandler(this.btnThesisDelete_Click);
            // 
            // dtThesisTopics
            // 
            this.dtThesisTopics.AllowUserToAddRows = false;
            this.dtThesisTopics.AllowUserToDeleteRows = false;
            this.dtThesisTopics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtThesisTopics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtThesisTopics.BackgroundColor = System.Drawing.Color.White;
            this.dtThesisTopics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtThesisTopics.Location = new System.Drawing.Point(55, 234);
            this.dtThesisTopics.Name = "dtThesisTopics";
            this.dtThesisTopics.ReadOnly = true;
            this.dtThesisTopics.RowHeadersWidth = 51;
            this.dtThesisTopics.RowTemplate.Height = 24;
            this.dtThesisTopics.Size = new System.Drawing.Size(386, 105);
            this.dtThesisTopics.TabIndex = 36;
            // 
            // dtThesisKeywords
            // 
            this.dtThesisKeywords.AllowUserToAddRows = false;
            this.dtThesisKeywords.AllowUserToDeleteRows = false;
            this.dtThesisKeywords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtThesisKeywords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtThesisKeywords.BackgroundColor = System.Drawing.Color.White;
            this.dtThesisKeywords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtThesisKeywords.Location = new System.Drawing.Point(447, 234);
            this.dtThesisKeywords.Name = "dtThesisKeywords";
            this.dtThesisKeywords.ReadOnly = true;
            this.dtThesisKeywords.RowHeadersWidth = 51;
            this.dtThesisKeywords.RowTemplate.Height = 24;
            this.dtThesisKeywords.Size = new System.Drawing.Size(369, 105);
            this.dtThesisKeywords.TabIndex = 37;
            // 
            // frmAuthorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 621);
            this.Controls.Add(this.dtThesisKeywords);
            this.Controls.Add(this.dtThesisTopics);
            this.Controls.Add(this.btnThesisDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAddTopic);
            this.Controls.Add(this.btnAddTopic);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.btnAddKeyword);
            this.Controls.Add(this.txtAddKeyword);
            this.Controls.Add(this.lblPublishedTheses);
            this.Controls.Add(this.dtPublishedTheses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAuthorLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAuthorLogin";
            this.Load += new System.EventHandler(this.frmAuthorLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPublishedTheses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtThesisTopics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtThesisKeywords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtPublishedTheses;
        private System.Windows.Forms.Label lblPublishedTheses;
        private System.Windows.Forms.TextBox txtAddKeyword;
        private System.Windows.Forms.Button btnAddKeyword;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Button btnAddTopic;
        private System.Windows.Forms.ComboBox cmbAddTopic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThesisDelete;
        private System.Windows.Forms.DataGridView dtThesisTopics;
        private System.Windows.Forms.DataGridView dtThesisKeywords;
    }
}