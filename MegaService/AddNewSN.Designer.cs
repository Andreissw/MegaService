
namespace MegaService
{
    partial class AddNewSN
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
            this.label2 = new System.Windows.Forms.Label();
            this.CBProduct = new System.Windows.Forms.ComboBox();
            this.CBName = new System.Windows.Forms.ComboBox();
            this.defect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BTOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя продукта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя заказчика";
            // 
            // CBProduct
            // 
            this.CBProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBProduct.DropDownHeight = 500;
            this.CBProduct.DropDownWidth = 500;
            this.CBProduct.FormattingEnabled = true;
            this.CBProduct.IntegralHeight = false;
            this.CBProduct.Location = new System.Drawing.Point(133, 29);
            this.CBProduct.Name = "CBProduct";
            this.CBProduct.Size = new System.Drawing.Size(339, 21);
            this.CBProduct.TabIndex = 4;
            // 
            // CBName
            // 
            this.CBName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBName.DropDownHeight = 500;
            this.CBName.DropDownWidth = 500;
            this.CBName.FormattingEnabled = true;
            this.CBName.IntegralHeight = false;
            this.CBName.Location = new System.Drawing.Point(133, 58);
            this.CBName.Name = "CBName";
            this.CBName.Size = new System.Drawing.Size(339, 21);
            this.CBName.TabIndex = 5;
            // 
            // defect
            // 
            this.defect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.defect.DropDownHeight = 500;
            this.defect.DropDownWidth = 500;
            this.defect.FormattingEnabled = true;
            this.defect.IntegralHeight = false;
            this.defect.Location = new System.Drawing.Point(233, 91);
            this.defect.Name = "defect";
            this.defect.Size = new System.Drawing.Size(239, 21);
            this.defect.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Проблема со слов клиента";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(193, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BTOk
            // 
            this.BTOk.BackColor = System.Drawing.Color.GreenYellow;
            this.BTOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BTOk.Location = new System.Drawing.Point(12, 118);
            this.BTOk.Name = "BTOk";
            this.BTOk.Size = new System.Drawing.Size(175, 44);
            this.BTOk.TabIndex = 8;
            this.BTOk.Text = "ОК";
            this.BTOk.UseVisualStyleBackColor = false;
            this.BTOk.Click += new System.EventHandler(this.BTOk_Click);
            // 
            // AddNewSN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(494, 174);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTOk);
            this.Controls.Add(this.defect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBName);
            this.Controls.Add(this.CBProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewSN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewSN";
            this.Load += new System.EventHandler(this.AddNewSN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBProduct;
        private System.Windows.Forms.ComboBox CBName;
        private System.Windows.Forms.ComboBox defect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTOk;
    }
}