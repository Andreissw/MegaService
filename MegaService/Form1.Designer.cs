
namespace MegaService
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBSN = new System.Windows.Forms.TextBox();
            this.GridInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBinfo = new System.Windows.Forms.GroupBox();
            this.InfoOTKTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProblemLB = new System.Windows.Forms.Label();
            this.GBSetInfo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OTK_Desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBCulprit = new System.Windows.Forms.ComboBox();
            this.LBSuccess = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridInfo)).BeginInit();
            this.GBinfo.SuspendLayout();
            this.GBSetInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.LBError);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBSN);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(474, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // LBError
            // 
            this.LBError.AutoSize = true;
            this.LBError.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBError.ForeColor = System.Drawing.Color.Red;
            this.LBError.Location = new System.Drawing.Point(9, 71);
            this.LBError.Name = "LBError";
            this.LBError.Size = new System.Drawing.Size(46, 16);
            this.LBError.TabIndex = 7;
            this.LBError.Text = "label2";
            this.LBError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите SN";
            // 
            // TBSN
            // 
            this.TBSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBSN.Location = new System.Drawing.Point(8, 40);
            this.TBSN.Margin = new System.Windows.Forms.Padding(4);
            this.TBSN.Name = "TBSN";
            this.TBSN.Size = new System.Drawing.Size(455, 29);
            this.TBSN.TabIndex = 0;
            this.TBSN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBSN_KeyDown);
            // 
            // GridInfo
            // 
            this.GridInfo.AllowUserToAddRows = false;
            this.GridInfo.AllowUserToDeleteRows = false;
            this.GridInfo.AllowUserToResizeColumns = false;
            this.GridInfo.AllowUserToResizeRows = false;
            this.GridInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInfo.ColumnHeadersVisible = false;
            this.GridInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.GridInfo.Location = new System.Drawing.Point(7, 20);
            this.GridInfo.Name = "GridInfo";
            this.GridInfo.ReadOnly = true;
            this.GridInfo.RowHeadersVisible = false;
            this.GridInfo.Size = new System.Drawing.Size(877, 107);
            this.GridInfo.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 5;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 5;
            // 
            // GBinfo
            // 
            this.GBinfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GBinfo.Controls.Add(this.InfoOTKTB);
            this.GBinfo.Controls.Add(this.label6);
            this.GBinfo.Controls.Add(this.label3);
            this.GBinfo.Controls.Add(this.ProblemLB);
            this.GBinfo.Controls.Add(this.GridInfo);
            this.GBinfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GBinfo.Location = new System.Drawing.Point(495, 11);
            this.GBinfo.Margin = new System.Windows.Forms.Padding(4);
            this.GBinfo.Name = "GBinfo";
            this.GBinfo.Padding = new System.Windows.Forms.Padding(4);
            this.GBinfo.Size = new System.Drawing.Size(891, 662);
            this.GBinfo.TabIndex = 6;
            this.GBinfo.TabStop = false;
            this.GBinfo.Text = "Информация со стороны Клиента";
            this.GBinfo.Visible = false;
            // 
            // InfoOTKTB
            // 
            this.InfoOTKTB.Location = new System.Drawing.Point(11, 298);
            this.InfoOTKTB.Multiline = true;
            this.InfoOTKTB.Name = "InfoOTKTB";
            this.InfoOTKTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InfoOTKTB.Size = new System.Drawing.Size(864, 357);
            this.InfoOTKTB.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Проблема со слов ОТК";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Проблема со слов клиента";
            // 
            // ProblemLB
            // 
            this.ProblemLB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProblemLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProblemLB.Location = new System.Drawing.Point(7, 149);
            this.ProblemLB.Name = "ProblemLB";
            this.ProblemLB.Size = new System.Drawing.Size(877, 121);
            this.ProblemLB.TabIndex = 6;
            // 
            // GBSetInfo
            // 
            this.GBSetInfo.Controls.Add(this.button1);
            this.GBSetInfo.Controls.Add(this.label4);
            this.GBSetInfo.Controls.Add(this.OTK_Desc);
            this.GBSetInfo.Controls.Add(this.label2);
            this.GBSetInfo.Controls.Add(this.CBCulprit);
            this.GBSetInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GBSetInfo.Location = new System.Drawing.Point(13, 109);
            this.GBSetInfo.Name = "GBSetInfo";
            this.GBSetInfo.Size = new System.Drawing.Size(474, 410);
            this.GBSetInfo.TabIndex = 7;
            this.GBSetInfo.TabStop = false;
            this.GBSetInfo.Text = "Окно ввода";
            this.GBSetInfo.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(8, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(462, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сохранить результат";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Введите описание тестирования";
            // 
            // OTK_Desc
            // 
            this.OTK_Desc.Location = new System.Drawing.Point(10, 38);
            this.OTK_Desc.MaxLength = 1000;
            this.OTK_Desc.Multiline = true;
            this.OTK_Desc.Name = "OTK_Desc";
            this.OTK_Desc.Size = new System.Drawing.Size(451, 263);
            this.OTK_Desc.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выберите виновника";
            // 
            // CBCulprit
            // 
            this.CBCulprit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCulprit.FormattingEnabled = true;
            this.CBCulprit.Items.AddRange(new object[] {
            "Завод",
            "Поставщик"});
            this.CBCulprit.Location = new System.Drawing.Point(9, 333);
            this.CBCulprit.Name = "CBCulprit";
            this.CBCulprit.Size = new System.Drawing.Size(147, 24);
            this.CBCulprit.TabIndex = 0;
            this.CBCulprit.SelectionChangeCommitted += new System.EventHandler(this.CBCulprit_SelectionChangeCommitted);
            // 
            // LBSuccess
            // 
            this.LBSuccess.BackColor = System.Drawing.Color.Azure;
            this.LBSuccess.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBSuccess.Location = new System.Drawing.Point(16, 532);
            this.LBSuccess.Name = "LBSuccess";
            this.LBSuccess.Size = new System.Drawing.Size(266, 32);
            this.LBSuccess.TabIndex = 8;
            this.LBSuccess.Text = "Сохранено успешно!";
            this.LBSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBSuccess.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 686);
            this.Controls.Add(this.LBSuccess);
            this.Controls.Add(this.GBSetInfo);
            this.Controls.Add(this.GBinfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridInfo)).EndInit();
            this.GBinfo.ResumeLayout(false);
            this.GBinfo.PerformLayout();
            this.GBSetInfo.ResumeLayout(false);
            this.GBSetInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBSN;
        private System.Windows.Forms.DataGridView GridInfo;
        private System.Windows.Forms.GroupBox GBinfo;
        private System.Windows.Forms.Label LBError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ProblemLB;
        private System.Windows.Forms.GroupBox GBSetInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OTK_Desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBCulprit;
        private System.Windows.Forms.Label LBSuccess;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InfoOTKTB;
    }
}

