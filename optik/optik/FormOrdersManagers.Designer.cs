
namespace optik
{
    partial class FormOrdersManagers
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.optikDataSet = new optik.optikDataSet();
            this.managersAndOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managersAndOrdersTableAdapter = new optik.optikDataSetTableAdapters.ManagersAndOrdersTableAdapter();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.famDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inizDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managersAndOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(504, 388);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(243, 50);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.datDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.famDataGridViewTextBoxColumn,
            this.inizDataGridViewTextBoxColumn,
            this.nazDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.managersAndOrdersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1124, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // optikDataSet
            // 
            this.optikDataSet.DataSetName = "optikDataSet";
            this.optikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managersAndOrdersBindingSource
            // 
            this.managersAndOrdersBindingSource.DataMember = "ManagersAndOrders";
            this.managersAndOrdersBindingSource.DataSource = this.optikDataSet;
            // 
            // managersAndOrdersTableAdapter
            // 
            this.managersAndOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // datDataGridViewTextBoxColumn
            // 
            this.datDataGridViewTextBoxColumn.DataPropertyName = "Dat";
            this.datDataGridViewTextBoxColumn.HeaderText = "Dat";
            this.datDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datDataGridViewTextBoxColumn.Name = "datDataGridViewTextBoxColumn";
            this.datDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // famDataGridViewTextBoxColumn
            // 
            this.famDataGridViewTextBoxColumn.DataPropertyName = "Fam";
            this.famDataGridViewTextBoxColumn.HeaderText = "Fam";
            this.famDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.famDataGridViewTextBoxColumn.Name = "famDataGridViewTextBoxColumn";
            this.famDataGridViewTextBoxColumn.Width = 125;
            // 
            // inizDataGridViewTextBoxColumn
            // 
            this.inizDataGridViewTextBoxColumn.DataPropertyName = "Iniz";
            this.inizDataGridViewTextBoxColumn.HeaderText = "Iniz";
            this.inizDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inizDataGridViewTextBoxColumn.Name = "inizDataGridViewTextBoxColumn";
            this.inizDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazDataGridViewTextBoxColumn
            // 
            this.nazDataGridViewTextBoxColumn.DataPropertyName = "Naz";
            this.nazDataGridViewTextBoxColumn.HeaderText = "Naz";
            this.nazDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazDataGridViewTextBoxColumn.Name = "nazDataGridViewTextBoxColumn";
            this.nazDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormOrdersManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormOrdersManagers";
            this.Text = "FormOrdersManagers";
            this.Load += new System.EventHandler(this.FormOrdersManagers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managersAndOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private optikDataSet optikDataSet;
        private System.Windows.Forms.BindingSource managersAndOrdersBindingSource;
        private optikDataSetTableAdapters.ManagersAndOrdersTableAdapter managersAndOrdersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn famDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inizDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazDataGridViewTextBoxColumn;
    }
}