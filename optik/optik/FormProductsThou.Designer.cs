
namespace optik
{
    partial class FormProductsThou
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
            this.prodBiggerInFirstShopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodBiggerInFirstShopTableAdapter = new optik.optikDataSetTableAdapters.ProdBiggerInFirstShopTableAdapter();
            this.nazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodBiggerInFirstShopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(376, 388);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(243, 50);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazDataGridViewTextBoxColumn,
            this.kategoryIDDataGridViewTextBoxColumn,
            this.countsDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.shopIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prodBiggerInFirstShopBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(904, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // optikDataSet
            // 
            this.optikDataSet.DataSetName = "optikDataSet";
            this.optikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodBiggerInFirstShopBindingSource
            // 
            this.prodBiggerInFirstShopBindingSource.DataMember = "ProdBiggerInFirstShop";
            this.prodBiggerInFirstShopBindingSource.DataSource = this.optikDataSet;
            // 
            // prodBiggerInFirstShopTableAdapter
            // 
            this.prodBiggerInFirstShopTableAdapter.ClearBeforeFill = true;
            // 
            // nazDataGridViewTextBoxColumn
            // 
            this.nazDataGridViewTextBoxColumn.DataPropertyName = "Naz";
            this.nazDataGridViewTextBoxColumn.HeaderText = "Naz";
            this.nazDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazDataGridViewTextBoxColumn.Name = "nazDataGridViewTextBoxColumn";
            this.nazDataGridViewTextBoxColumn.Width = 125;
            // 
            // kategoryIDDataGridViewTextBoxColumn
            // 
            this.kategoryIDDataGridViewTextBoxColumn.DataPropertyName = "KategoryID";
            this.kategoryIDDataGridViewTextBoxColumn.HeaderText = "KategoryID";
            this.kategoryIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kategoryIDDataGridViewTextBoxColumn.Name = "kategoryIDDataGridViewTextBoxColumn";
            this.kategoryIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // countsDataGridViewTextBoxColumn
            // 
            this.countsDataGridViewTextBoxColumn.DataPropertyName = "Counts";
            this.countsDataGridViewTextBoxColumn.HeaderText = "Counts";
            this.countsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countsDataGridViewTextBoxColumn.Name = "countsDataGridViewTextBoxColumn";
            this.countsDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // shopIDDataGridViewTextBoxColumn
            // 
            this.shopIDDataGridViewTextBoxColumn.DataPropertyName = "ShopID";
            this.shopIDDataGridViewTextBoxColumn.HeaderText = "ShopID";
            this.shopIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shopIDDataGridViewTextBoxColumn.Name = "shopIDDataGridViewTextBoxColumn";
            this.shopIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormProductsThou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormProductsThou";
            this.Text = "FormProductsThou";
            this.Load += new System.EventHandler(this.FormProductsThou_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodBiggerInFirstShopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private optikDataSet optikDataSet;
        private System.Windows.Forms.BindingSource prodBiggerInFirstShopBindingSource;
        private optikDataSetTableAdapters.ProdBiggerInFirstShopTableAdapter prodBiggerInFirstShopTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopIDDataGridViewTextBoxColumn;
    }
}