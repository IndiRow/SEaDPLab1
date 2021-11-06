
namespace CalculatorApp
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
            this.num1 = new System.Windows.Forms.Button();
            this.calculatorDisplay = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.num1.Location = new System.Drawing.Point(14, 162);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(88, 52);
            this.num1.TabIndex = 0;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // calculatorDisplay
            // 
            this.calculatorDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculatorDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.calculatorDisplay.ForeColor = System.Drawing.Color.White;
            this.calculatorDisplay.Location = new System.Drawing.Point(12, 9);
            this.calculatorDisplay.Name = "calculatorDisplay";
            this.calculatorDisplay.Size = new System.Drawing.Size(372, 85);
            this.calculatorDisplay.TabIndex = 1;
            this.calculatorDisplay.Text = "0";
            this.calculatorDisplay.Click += new System.EventHandler(this.label1_Click);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.num2.Location = new System.Drawing.Point(108, 162);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(88, 52);
            this.num2.TabIndex = 2;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.num3.Location = new System.Drawing.Point(202, 162);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(88, 52);
            this.num3.TabIndex = 3;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.num4.Location = new System.Drawing.Point(14, 220);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(88, 52);
            this.num4.TabIndex = 4;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.num5.Location = new System.Drawing.Point(108, 220);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(88, 52);
            this.num5.TabIndex = 5;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.num6.Location = new System.Drawing.Point(202, 220);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(88, 52);
            this.num6.TabIndex = 6;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num7
            // 
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.num7.Location = new System.Drawing.Point(14, 278);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(88, 52);
            this.num7.TabIndex = 7;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.num8.Location = new System.Drawing.Point(108, 278);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(88, 52);
            this.num8.TabIndex = 8;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.num9.Location = new System.Drawing.Point(202, 278);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(88, 52);
            this.num9.TabIndex = 9;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.zeroButton.Location = new System.Drawing.Point(12, 336);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(184, 52);
            this.zeroButton.TabIndex = 10;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.equalButton.Location = new System.Drawing.Point(296, 278);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(88, 110);
            this.equalButton.TabIndex = 12;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.minusButton.Location = new System.Drawing.Point(296, 220);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(88, 52);
            this.minusButton.TabIndex = 13;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.plusButton.Location = new System.Drawing.Point(296, 162);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(88, 52);
            this.plusButton.TabIndex = 14;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.divideButton.Location = new System.Drawing.Point(202, 104);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(88, 52);
            this.divideButton.TabIndex = 16;
            this.divideButton.Text = "\\";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.clearButton.Location = new System.Drawing.Point(12, 104);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(184, 52);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "AC";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.decimalButton.Location = new System.Drawing.Point(202, 335);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(88, 52);
            this.decimalButton.TabIndex = 18;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.multiplyButton.Location = new System.Drawing.Point(296, 104);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(88, 52);
            this.multiplyButton.TabIndex = 19;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 399);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.calculatorDisplay);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "CalculatorApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Label calculatorDisplay;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button multiplyButton;
    }
}

