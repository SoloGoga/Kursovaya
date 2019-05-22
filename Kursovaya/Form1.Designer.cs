namespace Kursovaya
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
            this.Tablitca = new System.Windows.Forms.DataGridView();
            this.FamiliyaBox = new System.Windows.Forms.TextBox();
            this.CardNumberNumeric = new System.Windows.Forms.NumericUpDown();
            this.CostOfWork = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchNameButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchTypeButt = new System.Windows.Forms.Button();
            this.SearchDolgButt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DeleteDolgButt = new System.Windows.Forms.Button();
            this.PassButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.Consol = new System.Windows.Forms.TextBox();
            this.TypeOfWorkBox = new System.Windows.Forms.TextBox();
            this.SearchTypeBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PaymentNumerical = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.NameAndOtchestvo = new System.Windows.Forms.TextBox();
            this.ConsoleClear = new System.Windows.Forms.Button();
            this.ImportButt = new System.Windows.Forms.Button();
            this.ExportButt = new System.Windows.Forms.Button();
            this.ColumnCardNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVidRaboti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOplataCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDolg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tablitca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardNumberNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentNumerical)).BeginInit();
            this.SuspendLayout();
            // 
            // Tablitca
            // 
            this.Tablitca.AllowUserToAddRows = false;
            this.Tablitca.AllowUserToDeleteRows = false;
            this.Tablitca.AllowUserToResizeColumns = false;
            this.Tablitca.AllowUserToResizeRows = false;
            this.Tablitca.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Tablitca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tablitca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCardNum,
            this.ColumnNSS,
            this.ColumnVidRaboti,
            this.ColumnCost,
            this.ColumnOplataCheck,
            this.ColumnDolg,
            this.ColumnDelete});
            this.Tablitca.Location = new System.Drawing.Point(205, 7);
            this.Tablitca.MultiSelect = false;
            this.Tablitca.Name = "Tablitca";
            this.Tablitca.ReadOnly = true;
            this.Tablitca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tablitca.RowHeadersVisible = false;
            this.Tablitca.Size = new System.Drawing.Size(721, 270);
            this.Tablitca.StandardTab = true;
            this.Tablitca.TabIndex = 0;
            this.Tablitca.Visible = false;
            this.Tablitca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tablitca_CellContentClick);
            // 
            // FamiliyaBox
            // 
            this.FamiliyaBox.Location = new System.Drawing.Point(97, 42);
            this.FamiliyaBox.Name = "FamiliyaBox";
            this.FamiliyaBox.Size = new System.Drawing.Size(93, 20);
            this.FamiliyaBox.TabIndex = 2;
            this.FamiliyaBox.Visible = false;
            // 
            // CardNumberNumeric
            // 
            this.CardNumberNumeric.Location = new System.Drawing.Point(98, 7);
            this.CardNumberNumeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.CardNumberNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CardNumberNumeric.Name = "CardNumberNumeric";
            this.CardNumberNumeric.Size = new System.Drawing.Size(92, 20);
            this.CardNumberNumeric.TabIndex = 1;
            this.CardNumberNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CardNumberNumeric.Visible = false;
            // 
            // CostOfWork
            // 
            this.CostOfWork.Location = new System.Drawing.Point(98, 150);
            this.CostOfWork.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CostOfWork.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.CostOfWork.Name = "CostOfWork";
            this.CostOfWork.Size = new System.Drawing.Size(93, 20);
            this.CostOfWork.TabIndex = 5;
            this.CostOfWork.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.CostOfWork.Visible = false;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(10, 227);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(181, 50);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Добавить пациента";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchNameButt
            // 
            this.SearchNameButt.Location = new System.Drawing.Point(118, 312);
            this.SearchNameButt.Name = "SearchNameButt";
            this.SearchNameButt.Size = new System.Drawing.Size(93, 20);
            this.SearchNameButt.TabIndex = 9;
            this.SearchNameButt.Text = "Найти";
            this.SearchNameButt.UseVisualStyleBackColor = true;
            this.SearchNameButt.Visible = false;
            this.SearchNameButt.Click += new System.EventHandler(this.SearchNameButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Фамилия";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Номер карточки";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Вид работы";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Стоимость \r\nработы";
            this.label4.Visible = false;
            // 
            // SearchNameTextBox
            // 
            this.SearchNameTextBox.Location = new System.Drawing.Point(5, 312);
            this.SearchNameTextBox.Name = "SearchNameTextBox";
            this.SearchNameTextBox.Size = new System.Drawing.Size(93, 20);
            this.SearchNameTextBox.TabIndex = 8;
            this.SearchNameTextBox.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Справка о клиенте по ФИО";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Справка о клиенте по виду работы";
            this.label6.Visible = false;
            // 
            // SearchTypeButt
            // 
            this.SearchTypeButt.Location = new System.Drawing.Point(392, 311);
            this.SearchTypeButt.Name = "SearchTypeButt";
            this.SearchTypeButt.Size = new System.Drawing.Size(93, 21);
            this.SearchTypeButt.TabIndex = 11;
            this.SearchTypeButt.Text = "Найти";
            this.SearchTypeButt.UseVisualStyleBackColor = true;
            this.SearchTypeButt.Visible = false;
            this.SearchTypeButt.Click += new System.EventHandler(this.SearchTypeButt_Click);
            // 
            // SearchDolgButt
            // 
            this.SearchDolgButt.Location = new System.Drawing.Point(516, 311);
            this.SearchDolgButt.Name = "SearchDolgButt";
            this.SearchDolgButt.Size = new System.Drawing.Size(140, 21);
            this.SearchDolgButt.TabIndex = 12;
            this.SearchDolgButt.Text = "Найти должников";
            this.SearchDolgButt.UseVisualStyleBackColor = true;
            this.SearchDolgButt.Visible = false;
            this.SearchDolgButt.Click += new System.EventHandler(this.SearchDolgButt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Справка о всех должниках";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(679, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Удалить всех пациентов без задолженности";
            this.label8.Visible = false;
            // 
            // DeleteDolgButt
            // 
            this.DeleteDolgButt.Location = new System.Drawing.Point(682, 310);
            this.DeleteDolgButt.Name = "DeleteDolgButt";
            this.DeleteDolgButt.Size = new System.Drawing.Size(93, 21);
            this.DeleteDolgButt.TabIndex = 13;
            this.DeleteDolgButt.Text = "Удалить";
            this.DeleteDolgButt.UseVisualStyleBackColor = true;
            this.DeleteDolgButt.Visible = false;
            this.DeleteDolgButt.Click += new System.EventHandler(this.DeleteDolgButt_Click);
            // 
            // PassButton
            // 
            this.PassButton.Location = new System.Drawing.Point(196, 364);
            this.PassButton.Name = "PassButton";
            this.PassButton.Size = new System.Drawing.Size(109, 20);
            this.PassButton.TabIndex = 15;
            this.PassButton.Text = "Ввод";
            this.PassButton.UseVisualStyleBackColor = true;
            this.PassButton.Click += new System.EventHandler(this.PassButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(286, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ведите пароль для получения прав на редактирование";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(7, 364);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '☺';
            this.PassTextBox.Size = new System.Drawing.Size(183, 20);
            this.PassTextBox.TabIndex = 14;
            // 
            // Consol
            // 
            this.Consol.Location = new System.Drawing.Point(331, 349);
            this.Consol.Multiline = true;
            this.Consol.Name = "Consol";
            this.Consol.ReadOnly = true;
            this.Consol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Consol.Size = new System.Drawing.Size(582, 99);
            this.Consol.TabIndex = 27;
            // 
            // TypeOfWorkBox
            // 
            this.TypeOfWorkBox.Location = new System.Drawing.Point(98, 112);
            this.TypeOfWorkBox.Name = "TypeOfWorkBox";
            this.TypeOfWorkBox.Size = new System.Drawing.Size(93, 20);
            this.TypeOfWorkBox.TabIndex = 4;
            this.TypeOfWorkBox.Visible = false;
            // 
            // SearchTypeBox
            // 
            this.SearchTypeBox.Location = new System.Drawing.Point(252, 310);
            this.SearchTypeBox.Name = "SearchTypeBox";
            this.SearchTypeBox.Size = new System.Drawing.Size(106, 20);
            this.SearchTypeBox.TabIndex = 10;
            this.SearchTypeBox.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 26);
            this.label10.TabIndex = 30;
            this.label10.Text = "Пациент заплатил \r\n(0 - нет, 1 - да)";
            this.label10.Visible = false;
            // 
            // PaymentNumerical
            // 
            this.PaymentNumerical.Location = new System.Drawing.Point(118, 185);
            this.PaymentNumerical.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PaymentNumerical.Name = "PaymentNumerical";
            this.PaymentNumerical.Size = new System.Drawing.Size(73, 20);
            this.PaymentNumerical.TabIndex = 6;
            this.PaymentNumerical.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Инициалы полностью";
            this.label11.Visible = false;
            // 
            // NameAndOtchestvo
            // 
            this.NameAndOtchestvo.Location = new System.Drawing.Point(129, 77);
            this.NameAndOtchestvo.Name = "NameAndOtchestvo";
            this.NameAndOtchestvo.Size = new System.Drawing.Size(60, 20);
            this.NameAndOtchestvo.TabIndex = 3;
            this.NameAndOtchestvo.Visible = false;
            // 
            // ConsoleClear
            // 
            this.ConsoleClear.Location = new System.Drawing.Point(7, 390);
            this.ConsoleClear.Name = "ConsoleClear";
            this.ConsoleClear.Size = new System.Drawing.Size(109, 58);
            this.ConsoleClear.TabIndex = 16;
            this.ConsoleClear.Text = "Очистить консоль";
            this.ConsoleClear.UseVisualStyleBackColor = true;
            this.ConsoleClear.Click += new System.EventHandler(this.ConsoleClear_Click);
            // 
            // ImportButt
            // 
            this.ImportButt.Location = new System.Drawing.Point(129, 405);
            this.ImportButt.Name = "ImportButt";
            this.ImportButt.Size = new System.Drawing.Size(81, 42);
            this.ImportButt.TabIndex = 34;
            this.ImportButt.Text = "Импорт из файла";
            this.ImportButt.UseVisualStyleBackColor = true;
            this.ImportButt.Visible = false;
            // 
            // ExportButt
            // 
            this.ExportButt.Location = new System.Drawing.Point(216, 405);
            this.ExportButt.Name = "ExportButt";
            this.ExportButt.Size = new System.Drawing.Size(89, 42);
            this.ExportButt.TabIndex = 35;
            this.ExportButt.Text = "Экспорт в файл";
            this.ExportButt.UseVisualStyleBackColor = true;
            this.ExportButt.Visible = false;
            this.ExportButt.Click += new System.EventHandler(this.ExportButt_Click);
            // 
            // ColumnCardNum
            // 
            this.ColumnCardNum.HeaderText = "№ карточки";
            this.ColumnCardNum.Name = "ColumnCardNum";
            this.ColumnCardNum.ReadOnly = true;
            // 
            // ColumnNSS
            // 
            this.ColumnNSS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnNSS.HeaderText = "ФИО пациента";
            this.ColumnNSS.Name = "ColumnNSS";
            this.ColumnNSS.ReadOnly = true;
            // 
            // ColumnVidRaboti
            // 
            this.ColumnVidRaboti.HeaderText = "Вид работы";
            this.ColumnVidRaboti.Name = "ColumnVidRaboti";
            this.ColumnVidRaboti.ReadOnly = true;
            // 
            // ColumnCost
            // 
            this.ColumnCost.HeaderText = "Стоимость выполненной работы";
            this.ColumnCost.Name = "ColumnCost";
            this.ColumnCost.ReadOnly = true;
            // 
            // ColumnOplataCheck
            // 
            this.ColumnOplataCheck.HeaderText = "Отметка об оплате";
            this.ColumnOplataCheck.Name = "ColumnOplataCheck";
            this.ColumnOplataCheck.ReadOnly = true;
            this.ColumnOplataCheck.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnOplataCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnDolg
            // 
            this.ColumnDolg.HeaderText = "Сумма задолженности";
            this.ColumnDolg.Name = "ColumnDolg";
            this.ColumnDolg.ReadOnly = true;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Удаление пациента";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Text = "X";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            this.ColumnDelete.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 460);
            this.Controls.Add(this.ExportButt);
            this.Controls.Add(this.ImportButt);
            this.Controls.Add(this.ConsoleClear);
            this.Controls.Add(this.NameAndOtchestvo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PaymentNumerical);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SearchTypeBox);
            this.Controls.Add(this.TypeOfWorkBox);
            this.Controls.Add(this.Consol);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PassButton);
            this.Controls.Add(this.DeleteDolgButt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SearchDolgButt);
            this.Controls.Add(this.SearchTypeButt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchNameButt);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CostOfWork);
            this.Controls.Add(this.CardNumberNumeric);
            this.Controls.Add(this.FamiliyaBox);
            this.Controls.Add(this.Tablitca);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Информационная база пациентов зубного врача";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tablitca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardNumberNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentNumerical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FamiliyaBox;
        private System.Windows.Forms.NumericUpDown CardNumberNumeric;
        private System.Windows.Forms.NumericUpDown CostOfWork;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SearchNameButt;
        private System.Windows.Forms.DataGridView Tablitca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SearchNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SearchTypeButt;
        private System.Windows.Forms.Button SearchDolgButt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DeleteDolgButt;
        private System.Windows.Forms.Button PassButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.TextBox Consol;
        private System.Windows.Forms.TextBox TypeOfWorkBox;
        private System.Windows.Forms.TextBox SearchTypeBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown PaymentNumerical;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NameAndOtchestvo;
        private System.Windows.Forms.Button ConsoleClear;
        private System.Windows.Forms.Button ImportButt;
        private System.Windows.Forms.Button ExportButt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCardNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVidRaboti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOplataCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDolg;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
    }
}

