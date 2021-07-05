
namespace WinTimer1
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
            this.ButtonRunPause = new System.Windows.Forms.Button();
            this.userControl1 = new WinTimer1.UserControl1();
            this.SuspendLayout();
            // 
            // ButtonRunPause
            // 
            this.ButtonRunPause.Location = new System.Drawing.Point(303, 297);
            this.ButtonRunPause.Name = "ButtonRunPause";
            this.ButtonRunPause.Size = new System.Drawing.Size(144, 68);
            this.ButtonRunPause.TabIndex = 1;
            this.ButtonRunPause.Text = "Run/Pause";
            this.ButtonRunPause.UseVisualStyleBackColor = true;
            this.ButtonRunPause.Click += new System.EventHandler(this.ButtonRunPause_Click);
            // 
            // userControl1
            // 
            this.userControl1.IsTimeEnabled = true;
            this.userControl1.Location = new System.Drawing.Point(292, 94);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(169, 144);
            this.userControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonRunPause);
            this.Controls.Add(this.userControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl1;
        private System.Windows.Forms.Button ButtonRunPause;
    }
}

