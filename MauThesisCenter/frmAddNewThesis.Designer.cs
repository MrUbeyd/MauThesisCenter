
namespace MauThesisCenter
{
    partial class frmAddNewThesis
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
            this.btnAddThesis = new System.Windows.Forms.Button();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.lblUniversity = new System.Windows.Forms.Label();
            this.lblInstitute = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.rtxtAbstract = new System.Windows.Forms.RichTextBox();
            this.lblAbstract = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblNumberOP = new System.Windows.Forms.Label();
            this.txtNumberOP = new System.Windows.Forms.TextBox();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.txtSupervisor = new System.Windows.Forms.TextBox();
            this.lblCoSupervisor = new System.Windows.Forms.Label();
            this.txtCoSupervisor = new System.Windows.Forms.TextBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbUniversity = new System.Windows.Forms.ComboBox();
            this.cmbInstitute = new System.Windows.Forms.ComboBox();
            this.cmbTopic = new System.Windows.Forms.ComboBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddThesis
            // 
            this.btnAddThesis.Location = new System.Drawing.Point(209, 388);
            this.btnAddThesis.Name = "btnAddThesis";
            this.btnAddThesis.Size = new System.Drawing.Size(131, 74);
            this.btnAddThesis.TabIndex = 13;
            this.btnAddThesis.Text = "ADD Thesis";
            this.btnAddThesis.UseVisualStyleBackColor = true;
            this.btnAddThesis.Click += new System.EventHandler(this.btnAddThesis_Click);
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthorName.Location = new System.Drawing.Point(92, 38);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(165, 23);
            this.lblAuthorName.TabIndex = 25;
            this.lblAuthorName.Text = "Author Name(*)";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(54, 64);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(206, 22);
            this.txtAuthorName.TabIndex = 1;
            // 
            // lblUniversity
            // 
            this.lblUniversity.AutoSize = true;
            this.lblUniversity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUniversity.Location = new System.Drawing.Point(106, 113);
            this.lblUniversity.Name = "lblUniversity";
            this.lblUniversity.Size = new System.Drawing.Size(122, 23);
            this.lblUniversity.TabIndex = 27;
            this.lblUniversity.Text = "University(*)";
            // 
            // lblInstitute
            // 
            this.lblInstitute.AutoSize = true;
            this.lblInstitute.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInstitute.Location = new System.Drawing.Point(106, 195);
            this.lblInstitute.Name = "lblInstitute";
            this.lblInstitute.Size = new System.Drawing.Size(107, 23);
            this.lblInstitute.TabIndex = 29;
            this.lblInstitute.Text = "Institute(*)";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLanguage.Location = new System.Drawing.Point(381, 38);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(133, 23);
            this.lblLanguage.TabIndex = 31;
            this.lblLanguage.Text = "Language(*)";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblType.Location = new System.Drawing.Point(407, 113);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(79, 23);
            this.lblType.TabIndex = 33;
            this.lblType.Text = "Type(*)";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(407, 195);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(69, 23);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Title(*)";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(336, 221);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(206, 22);
            this.txtTitle.TabIndex = 6;
            // 
            // rtxtAbstract
            // 
            this.rtxtAbstract.Location = new System.Drawing.Point(54, 286);
            this.rtxtAbstract.Name = "rtxtAbstract";
            this.rtxtAbstract.Size = new System.Drawing.Size(502, 96);
            this.rtxtAbstract.TabIndex = 11;
            this.rtxtAbstract.Text = "";
            // 
            // lblAbstract
            // 
            this.lblAbstract.AutoSize = true;
            this.lblAbstract.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAbstract.Location = new System.Drawing.Point(246, 260);
            this.lblAbstract.Name = "lblAbstract";
            this.lblAbstract.Size = new System.Drawing.Size(117, 23);
            this.lblAbstract.TabIndex = 37;
            this.lblAbstract.Text = "Abstract(*)";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYear.Location = new System.Drawing.Point(704, 195);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(79, 23);
            this.lblYear.TabIndex = 39;
            this.lblYear.Text = "Year(*)";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(633, 221);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(206, 22);
            this.txtYear.TabIndex = 9;
            // 
            // lblNumberOP
            // 
            this.lblNumberOP.AutoSize = true;
            this.lblNumberOP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumberOP.Location = new System.Drawing.Point(647, 270);
            this.lblNumberOP.Name = "lblNumberOP";
            this.lblNumberOP.Size = new System.Drawing.Size(195, 23);
            this.lblNumberOP.TabIndex = 41;
            this.lblNumberOP.Text = "Number of Page(*)";
            // 
            // txtNumberOP
            // 
            this.txtNumberOP.Location = new System.Drawing.Point(633, 296);
            this.txtNumberOP.Name = "txtNumberOP";
            this.txtNumberOP.Size = new System.Drawing.Size(206, 22);
            this.txtNumberOP.TabIndex = 10;
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSupervisor.Location = new System.Drawing.Point(680, 38);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(131, 23);
            this.lblSupervisor.TabIndex = 43;
            this.lblSupervisor.Text = "Supervisor(*)";
            // 
            // txtSupervisor
            // 
            this.txtSupervisor.Location = new System.Drawing.Point(633, 64);
            this.txtSupervisor.Name = "txtSupervisor";
            this.txtSupervisor.Size = new System.Drawing.Size(206, 22);
            this.txtSupervisor.TabIndex = 7;
            // 
            // lblCoSupervisor
            // 
            this.lblCoSupervisor.AutoSize = true;
            this.lblCoSupervisor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCoSupervisor.Location = new System.Drawing.Point(662, 113);
            this.lblCoSupervisor.Name = "lblCoSupervisor";
            this.lblCoSupervisor.Size = new System.Drawing.Size(137, 23);
            this.lblCoSupervisor.TabIndex = 45;
            this.lblCoSupervisor.Text = "CoSupervisor";
            // 
            // txtCoSupervisor
            // 
            this.txtCoSupervisor.Location = new System.Drawing.Point(633, 139);
            this.txtCoSupervisor.Name = "txtCoSupervisor";
            this.txtCoSupervisor.Size = new System.Drawing.Size(206, 22);
            this.txtCoSupervisor.TabIndex = 8;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(336, 64);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(206, 31);
            this.cmbLanguage.TabIndex = 4;
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(336, 139);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(206, 31);
            this.cmbType.TabIndex = 5;
            // 
            // cmbUniversity
            // 
            this.cmbUniversity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUniversity.FormattingEnabled = true;
            this.cmbUniversity.Location = new System.Drawing.Point(54, 139);
            this.cmbUniversity.Name = "cmbUniversity";
            this.cmbUniversity.Size = new System.Drawing.Size(206, 31);
            this.cmbUniversity.TabIndex = 2;
            this.cmbUniversity.SelectedIndexChanged += new System.EventHandler(this.cmbUniversity_SelectedIndexChanged);
            // 
            // cmbInstitute
            // 
            this.cmbInstitute.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbInstitute.FormattingEnabled = true;
            this.cmbInstitute.Location = new System.Drawing.Point(54, 221);
            this.cmbInstitute.Name = "cmbInstitute";
            this.cmbInstitute.Size = new System.Drawing.Size(206, 31);
            this.cmbInstitute.TabIndex = 3;
            this.cmbInstitute.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbInstitute_MouseClick);
            // 
            // cmbTopic
            // 
            this.cmbTopic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTopic.FormattingEnabled = true;
            this.cmbTopic.ItemHeight = 23;
            this.cmbTopic.Items.AddRange(new object[] {
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
            this.cmbTopic.Location = new System.Drawing.Point(636, 365);
            this.cmbTopic.Name = "cmbTopic";
            this.cmbTopic.Size = new System.Drawing.Size(206, 31);
            this.cmbTopic.TabIndex = 12;
            //this.cmbTopic.SelectedIndexChanged += new System.EventHandler(this.cmbTopic_SelectedIndexChanged);
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopic.Location = new System.Drawing.Point(704, 339);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(84, 23);
            this.lblTopic.TabIndex = 47;
            this.lblTopic.Text = "Topic(*)";
            // 
            // frmAddNewThesis
            // 
            this.AcceptButton = this.btnAddThesis;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 543);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.cmbTopic);
            this.Controls.Add(this.cmbInstitute);
            this.Controls.Add(this.cmbUniversity);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.lblCoSupervisor);
            this.Controls.Add(this.txtCoSupervisor);
            this.Controls.Add(this.lblSupervisor);
            this.Controls.Add(this.txtSupervisor);
            this.Controls.Add(this.lblNumberOP);
            this.Controls.Add(this.txtNumberOP);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblAbstract);
            this.Controls.Add(this.rtxtAbstract);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblInstitute);
            this.Controls.Add(this.lblUniversity);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.btnAddThesis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNewThesis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewThesis";
            this.Load += new System.EventHandler(this.frmAddNewThesis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddThesis;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label lblUniversity;
        private System.Windows.Forms.Label lblInstitute;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RichTextBox rtxtAbstract;
        private System.Windows.Forms.Label lblAbstract;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblNumberOP;
        private System.Windows.Forms.TextBox txtNumberOP;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.TextBox txtSupervisor;
        private System.Windows.Forms.Label lblCoSupervisor;
        private System.Windows.Forms.TextBox txtCoSupervisor;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbUniversity;
        private System.Windows.Forms.ComboBox cmbInstitute;
        private System.Windows.Forms.ComboBox cmbTopic;
        private System.Windows.Forms.Label lblTopic;
    }
}