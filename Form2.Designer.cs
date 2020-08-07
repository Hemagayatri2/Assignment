namespace loginform
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankingDataSet = new loginform.bankingDataSet();
            this.table_1TableAdapter = new loginform.bankingDataSetTableAdapters.Table_1TableAdapter();
            this.bankingDataSet1 = new loginform.bankingDataSet1();
            this.table1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.table_1TableAdapter1 = new loginform.bankingDataSet1TableAdapters.Table_1TableAdapter();
            this.bank_detailsDataSet = new loginform.bank_detailsDataSet();
            this.accholderdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acc_holder_detailsTableAdapter = new loginform.bank_detailsDataSetTableAdapters.acc_holder_detailsTableAdapter();
            this.accountidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_detailsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accholderdetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountidDataGridViewTextBoxColumn,
            this.accountnameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accholderdetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(236, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.bankingDataSet;
            // 
            // bankingDataSet
            // 
            this.bankingDataSet.DataSetName = "bankingDataSet";
            this.bankingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // bankingDataSet1
            // 
            this.bankingDataSet1.DataSetName = "bankingDataSet1";
            this.bankingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource1
            // 
            this.table1BindingSource1.DataMember = "Table_1";
            this.table1BindingSource1.DataSource = this.bankingDataSet1;
            // 
            // table_1TableAdapter1
            // 
            this.table_1TableAdapter1.ClearBeforeFill = true;
            // 
            // bank_detailsDataSet
            // 
            this.bank_detailsDataSet.DataSetName = "bank_detailsDataSet";
            this.bank_detailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accholderdetailsBindingSource
            // 
            this.accholderdetailsBindingSource.DataMember = "acc_holder_details";
            this.accholderdetailsBindingSource.DataSource = this.bank_detailsDataSet;
            // 
            // acc_holder_detailsTableAdapter
            // 
            this.acc_holder_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // accountidDataGridViewTextBoxColumn
            // 
            this.accountidDataGridViewTextBoxColumn.DataPropertyName = "Account_id";
            this.accountidDataGridViewTextBoxColumn.HeaderText = "Account_id";
            this.accountidDataGridViewTextBoxColumn.Name = "accountidDataGridViewTextBoxColumn";
            // 
            // accountnameDataGridViewTextBoxColumn
            // 
            this.accountnameDataGridViewTextBoxColumn.DataPropertyName = "Account_name";
            this.accountnameDataGridViewTextBoxColumn.HeaderText = "Account_name";
            this.accountnameDataGridViewTextBoxColumn.Name = "accountnameDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_detailsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accholderdetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bankingDataSet bankingDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private bankingDataSetTableAdapters.Table_1TableAdapter table_1TableAdapter;
        private bankingDataSet1 bankingDataSet1;
        private System.Windows.Forms.BindingSource table1BindingSource1;
        private bankingDataSet1TableAdapters.Table_1TableAdapter table_1TableAdapter1;
        private bank_detailsDataSet bank_detailsDataSet;
        private System.Windows.Forms.BindingSource accholderdetailsBindingSource;
        private bank_detailsDataSetTableAdapters.acc_holder_detailsTableAdapter acc_holder_detailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
    }
}