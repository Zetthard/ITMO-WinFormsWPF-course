
namespace StretchingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataInput = new System.Windows.Forms.TextBox();
            this.InputData = new System.Windows.Forms.Label();
            this.BigTextBox = new System.Windows.Forms.TextBox();
            this.SendTextButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.DataInput);
            this.panel1.Controls.Add(this.InputData);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 122);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DataInput
            // 
            this.DataInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataInput.Location = new System.Drawing.Point(279, 45);
            this.DataInput.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.DataInput.Name = "DataInput";
            this.DataInput.Size = new System.Drawing.Size(591, 31);
            this.DataInput.TabIndex = 1;
            this.DataInput.TextChanged += new System.EventHandler(this.DataInput_TextChanged);
            // 
            // InputData
            // 
            this.InputData.AutoSize = true;
            this.InputData.Location = new System.Drawing.Point(58, 45);
            this.InputData.Name = "InputData";
            this.InputData.Size = new System.Drawing.Size(176, 25);
            this.InputData.TabIndex = 0;
            this.InputData.Text = "Введите данные";
            // 
            // BigTextBox
            // 
            this.BigTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BigTextBox.Location = new System.Drawing.Point(36, 162);
            this.BigTextBox.Multiline = true;
            this.BigTextBox.Name = "BigTextBox";
            this.BigTextBox.Size = new System.Drawing.Size(591, 522);
            this.BigTextBox.TabIndex = 1;
            // 
            // SendTextButton
            // 
            this.SendTextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendTextButton.Location = new System.Drawing.Point(706, 195);
            this.SendTextButton.Name = "SendTextButton";
            this.SendTextButton.Size = new System.Drawing.Size(164, 96);
            this.SendTextButton.TabIndex = 2;
            this.SendTextButton.Text = "Отправить";
            this.SendTextButton.UseVisualStyleBackColor = true;
            this.SendTextButton.Click += new System.EventHandler(this.DataInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 736);
            this.Controls.Add(this.SendTextButton);
            this.Controls.Add(this.BigTextBox);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox DataInput;
        private System.Windows.Forms.Label InputData;
        private System.Windows.Forms.TextBox BigTextBox;
        private System.Windows.Forms.Button SendTextButton;
    }
}

