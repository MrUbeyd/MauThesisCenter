
namespace MauThesisCenter
{
    partial class frmLastTheses
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtLastTheses = new System.Windows.Forms.DataGridView();
            this.mauThesisCenterDataSet = new MauThesisCenter.MauThesisCenterDataSet();
            this.mauThesisCenterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLTHESISBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_THESISTableAdapter = new MauThesisCenter.MauThesisCenterDataSetTableAdapters.TBL_THESISTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtLastTheses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mauThesisCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mauThesisCenterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTHESISBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtLastTheses
            // 
            this.dtLastTheses.AllowUserToAddRows = false;
            this.dtLastTheses.AllowUserToDeleteRows = false;
            this.dtLastTheses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtLastTheses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtLastTheses.BackgroundColor = System.Drawing.Color.White;
            this.dtLastTheses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtLastTheses.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtLastTheses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtLastTheses.Location = new System.Drawing.Point(0, 0);
            this.dtLastTheses.Name = "dtLastTheses";
            this.dtLastTheses.ReadOnly = true;
            this.dtLastTheses.RowHeadersWidth = 51;
            this.dtLastTheses.RowTemplate.Height = 24;
            this.dtLastTheses.Size = new System.Drawing.Size(1009, 601);
            this.dtLastTheses.TabIndex = 25;
            // 
            // mauThesisCenterDataSet
            // 
            this.mauThesisCenterDataSet.DataSetName = "MauThesisCenterDataSet";
            this.mauThesisCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mauThesisCenterDataSetBindingSource
            // 
            this.mauThesisCenterDataSetBindingSource.DataSource = this.mauThesisCenterDataSet;
            this.mauThesisCenterDataSetBindingSource.Position = 0;
            // 
            // tBLTHESISBindingSource
            // 
            this.tBLTHESISBindingSource.DataMember = "TBL_THESIS";
            this.tBLTHESISBindingSource.DataSource = this.mauThesisCenterDataSet;
            // 
            // tBL_THESISTableAdapter
            // 
            this.tBL_THESISTableAdapter.ClearBeforeFill = true;
            // 
            // frmLastTheses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 601);
            this.Controls.Add(this.dtLastTheses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLastTheses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLastTheses";
            this.Load += new System.EventHandler(this.frmLastTheses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtLastTheses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mauThesisCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mauThesisCenterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTHESISBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtLastTheses;
        private System.Windows.Forms.BindingSource mauThesisCenterDataSetBindingSource;
        private MauThesisCenterDataSet mauThesisCenterDataSet;
        private System.Windows.Forms.BindingSource tBLTHESISBindingSource;
        private MauThesisCenterDataSetTableAdapters.TBL_THESISTableAdapter tBL_THESISTableAdapter;
    }
}