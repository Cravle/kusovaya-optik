
namespace optik
{
    partial class Form1
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
            this.optikDataSet1 = new optik.optikDataSet();
            this.optikDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonToTables = new System.Windows.Forms.Button();
            this.buttonToViews = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.optikDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optikDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // optikDataSet1
            // 
            this.optikDataSet1.DataSetName = "optikDataSet";
            this.optikDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // optikDataSet1BindingSource
            // 
            this.optikDataSet1BindingSource.DataSource = this.optikDataSet1;
            this.optikDataSet1BindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "АРМ продавца-консультанта магазина оптики";
            // 
            // buttonToTables
            // 
            this.buttonToTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToTables.Location = new System.Drawing.Point(197, 94);
            this.buttonToTables.Name = "buttonToTables";
            this.buttonToTables.Size = new System.Drawing.Size(245, 65);
            this.buttonToTables.TabIndex = 1;
            this.buttonToTables.Text = "Таблицы";
            this.buttonToTables.UseVisualStyleBackColor = true;
            this.buttonToTables.Click += new System.EventHandler(this.buttonToTables_Click);
            // 
            // buttonToViews
            // 
            this.buttonToViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToViews.Location = new System.Drawing.Point(197, 186);
            this.buttonToViews.Name = "buttonToViews";
            this.buttonToViews.Size = new System.Drawing.Size(245, 65);
            this.buttonToViews.TabIndex = 1;
            this.buttonToViews.Text = "Представления";
            this.buttonToViews.UseVisualStyleBackColor = true;
            this.buttonToViews.Click += new System.EventHandler(this.buttonToViews_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(197, 279);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(245, 63);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 534);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonToViews);
            this.Controls.Add(this.buttonToTables);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.optikDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optikDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private optikDataSet optikDataSet1;
        private System.Windows.Forms.BindingSource optikDataSet1BindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonToTables;
        private System.Windows.Forms.Button buttonToViews;
        private System.Windows.Forms.Button buttonExit;
    }
}

