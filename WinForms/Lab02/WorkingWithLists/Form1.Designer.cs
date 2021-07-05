
namespace WorkingWithLists
{
    partial class FormLists
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
            this.ListOfParticipants = new System.Windows.Forms.GroupBox();
            this.MemberList = new System.Windows.Forms.CheckedListBox();
            this.PeopleList = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.ListOfParticipants.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListOfParticipants
            // 
            this.ListOfParticipants.Controls.Add(this.MemberList);
            this.ListOfParticipants.Location = new System.Drawing.Point(0, 0);
            this.ListOfParticipants.Name = "ListOfParticipants";
            this.ListOfParticipants.Size = new System.Drawing.Size(200, 150);
            this.ListOfParticipants.TabIndex = 0;
            this.ListOfParticipants.TabStop = false;
            this.ListOfParticipants.Text = "Список участников";
            // 
            // MemberList
            // 
            this.MemberList.FormattingEnabled = true;
            this.MemberList.Location = new System.Drawing.Point(5, 20);
            this.MemberList.Margin = new System.Windows.Forms.Padding(5, 10, 3, 3);
            this.MemberList.Name = "MemberList";
            this.MemberList.Size = new System.Drawing.Size(190, 124);
            this.MemberList.TabIndex = 0;
            // 
            // PeopleList
            // 
            this.PeopleList.FormattingEnabled = true;
            this.PeopleList.Items.AddRange(new object[] {
            "Tom",
            "Jerry",
            "Mikkey",
            "Leopold",
            "Carlsson"});
            this.PeopleList.Location = new System.Drawing.Point(5, 157);
            this.PeopleList.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.PeopleList.Name = "PeopleList";
            this.PeopleList.Size = new System.Drawing.Size(190, 21);
            this.PeopleList.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(240, 25);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 25);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(240, 65);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(100, 25);
            this.DelButton.TabIndex = 3;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(240, 105);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(100, 25);
            this.SortButton.TabIndex = 4;
            this.SortButton.Text = "Сортировать";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(240, 160);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(100, 40);
            this.ButtonLoad.TabIndex = 5;
            this.ButtonLoad.Text = "Загрузить данные";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // FormLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 257);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PeopleList);
            this.Controls.Add(this.ListOfParticipants);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormLists";
            this.Text = "Работа со списками";
            this.ListOfParticipants.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ListOfParticipants;
        private System.Windows.Forms.CheckedListBox MemberList;
        private System.Windows.Forms.ComboBox PeopleList;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button ButtonLoad;
    }
}

