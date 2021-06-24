
namespace BiblWorm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Books = new System.Windows.Forms.TabPage();
            this.buttAddBook = new System.Windows.Forms.Button();
            this.chkBoxOntime = new System.Windows.Forms.CheckBox();
            this.chkBoxAvail = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numDaysUsed = new System.Windows.Forms.NumericUpDown();
            this.numBoxInventNum = new System.Windows.Forms.NumericUpDown();
            this.numBoxYear = new System.Windows.Forms.NumericUpDown();
            this.numBoxPages = new System.Windows.Forms.NumericUpDown();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.Magazines = new System.Windows.Forms.TabPage();
            this.richTextBoxBookInfo = new System.Windows.Forms.RichTextBox();
            this.buttViewBook = new System.Windows.Forms.Button();
            this.chkBoxSortBooks = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.Books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysUsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxInventNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxPages)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Books);
            this.tabControl1.Controls.Add(this.Magazines);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(280, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // Books
            // 
            this.Books.BackColor = System.Drawing.SystemColors.Control;
            this.Books.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Books.Controls.Add(this.buttAddBook);
            this.Books.Controls.Add(this.chkBoxOntime);
            this.Books.Controls.Add(this.chkBoxAvail);
            this.Books.Controls.Add(this.label7);
            this.Books.Controls.Add(this.label6);
            this.Books.Controls.Add(this.label5);
            this.Books.Controls.Add(this.label4);
            this.Books.Controls.Add(this.label3);
            this.Books.Controls.Add(this.label2);
            this.Books.Controls.Add(this.label1);
            this.Books.Controls.Add(this.numDaysUsed);
            this.Books.Controls.Add(this.numBoxInventNum);
            this.Books.Controls.Add(this.numBoxYear);
            this.Books.Controls.Add(this.numBoxPages);
            this.Books.Controls.Add(this.textBoxPublisher);
            this.Books.Controls.Add(this.textBoxTitle);
            this.Books.Controls.Add(this.textBoxAuthor);
            this.Books.Location = new System.Drawing.Point(4, 22);
            this.Books.Name = "Books";
            this.Books.Padding = new System.Windows.Forms.Padding(3);
            this.Books.Size = new System.Drawing.Size(272, 385);
            this.Books.TabIndex = 0;
            this.Books.Text = "Книги";
            // 
            // buttAddBook
            // 
            this.buttAddBook.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttAddBook.Location = new System.Drawing.Point(43, 334);
            this.buttAddBook.Name = "buttAddBook";
            this.buttAddBook.Size = new System.Drawing.Size(180, 30);
            this.buttAddBook.TabIndex = 16;
            this.buttAddBook.Text = "Добавить";
            this.buttAddBook.UseVisualStyleBackColor = true;
            this.buttAddBook.Click += new System.EventHandler(this.buttAddBook_Click);
            // 
            // chkBoxOntime
            // 
            this.chkBoxOntime.AutoSize = true;
            this.chkBoxOntime.Location = new System.Drawing.Point(140, 290);
            this.chkBoxOntime.Name = "chkBoxOntime";
            this.chkBoxOntime.Size = new System.Drawing.Size(104, 17);
            this.chkBoxOntime.TabIndex = 15;
            this.chkBoxOntime.Text = "Возврат в срок";
            this.chkBoxOntime.UseVisualStyleBackColor = true;
            // 
            // chkBoxAvail
            // 
            this.chkBoxAvail.AutoSize = true;
            this.chkBoxAvail.Location = new System.Drawing.Point(20, 290);
            this.chkBoxAvail.Name = "chkBoxAvail";
            this.chkBoxAvail.Size = new System.Drawing.Size(69, 17);
            this.chkBoxAvail.TabIndex = 14;
            this.chkBoxAvail.Text = "Наличие";
            this.chkBoxAvail.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Срок пользования";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Инв. номер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Год издания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Кол. страниц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Издательство";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Автор";
            // 
            // numDaysUsed
            // 
            this.numDaysUsed.Location = new System.Drawing.Point(135, 245);
            this.numDaysUsed.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numDaysUsed.Name = "numDaysUsed";
            this.numDaysUsed.Size = new System.Drawing.Size(115, 20);
            this.numDaysUsed.TabIndex = 6;
            // 
            // numBoxInventNum
            // 
            this.numBoxInventNum.Location = new System.Drawing.Point(115, 205);
            this.numBoxInventNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numBoxInventNum.Name = "numBoxInventNum";
            this.numBoxInventNum.Size = new System.Drawing.Size(135, 20);
            this.numBoxInventNum.TabIndex = 5;
            // 
            // numBoxYear
            // 
            this.numBoxYear.Location = new System.Drawing.Point(115, 170);
            this.numBoxYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numBoxYear.Name = "numBoxYear";
            this.numBoxYear.Size = new System.Drawing.Size(135, 20);
            this.numBoxYear.TabIndex = 4;
            // 
            // numBoxPages
            // 
            this.numBoxPages.Location = new System.Drawing.Point(115, 135);
            this.numBoxPages.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBoxPages.Name = "numBoxPages";
            this.numBoxPages.Size = new System.Drawing.Size(135, 20);
            this.numBoxPages.TabIndex = 3;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(115, 87);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(135, 20);
            this.textBoxPublisher.TabIndex = 2;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(115, 52);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(135, 20);
            this.textBoxTitle.TabIndex = 1;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(115, 17);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(135, 20);
            this.textBoxAuthor.TabIndex = 0;
            // 
            // Magazines
            // 
            this.Magazines.BackColor = System.Drawing.SystemColors.Control;
            this.Magazines.Location = new System.Drawing.Point(4, 22);
            this.Magazines.Name = "Magazines";
            this.Magazines.Padding = new System.Windows.Forms.Padding(3);
            this.Magazines.Size = new System.Drawing.Size(272, 385);
            this.Magazines.TabIndex = 1;
            this.Magazines.Text = "Журналы";
            // 
            // richTextBoxBookInfo
            // 
            this.richTextBoxBookInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxBookInfo.Location = new System.Drawing.Point(287, 21);
            this.richTextBoxBookInfo.Name = "richTextBoxBookInfo";
            this.richTextBoxBookInfo.Size = new System.Drawing.Size(358, 318);
            this.richTextBoxBookInfo.TabIndex = 1;
            this.richTextBoxBookInfo.Text = "";
            // 
            // buttViewBook
            // 
            this.buttViewBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttViewBook.Location = new System.Drawing.Point(299, 365);
            this.buttViewBook.Name = "buttViewBook";
            this.buttViewBook.Size = new System.Drawing.Size(109, 22);
            this.buttViewBook.TabIndex = 2;
            this.buttViewBook.Text = "Просмотреть";
            this.buttViewBook.UseVisualStyleBackColor = true;
            this.buttViewBook.Click += new System.EventHandler(this.buttViewBook_Click);
            // 
            // chkBoxSortBooks
            // 
            this.chkBoxSortBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBoxSortBooks.AutoSize = true;
            this.chkBoxSortBooks.Location = new System.Drawing.Point(453, 368);
            this.chkBoxSortBooks.Name = "chkBoxSortBooks";
            this.chkBoxSortBooks.Size = new System.Drawing.Size(170, 17);
            this.chkBoxSortBooks.TabIndex = 3;
            this.chkBoxSortBooks.Text = "Сортировать по инв. номеру";
            this.chkBoxSortBooks.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 411);
            this.Controls.Add(this.chkBoxSortBooks);
            this.Controls.Add(this.buttViewBook);
            this.Controls.Add(this.richTextBoxBookInfo);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(670, 450);
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.tabControl1.ResumeLayout(false);
            this.Books.ResumeLayout(false);
            this.Books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysUsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxInventNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Books;
        private System.Windows.Forms.Button buttAddBook;
        private System.Windows.Forms.CheckBox chkBoxOntime;
        private System.Windows.Forms.CheckBox chkBoxAvail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDaysUsed;
        private System.Windows.Forms.NumericUpDown numBoxInventNum;
        private System.Windows.Forms.NumericUpDown numBoxYear;
        private System.Windows.Forms.NumericUpDown numBoxPages;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TabPage Magazines;
        private System.Windows.Forms.RichTextBox richTextBoxBookInfo;
        private System.Windows.Forms.Button buttViewBook;
        private System.Windows.Forms.CheckBox chkBoxSortBooks;
    }
}

