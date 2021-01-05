
namespace MauThesisCenter
{
    partial class frmUpdateEditData
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
            this.btnUniversities = new System.Windows.Forms.Button();
            this.btnInstitutes = new System.Windows.Forms.Button();
            this.btnLanguages = new System.Windows.Forms.Button();
            this.btnTypes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUniversities
            // 
            this.btnUniversities.Location = new System.Drawing.Point(87, 48);
            this.btnUniversities.Name = "btnUniversities";
            this.btnUniversities.Size = new System.Drawing.Size(146, 78);
            this.btnUniversities.TabIndex = 0;
            this.btnUniversities.Text = "Edit Universities";
            this.btnUniversities.UseVisualStyleBackColor = true;
            this.btnUniversities.Click += new System.EventHandler(this.btnUniversities_Click);
            // 
            // btnInstitutes
            // 
            this.btnInstitutes.Location = new System.Drawing.Point(87, 163);
            this.btnInstitutes.Name = "btnInstitutes";
            this.btnInstitutes.Size = new System.Drawing.Size(146, 78);
            this.btnInstitutes.TabIndex = 1;
            this.btnInstitutes.Text = "Edit Institutes";
            this.btnInstitutes.UseVisualStyleBackColor = true;
            this.btnInstitutes.Click += new System.EventHandler(this.btnInstitutes_Click);
            // 
            // btnLanguages
            // 
            this.btnLanguages.Location = new System.Drawing.Point(333, 48);
            this.btnLanguages.Name = "btnLanguages";
            this.btnLanguages.Size = new System.Drawing.Size(146, 78);
            this.btnLanguages.TabIndex = 2;
            this.btnLanguages.Text = "Edit Languages";
            this.btnLanguages.UseVisualStyleBackColor = true;
            this.btnLanguages.Click += new System.EventHandler(this.btnLanguages_Click);
            // 
            // btnTypes
            // 
            this.btnTypes.Location = new System.Drawing.Point(333, 163);
            this.btnTypes.Name = "btnTypes";
            this.btnTypes.Size = new System.Drawing.Size(146, 78);
            this.btnTypes.TabIndex = 3;
            this.btnTypes.Text = "Edit Types";
            this.btnTypes.UseVisualStyleBackColor = true;
            this.btnTypes.Click += new System.EventHandler(this.btnTypes_Click);
            // 
            // frmUpdateEditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 629);
            this.Controls.Add(this.btnTypes);
            this.Controls.Add(this.btnLanguages);
            this.Controls.Add(this.btnInstitutes);
            this.Controls.Add(this.btnUniversities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateEditData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateEditData";
            this.Load += new System.EventHandler(this.frmUpdateEditData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUniversities;
        private System.Windows.Forms.Button btnInstitutes;
        private System.Windows.Forms.Button btnLanguages;
        private System.Windows.Forms.Button btnTypes;
    }
}