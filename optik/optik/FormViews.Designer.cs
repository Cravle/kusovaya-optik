
namespace optik
{
    partial class FormViews
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonToDopInfo = new System.Windows.Forms.Button();
            this.buttonToOrdersManagers = new System.Windows.Forms.Button();
            this.buttonToProdSec = new System.Windows.Forms.Button();
            this.buttonProductsThou = new System.Windows.Forms.Button();
            this.buttoManagersInKh = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Представления";
            // 
            // buttonToDopInfo
            // 
            this.buttonToDopInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToDopInfo.Location = new System.Drawing.Point(108, 75);
            this.buttonToDopInfo.Name = "buttonToDopInfo";
            this.buttonToDopInfo.Size = new System.Drawing.Size(595, 69);
            this.buttonToDopInfo.TabIndex = 1;
            this.buttonToDopInfo.Text = "о дополенной информации о деталях заказа";
            this.buttonToDopInfo.UseVisualStyleBackColor = true;
            this.buttonToDopInfo.Click += new System.EventHandler(this.buttonToDopInfo_Click);
            // 
            // buttonToOrdersManagers
            // 
            this.buttonToOrdersManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToOrdersManagers.Location = new System.Drawing.Point(108, 150);
            this.buttonToOrdersManagers.Name = "buttonToOrdersManagers";
            this.buttonToOrdersManagers.Size = new System.Drawing.Size(595, 69);
            this.buttonToOrdersManagers.TabIndex = 1;
            this.buttonToOrdersManagers.Text = "о заказах и их менеджеров и их должностях";
            this.buttonToOrdersManagers.UseVisualStyleBackColor = true;
            this.buttonToOrdersManagers.Click += new System.EventHandler(this.buttonToOrdersManagers_Click);
            // 
            // buttonToProdSec
            // 
            this.buttonToProdSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToProdSec.Location = new System.Drawing.Point(108, 225);
            this.buttonToProdSec.Name = "buttonToProdSec";
            this.buttonToProdSec.Size = new System.Drawing.Size(595, 69);
            this.buttonToProdSec.TabIndex = 1;
            this.buttonToProdSec.Text = "о товарах 2й категории";
            this.buttonToProdSec.UseVisualStyleBackColor = true;
            this.buttonToProdSec.Click += new System.EventHandler(this.buttonToProdSec_Click);
            // 
            // buttonProductsThou
            // 
            this.buttonProductsThou.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProductsThou.Location = new System.Drawing.Point(108, 303);
            this.buttonProductsThou.Name = "buttonProductsThou";
            this.buttonProductsThou.Size = new System.Drawing.Size(595, 69);
            this.buttonProductsThou.TabIndex = 1;
            this.buttonProductsThou.Text = "о товараха больше 1000грн купленных в 1м магазине";
            this.buttonProductsThou.UseVisualStyleBackColor = true;
            this.buttonProductsThou.Click += new System.EventHandler(this.buttonProductsThou_Click);
            // 
            // buttoManagersInKh
            // 
            this.buttoManagersInKh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttoManagersInKh.Location = new System.Drawing.Point(108, 382);
            this.buttoManagersInKh.Name = "buttoManagersInKh";
            this.buttoManagersInKh.Size = new System.Drawing.Size(595, 69);
            this.buttoManagersInKh.TabIndex = 1;
            this.buttoManagersInKh.Text = " о менеджерах в Харькове";
            this.buttoManagersInKh.UseVisualStyleBackColor = true;
            this.buttoManagersInKh.Click += new System.EventHandler(this.buttoManagersInKh_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(278, 517);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(243, 50);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 595);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttoManagersInKh);
            this.Controls.Add(this.buttonProductsThou);
            this.Controls.Add(this.buttonToProdSec);
            this.Controls.Add(this.buttonToOrdersManagers);
            this.Controls.Add(this.buttonToDopInfo);
            this.Controls.Add(this.label1);
            this.Name = "FormViews";
            this.Text = "FormViews";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonToDopInfo;
        private System.Windows.Forms.Button buttonToOrdersManagers;
        private System.Windows.Forms.Button buttonToProdSec;
        private System.Windows.Forms.Button buttonProductsThou;
        private System.Windows.Forms.Button buttoManagersInKh;
        private System.Windows.Forms.Button buttonBack;
    }
}