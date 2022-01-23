
namespace Gestion_Usine
{
    partial class SaisieProduction
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usineDataSet = new Gestion_Usine.UsineDataSet();
            this.wproductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wproductionTableAdapter = new Gestion_Usine.UsineDataSetTableAdapters.wproductionTableAdapter();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wproductionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 208);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDataGridViewTextBoxColumn,
            this.dPDataGridViewTextBoxColumn,
            this.matDataGridViewTextBoxColumn,
            this.nPDataGridViewTextBoxColumn,
            this.codeaDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.qpDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wproductionBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // usineDataSet
            // 
            this.usineDataSet.DataSetName = "UsineDataSet";
            this.usineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wproductionBindingSource
            // 
            this.wproductionBindingSource.DataMember = "wproduction";
            this.wproductionBindingSource.DataSource = this.usineDataSet;
            // 
            // wproductionTableAdapter
            // 
            this.wproductionTableAdapter.ClearBeforeFill = true;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "#Numéro";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // dPDataGridViewTextBoxColumn
            // 
            this.dPDataGridViewTextBoxColumn.DataPropertyName = "DP";
            this.dPDataGridViewTextBoxColumn.HeaderText = "Date de Production";
            this.dPDataGridViewTextBoxColumn.Name = "dPDataGridViewTextBoxColumn";
            // 
            // matDataGridViewTextBoxColumn
            // 
            this.matDataGridViewTextBoxColumn.DataPropertyName = "Mat";
            this.matDataGridViewTextBoxColumn.HeaderText = "Matricule d\'employé";
            this.matDataGridViewTextBoxColumn.Name = "matDataGridViewTextBoxColumn";
            // 
            // nPDataGridViewTextBoxColumn
            // 
            this.nPDataGridViewTextBoxColumn.DataPropertyName = "NP";
            this.nPDataGridViewTextBoxColumn.HeaderText = "NP";
            this.nPDataGridViewTextBoxColumn.Name = "nPDataGridViewTextBoxColumn";
            // 
            // codeaDataGridViewTextBoxColumn
            // 
            this.codeaDataGridViewTextBoxColumn.DataPropertyName = "codea";
            this.codeaDataGridViewTextBoxColumn.HeaderText = "Code d\'article";
            this.codeaDataGridViewTextBoxColumn.Name = "codeaDataGridViewTextBoxColumn";
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Désignation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            // 
            // qpDataGridViewTextBoxColumn
            // 
            this.qpDataGridViewTextBoxColumn.DataPropertyName = "qp";
            this.qpDataGridViewTextBoxColumn.HeaderText = "Quantité";
            this.qpDataGridViewTextBoxColumn.Name = "qpDataGridViewTextBoxColumn";
            // 
            // SaisieProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.panel1);
            this.Name = "SaisieProduction";
            this.Text = "Saisie de la production";
            this.Load += new System.EventHandler(this.SaisieProduction_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wproductionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UsineDataSet usineDataSet;
        private System.Windows.Forms.BindingSource wproductionBindingSource;
        private UsineDataSetTableAdapters.wproductionTableAdapter wproductionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qpDataGridViewTextBoxColumn;
    }
}