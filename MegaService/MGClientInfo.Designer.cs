
namespace MegaService
{
    partial class MGClientInfo
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
            this.CBProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBName = new System.Windows.Forms.ComboBox();
            this.BTOk = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NumDoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите Имя продукта и имя заказчика";
            // 
            // CBProduct
            // 
            this.CBProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBProduct.DropDownHeight = 500;
            this.CBProduct.DropDownWidth = 500;
            this.CBProduct.FormattingEnabled = true;
            this.CBProduct.IntegralHeight = false;
            this.CBProduct.Location = new System.Drawing.Point(156, 44);
            this.CBProduct.Name = "CBProduct";
            this.CBProduct.Size = new System.Drawing.Size(216, 21);
            this.CBProduct.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя продукта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя заказчика";
            // 
            // CBName
            // 
            this.CBName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBName.DropDownHeight = 1200;
            this.CBName.DropDownWidth = 12000;
            this.CBName.FormattingEnabled = true;
            this.CBName.IntegralHeight = false;
            this.CBName.Location = new System.Drawing.Point(156, 75);
            this.CBName.Name = "CBName";
            this.CBName.Size = new System.Drawing.Size(216, 21);
            this.CBName.TabIndex = 3;
            // 
            // BTOk
            // 
            this.BTOk.BackColor = System.Drawing.Color.GreenYellow;
            this.BTOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BTOk.Location = new System.Drawing.Point(16, 148);
            this.BTOk.Name = "BTOk";
            this.BTOk.Size = new System.Drawing.Size(175, 44);
            this.BTOk.TabIndex = 5;
            this.BTOk.Text = "ОК";
            this.BTOk.UseVisualStyleBackColor = false;
            this.BTOk.Click += new System.EventHandler(this.BTOk_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(209, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Номер накладной";
            // 
            // NumDoc
            // 
            this.NumDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NumDoc.DropDownHeight = 1200;
            this.NumDoc.DropDownWidth = 12000;
            this.NumDoc.FormattingEnabled = true;
            this.NumDoc.IntegralHeight = false;
            this.NumDoc.Location = new System.Drawing.Point(156, 102);
            this.NumDoc.Name = "NumDoc";
            this.NumDoc.Size = new System.Drawing.Size(216, 21);
            this.NumDoc.TabIndex = 8;
            // 
            // MGClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 204);
            this.Controls.Add(this.NumDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBProduct);
            this.Controls.Add(this.label1);
            this.Name = "MGClientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MGClientInfo";
            this.Load += new System.EventHandler(this.MGClientInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBName;
        private System.Windows.Forms.Button BTOk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox NumDoc;
    }
}