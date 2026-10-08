
namespace WindowsFormsAppEyukinConventer
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
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(121, 32);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(118, 20);
            this.textBoxValue.TabIndex = 2;
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "Метры",
            "Километры",
            "Сантиметры",
            "Миллиметры",
            "Килограммы",
            "Граммы",
            "Миллиграммы",
            "Тонны"});
            this.comboBoxFrom.Location = new System.Drawing.Point(272, 32);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFrom.TabIndex = 3;
            this.comboBoxFrom.Text = "Из единицы:";
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "Метры",
            "Километры",
            "Сантиметры",
            "Миллиметры",
            "Килограммы",
            "Граммы",
            "Миллиграммы",
            "Тонны"});
            this.comboBoxTo.Location = new System.Drawing.Point(261, 137);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTo.TabIndex = 4;
            this.comboBoxTo.Text = "В единицу:";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(121, 84);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(130, 23);
            this.buttonConvert.TabIndex = 5;
            this.buttonConvert.Text = "Конвертировать";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(149, 179);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 160);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 13);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 240);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.textBoxValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelResult;
    }
}

