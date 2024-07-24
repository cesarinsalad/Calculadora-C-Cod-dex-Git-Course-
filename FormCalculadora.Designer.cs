namespace CalculadoraSimple
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            textBoxPrimerValor = new TextBox();
            textBoxSegundoValor = new TextBox();
            Resultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonDivision = new Button();
            buttonMulti = new Button();
            buttonRest = new Button();
            buttonSum = new Button();
            buttonResult = new Button();
            buttonNine = new Button();
            buttonFour = new Button();
            buttonFive = new Button();
            buttonSix = new Button();
            buttonOne = new Button();
            buttonTwo = new Button();
            buttonThree = new Button();
            buttonZero = new Button();
            buttonDot = new Button();
            buttonEight = new Button();
            buttonSeven = new Button();
            buttonNegative = new Button();
            buttonClear = new Button();
            buttonBack = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxPrimerValor
            // 
            textBoxPrimerValor.Location = new Point(39, 178);
            textBoxPrimerValor.Name = "textBoxPrimerValor";
            textBoxPrimerValor.Size = new Size(265, 31);
            textBoxPrimerValor.TabIndex = 0;
            // 
            // textBoxSegundoValor
            // 
            textBoxSegundoValor.Location = new Point(339, 178);
            textBoxSegundoValor.Name = "textBoxSegundoValor";
            textBoxSegundoValor.Size = new Size(265, 31);
            textBoxSegundoValor.TabIndex = 1;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(639, 178);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(320, 31);
            Resultado.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(312, 185);
            label1.Name = "label1";
            label1.Size = new Size(0, 18);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(612, 185);
            label2.Name = "label2";
            label2.Size = new Size(19, 18);
            label2.TabIndex = 4;
            label2.Text = "=";
            // 
            // buttonDivision
            // 
            buttonDivision.BackColor = Color.DarkGray;
            buttonDivision.Font = new Font("HP Simplified", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDivision.Location = new Point(572, 269);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(115, 115);
            buttonDivision.TabIndex = 5;
            buttonDivision.Text = "÷";
            buttonDivision.UseVisualStyleBackColor = false;
            buttonDivision.Click += buttonDivision_Click;
            // 
            // buttonMulti
            // 
            buttonMulti.BackColor = Color.DarkGray;
            buttonMulti.Font = new Font("HP Simplified", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMulti.Location = new Point(573, 390);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(115, 115);
            buttonMulti.TabIndex = 6;
            buttonMulti.Text = "×";
            buttonMulti.UseVisualStyleBackColor = false;
            buttonMulti.Click += buttonMulti_Click;
            // 
            // buttonRest
            // 
            buttonRest.BackColor = Color.DarkGray;
            buttonRest.Font = new Font("HP Simplified", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRest.Location = new Point(573, 511);
            buttonRest.Name = "buttonRest";
            buttonRest.Size = new Size(115, 115);
            buttonRest.TabIndex = 7;
            buttonRest.Text = "-";
            buttonRest.UseVisualStyleBackColor = false;
            buttonRest.Click += buttonRest_Click;
            // 
            // buttonSum
            // 
            buttonSum.BackColor = Color.DarkGray;
            buttonSum.Font = new Font("HP Simplified", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSum.Location = new Point(573, 632);
            buttonSum.Name = "buttonSum";
            buttonSum.Size = new Size(115, 115);
            buttonSum.TabIndex = 8;
            buttonSum.Text = "+";
            buttonSum.UseVisualStyleBackColor = false;
            buttonSum.Click += buttonSum_Click;
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.IndianRed;
            buttonResult.Font = new Font("HP Simplified", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonResult.Location = new Point(693, 511);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(115, 236);
            buttonResult.TabIndex = 9;
            buttonResult.Text = "=";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonNine
            // 
            buttonNine.BackColor = Color.WhiteSmoke;
            buttonNine.Font = new Font("HP Simplified", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNine.Location = new Point(451, 269);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(115, 115);
            buttonNine.TabIndex = 10;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = false;
            buttonNine.Click += button_Click;
            // 
            // buttonFour
            // 
            buttonFour.BackColor = Color.WhiteSmoke;
            buttonFour.Font = new Font("HP Simplified", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFour.Location = new Point(210, 390);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(115, 115);
            buttonFour.TabIndex = 11;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = false;
            buttonFour.Click += button_Click;
            // 
            // buttonFive
            // 
            buttonFive.BackColor = Color.WhiteSmoke;
            buttonFive.Font = new Font("HP Simplified", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFive.Location = new Point(331, 390);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(115, 115);
            buttonFive.TabIndex = 12;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = false;
            buttonFive.Click += button_Click;
            // 
            // buttonSix
            // 
            buttonSix.BackColor = Color.WhiteSmoke;
            buttonSix.Font = new Font("HP Simplified", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSix.Location = new Point(452, 390);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(115, 115);
            buttonSix.TabIndex = 13;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = false;
            buttonSix.Click += button_Click;
            // 
            // buttonOne
            // 
            buttonOne.BackColor = Color.WhiteSmoke;
            buttonOne.Font = new Font("HP Simplified", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOne.Location = new Point(210, 511);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(115, 115);
            buttonOne.TabIndex = 14;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = false;
            buttonOne.Click += button_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.BackColor = Color.WhiteSmoke;
            buttonTwo.Font = new Font("HP Simplified", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTwo.Location = new Point(331, 511);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(115, 115);
            buttonTwo.TabIndex = 15;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = false;
            buttonTwo.Click += button_Click;
            // 
            // buttonThree
            // 
            buttonThree.BackColor = Color.WhiteSmoke;
            buttonThree.Font = new Font("HP Simplified", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonThree.Location = new Point(452, 511);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(115, 115);
            buttonThree.TabIndex = 16;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = false;
            buttonThree.Click += button_Click;
            // 
            // buttonZero
            // 
            buttonZero.BackColor = Color.WhiteSmoke;
            buttonZero.Font = new Font("HP Simplified", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonZero.Location = new Point(210, 632);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(115, 115);
            buttonZero.TabIndex = 17;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = false;
            buttonZero.Click += button_Click;
            // 
            // buttonDot
            // 
            buttonDot.BackColor = Color.WhiteSmoke;
            buttonDot.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDot.Location = new Point(331, 632);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(115, 115);
            buttonDot.TabIndex = 18;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = false;
            buttonDot.Click += button_Click;
            // 
            // buttonEight
            // 
            buttonEight.BackColor = Color.WhiteSmoke;
            buttonEight.Font = new Font("HP Simplified", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEight.Location = new Point(331, 269);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(115, 115);
            buttonEight.TabIndex = 20;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = false;
            buttonEight.Click += button_Click;
            // 
            // buttonSeven
            // 
            buttonSeven.BackColor = Color.WhiteSmoke;
            buttonSeven.Font = new Font("HP Simplified", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSeven.Location = new Point(210, 269);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(115, 115);
            buttonSeven.TabIndex = 21;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = false;
            buttonSeven.Click += button_Click;
            // 
            // buttonNegative
            // 
            buttonNegative.BackColor = Color.DarkGray;
            buttonNegative.Font = new Font("HP Simplified", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNegative.Location = new Point(452, 632);
            buttonNegative.Name = "buttonNegative";
            buttonNegative.Size = new Size(115, 115);
            buttonNegative.TabIndex = 22;
            buttonNegative.Text = "+/-";
            buttonNegative.UseVisualStyleBackColor = false;
            buttonNegative.Click += buttonNegative_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.IndianRed;
            buttonClear.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(693, 390);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(115, 115);
            buttonClear.TabIndex = 23;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.IndianRed;
            buttonBack.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBack.Location = new Point(693, 269);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(115, 115);
            buttonBack.TabIndex = 24;
            buttonBack.Text = "⌫";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("HP Simplified", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(204, 64);
            label3.Name = "label3";
            label3.Size = new Size(604, 83);
            label3.TabIndex = 25;
            label3.Text = "Calculadora PROIII";
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1008, 834);
            Controls.Add(label3);
            Controls.Add(buttonBack);
            Controls.Add(buttonClear);
            Controls.Add(buttonNegative);
            Controls.Add(buttonSeven);
            Controls.Add(buttonEight);
            Controls.Add(buttonDot);
            Controls.Add(buttonZero);
            Controls.Add(buttonThree);
            Controls.Add(buttonTwo);
            Controls.Add(buttonOne);
            Controls.Add(buttonSix);
            Controls.Add(buttonFive);
            Controls.Add(buttonFour);
            Controls.Add(buttonNine);
            Controls.Add(buttonResult);
            Controls.Add(buttonSum);
            Controls.Add(buttonRest);
            Controls.Add(buttonMulti);
            Controls.Add(buttonDivision);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Resultado);
            Controls.Add(textBoxSegundoValor);
            Controls.Add(textBoxPrimerValor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1030, 890);
            MinimumSize = new Size(1030, 890);
            Name = "Calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora PROIII";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPrimerValor;
        private TextBox textBoxSegundoValor;
        private TextBox Resultado;
        private Label label1;
        private Label label2;
        private Button buttonDivision;
        private Button buttonMulti;
        private Button buttonRest;
        private Button buttonSum;
        private Button buttonResult;
        private Button buttonNine;
        private Button buttonFour;
        private Button buttonFive;
        private Button buttonSix;
        private Button buttonOne;
        private Button buttonTwo;
        private Button buttonThree;
        private Button buttonZero;
        private Button buttonDot;
        private Button buttonEight;
        private Button buttonSeven;
        private Button buttonNegative;
        private Button buttonClear;
        private Button buttonBack;
        private Label label3;
    }
}
