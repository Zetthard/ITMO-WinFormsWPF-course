
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
            this.numBoxDaysUsed = new System.Windows.Forms.NumericUpDown();
            this.numBoxInvNum = new System.Windows.Forms.NumericUpDown();
            this.numBoxYear = new System.Windows.Forms.NumericUpDown();
            this.numBoxPages = new System.Windows.Forms.NumericUpDown();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.Magazines = new System.Windows.Forms.TabPage();
            this.richTextBoxBookInfo = new System.Windows.Forms.RichTextBox();
            this.buttViewBook = new System.Windows.Forms.Button();
            this.chkBoxSortBooks = new System.Windows.Forms.CheckBox();
            this.textBoxMagVol = new System.Windows.Forms.TextBox();
            this.textBoxMagTitle = new System.Windows.Forms.TextBox();
            this.numBoxMagYear = new System.Windows.Forms.NumericUpDown();
            this.numBoxMagInvNum = new System.Windows.Forms.NumericUpDown();
            this.numBoxMagDaysUsed = new System.Windows.Forms.NumericUpDown();
            this.buttAddMag = new System.Windows.Forms.Button();
            this.chkBoxMagOntime = new System.Windows.Forms.CheckBox();
            this.chkBoxMagAvail = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numBoxMagNum = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.Books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxDaysUsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxInvNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxPages)).BeginInit();
            this.Magazines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxMagYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxMagInvNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxMagDaysUsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxMagNum)).BeginInit();
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
            this.Books.Controls.Add(this.numBoxDaysUsed);
            this.Books.Controls.Add(this.numBoxInvNum);
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
            // numBoxDaysUsed
            // 
            this.numBoxDaysUsed.Location = new System.Drawing.Point(135, 245);
            this.numBoxDaysUsed.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numBoxDaysUsed.Name = "numBoxDaysUsed";
            this.numBoxDaysUsed.Size = new System.Drawing.Size(115, 20);
            this.numBoxDaysUsed.TabIndex = 6;
            // 
            // numBoxInvNum
            // 
            this.numBoxInvNum.Location = new System.Drawing.Point(115, 205);
            this.numBoxInvNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numBoxInvNum.Name = "numBoxInvNum";
            this.numBoxInvNum.Size = new System.Drawing.Size(135, 20);
            this.numBoxInvNum.TabIndex = 5;
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
            this.Magazines.Controls.Add(this.numBoxMagNum);
            this.Magazines.Controls.Add(this.label8);
            this.Magazines.Controls.Add(this.label9);
            this.Magazines.Controls.Add(this.label10);
            this.Magazines.Controls.Add(this.label12);
            this.Magazines.Controls.Add(this.label13);
            this.Magazines.Controls.Add(this.label14);
            this.Magazines.Controls.Add(this.buttAddMag);
            this.Magazines.Controls.Add(this.chkBoxMagOntime);
            this.Magazines.Controls.Add(this.chkBoxMagAvail);
            this.Magazines.Controls.Add(this.numBoxMagDaysUsed);
            this.Magazines.Controls.Add(this.numBoxMagInvNum);
            this.Magazines.Controls.Add(this.numBoxMagYear);
            this.Magazines.Controls.Add(this.textBoxMagTitle);
            this.Magazines.Controls.Add(this.textBoxMagVol);
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
            // textBoxMagVol
            // 
            this.textBoxMagVol.Location = new System.Drawing.Point(115, 17);
            this.textBoxMagVol.Name = "textBoxMagVol";
            this.textBoxMagVol.Size = new System.Drawing.Size(135, 20);
            this.textBoxMagVol.TabIndex = 1;
            // 
            // textBoxMagTitle
            // 
            this.textBoxMagTitle.Location = new System.Drawing.Point(115, 87);
            this.textBoxMagTitle.Name = "textBoxMagTitle";
            this.textBoxMagTitle.Size = new System.Drawing.Size(135, 20);
            this.textBoxMagTitle.TabIndex = 3;
            // 
            // numBoxMagYear
            // 
            this.numBoxMagYear.Location = new System.Drawing.Point(115, 135);
            this.numBoxMagYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numBoxMagYear.Name = "numBoxMagYear";
            this.numBoxMagYear.Size = new System.Drawing.Size(135, 20);
            this.numBoxMagYear.TabIndex = 4;
            // 
            // numBoxMagInvNum
            // 
            this.numBoxMagInvNum.Location = new System.Drawing.Point(115, 170);
            this.numBoxMagInvNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBoxMagInvNum.Name = "numBoxMagInvNum";
            this.numBoxMagInvNum.Size = new System.Drawing.Size(135, 20);
            this.numBoxMagInvNum.TabIndex = 5;
            // 
            // numBoxMagDaysUsed
            // 
            this.numBoxMagDaysUsed.Location = new System.Drawing.Point(135, 215);
            this.numBoxMagDaysUsed.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numBoxMagDaysUsed.Name = "numBoxMagDaysUsed";
            this.numBoxMagDaysUsed.Size = new System.Drawing.Size(115, 20);
            this.numBoxMagDaysUsed.TabIndex = 7;
            // 
            // buttAddMag
            // 
            this.buttAddMag.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttAddMag.Location = new System.Drawing.Point(43, 334);
            this.buttAddMag.Name = "buttAddMag";
            this.buttAddMag.Size = new System.Drawing.Size(180, 30);
            this.buttAddMag.TabIndex = 19;
            this.buttAddMag.Text = "Добавить";
            this.buttAddMag.UseVisualStyleBackColor = true;
            this.buttAddMag.Click += new System.EventHandler(this.buttAddMag_Click);
            // 
            // chkBoxMagOntime
            // 
            this.chkBoxMagOntime.AutoSize = true;
            this.chkBoxMagOntime.Location = new System.Drawing.Point(145, 260);
            this.chkBoxMagOntime.Name = "chkBoxMagOntime";
            this.chkBoxMagOntime.Size = new System.Drawing.Size(104, 17);
            this.chkBoxMagOntime.TabIndex = 18;
            this.chkBoxMagOntime.Text = "Возврат в срок";
            this.chkBoxMagOntime.UseVisualStyleBackColor = true;
            // 
            // chkBoxMagAvail
            // 
            this.chkBoxMagAvail.AutoSize = true;
            this.chkBoxMagAvail.Location = new System.Drawing.Point(24, 260);
            this.chkBoxMagAvail.Name = "chkBoxMagAvail";
            this.chkBoxMagAvail.Size = new System.Drawing.Size(69, 17);
            this.chkBoxMagAvail.TabIndex = 17;
            this.chkBoxMagAvail.Text = "Наличие";
            this.chkBoxMagAvail.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Срок пользования";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Инв. номер";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Год выхода";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Название";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Номер";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Том";
            // 
            // numBoxMagNum
            // 
            this.numBoxMagNum.Location = new System.Drawing.Point(115, 52);
            this.numBoxMagNum.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numBoxMagNum.Name = "numBoxMagNum";
            this.numBoxMagNum.Size = new System.Drawing.Size(135, 20);
            this.numBoxMagNum.TabIndex = 27;
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
            ((System.ComponentModel.ISupportInitialize)(this.numBoxDaysUsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxInvNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxPages)).EndInit();
            this.Magazines.ResumeLayout(false);
            this.Magazines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxMagYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxMagInvNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxMagDaysUsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxMagNum)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numBoxDaysUsed;
        private System.Windows.Forms.NumericUpDown numBoxInvNum;
        private System.Windows.Forms.NumericUpDown numBoxYear;
        private System.Windows.Forms.NumericUpDown numBoxPages;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TabPage Magazines;
        private System.Windows.Forms.RichTextBox richTextBoxBookInfo;
        private System.Windows.Forms.Button buttViewBook;
        private System.Windows.Forms.CheckBox chkBoxSortBooks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttAddMag;
        private System.Windows.Forms.CheckBox chkBoxMagOntime;
        private System.Windows.Forms.CheckBox chkBoxMagAvail;
        private System.Windows.Forms.NumericUpDown numBoxMagDaysUsed;
        private System.Windows.Forms.NumericUpDown numBoxMagInvNum;
        private System.Windows.Forms.NumericUpDown numBoxMagYear;
        private System.Windows.Forms.TextBox textBoxMagTitle;
        private System.Windows.Forms.TextBox textBoxMagVol;
        private System.Windows.Forms.NumericUpDown numBoxMagNum;
    }
}

