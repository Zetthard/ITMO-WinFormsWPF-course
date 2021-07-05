
namespace RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            this.grpBoxInput = new System.Windows.Forms.GroupBox();
            this.labelPin = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPin = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBoxAdvanced = new System.Windows.Forms.CheckBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxInput
            // 
            this.grpBoxInput.Controls.Add(this.labelPin);
            this.grpBoxInput.Controls.Add(this.labelName);
            this.grpBoxInput.Controls.Add(this.textBoxPin);
            this.grpBoxInput.Controls.Add(this.textBoxName);
            this.grpBoxInput.Location = new System.Drawing.Point(28, 65);
            this.grpBoxInput.Name = "grpBoxInput";
            this.grpBoxInput.Size = new System.Drawing.Size(373, 145);
            this.grpBoxInput.TabIndex = 0;
            this.grpBoxInput.TabStop = false;
            this.grpBoxInput.Text = "Введите регистрационные данные";
            // 
            // labelPin
            // 
            this.labelPin.AutoSize = true;
            this.labelPin.Location = new System.Drawing.Point(50, 77);
            this.labelPin.Name = "labelPin";
            this.labelPin.Size = new System.Drawing.Size(25, 13);
            this.labelPin.TabIndex = 3;
            this.labelPin.Text = "PIN";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(47, 38);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // textBoxPin
            // 
            this.textBoxPin.Location = new System.Drawing.Point(136, 73);
            this.textBoxPin.Name = "textBoxPin";
            this.textBoxPin.Size = new System.Drawing.Size(190, 20);
            this.textBoxPin.TabIndex = 1;
            this.textBoxPin.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPin_Validating);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(136, 33);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(190, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите тип регистрации";
            // 
            // chkBoxAdvanced
            // 
            this.chkBoxAdvanced.AutoSize = true;
            this.chkBoxAdvanced.Location = new System.Drawing.Point(208, 219);
            this.chkBoxAdvanced.Name = "chkBoxAdvanced";
            this.chkBoxAdvanced.Size = new System.Drawing.Size(169, 17);
            this.chkBoxAdvanced.TabIndex = 2;
            this.chkBoxAdvanced.Text = "Расширенные возможности";
            this.chkBoxAdvanced.UseVisualStyleBackColor = true;
            this.chkBoxAdvanced.CheckedChanged += new System.EventHandler(this.chkBoxAdvanced_CheckedChanged);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(49, 261);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(127, 27);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "Регистрация";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.chkBoxAdvanced);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBoxInput);
            this.MaximumSize = new System.Drawing.Size(450, 350);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxInput.ResumeLayout(false);
            this.grpBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxInput;
        private System.Windows.Forms.Label labelPin;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPin;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBoxAdvanced;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

