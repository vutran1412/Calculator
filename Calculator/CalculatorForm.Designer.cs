namespace Calculator
{
    partial class frmCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNumSeven = new System.Windows.Forms.Button();
            this.btnNumEight = new System.Windows.Forms.Button();
            this.btnNumNine = new System.Windows.Forms.Button();
            this.btnNumFour = new System.Windows.Forms.Button();
            this.btnNumFive = new System.Windows.Forms.Button();
            this.btnNumSix = new System.Windows.Forms.Button();
            this.btnNumOne = new System.Windows.Forms.Button();
            this.btnNumTwo = new System.Windows.Forms.Button();
            this.btnNumThree = new System.Windows.Forms.Button();
            this.btnNumZero = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDisplay.Location = new System.Drawing.Point(13, 9);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(338, 40);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(13, 52);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 42);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(170, 52);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(181, 42);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNumSeven
            // 
            this.btnNumSeven.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumSeven.Location = new System.Drawing.Point(13, 100);
            this.btnNumSeven.Name = "btnNumSeven";
            this.btnNumSeven.Size = new System.Drawing.Size(63, 60);
            this.btnNumSeven.TabIndex = 3;
            this.btnNumSeven.Tag = "7";
            this.btnNumSeven.Text = "7";
            this.btnNumSeven.UseVisualStyleBackColor = true;
            this.btnNumSeven.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumEight
            // 
            this.btnNumEight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumEight.Location = new System.Drawing.Point(82, 100);
            this.btnNumEight.Name = "btnNumEight";
            this.btnNumEight.Size = new System.Drawing.Size(63, 60);
            this.btnNumEight.TabIndex = 4;
            this.btnNumEight.Tag = "8";
            this.btnNumEight.Text = "8";
            this.btnNumEight.UseVisualStyleBackColor = true;
            this.btnNumEight.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumNine
            // 
            this.btnNumNine.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumNine.Location = new System.Drawing.Point(150, 100);
            this.btnNumNine.Name = "btnNumNine";
            this.btnNumNine.Size = new System.Drawing.Size(63, 60);
            this.btnNumNine.TabIndex = 5;
            this.btnNumNine.Tag = "9";
            this.btnNumNine.Text = "9";
            this.btnNumNine.UseVisualStyleBackColor = true;
            this.btnNumNine.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumFour
            // 
            this.btnNumFour.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumFour.Location = new System.Drawing.Point(13, 166);
            this.btnNumFour.Name = "btnNumFour";
            this.btnNumFour.Size = new System.Drawing.Size(63, 60);
            this.btnNumFour.TabIndex = 6;
            this.btnNumFour.Tag = "4";
            this.btnNumFour.Text = "4";
            this.btnNumFour.UseVisualStyleBackColor = true;
            this.btnNumFour.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumFive
            // 
            this.btnNumFive.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumFive.Location = new System.Drawing.Point(81, 166);
            this.btnNumFive.Name = "btnNumFive";
            this.btnNumFive.Size = new System.Drawing.Size(63, 60);
            this.btnNumFive.TabIndex = 7;
            this.btnNumFive.Tag = "5";
            this.btnNumFive.Text = "5";
            this.btnNumFive.UseVisualStyleBackColor = true;
            this.btnNumFive.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumSix
            // 
            this.btnNumSix.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumSix.Location = new System.Drawing.Point(150, 166);
            this.btnNumSix.Name = "btnNumSix";
            this.btnNumSix.Size = new System.Drawing.Size(63, 60);
            this.btnNumSix.TabIndex = 8;
            this.btnNumSix.Tag = "6";
            this.btnNumSix.Text = "6";
            this.btnNumSix.UseVisualStyleBackColor = true;
            this.btnNumSix.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumOne
            // 
            this.btnNumOne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumOne.Location = new System.Drawing.Point(13, 232);
            this.btnNumOne.Name = "btnNumOne";
            this.btnNumOne.Size = new System.Drawing.Size(63, 60);
            this.btnNumOne.TabIndex = 9;
            this.btnNumOne.Tag = "1";
            this.btnNumOne.Text = "1";
            this.btnNumOne.UseVisualStyleBackColor = true;
            this.btnNumOne.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumTwo
            // 
            this.btnNumTwo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumTwo.Location = new System.Drawing.Point(82, 232);
            this.btnNumTwo.Name = "btnNumTwo";
            this.btnNumTwo.Size = new System.Drawing.Size(63, 60);
            this.btnNumTwo.TabIndex = 10;
            this.btnNumTwo.Tag = "2";
            this.btnNumTwo.Text = "2";
            this.btnNumTwo.UseVisualStyleBackColor = true;
            this.btnNumTwo.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumThree
            // 
            this.btnNumThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumThree.Location = new System.Drawing.Point(150, 232);
            this.btnNumThree.Name = "btnNumThree";
            this.btnNumThree.Size = new System.Drawing.Size(63, 60);
            this.btnNumThree.TabIndex = 11;
            this.btnNumThree.Tag = "3";
            this.btnNumThree.Text = "3";
            this.btnNumThree.UseVisualStyleBackColor = true;
            this.btnNumThree.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumZero
            // 
            this.btnNumZero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumZero.Location = new System.Drawing.Point(81, 298);
            this.btnNumZero.Name = "btnNumZero";
            this.btnNumZero.Size = new System.Drawing.Size(63, 60);
            this.btnNumZero.TabIndex = 12;
            this.btnNumZero.Tag = "0";
            this.btnNumZero.Text = "0";
            this.btnNumZero.UseVisualStyleBackColor = true;
            this.btnNumZero.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Location = new System.Drawing.Point(13, 298);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(63, 60);
            this.btnSign.TabIndex = 13;
            this.btnSign.Text = "+/-";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(151, 298);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(63, 60);
            this.btnDecimal.TabIndex = 14;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(219, 100);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(63, 60);
            this.btnDivide.TabIndex = 15;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(219, 166);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(63, 60);
            this.btnMultiply.TabIndex = 16;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(219, 232);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(63, 60);
            this.btnSubtract.TabIndex = 17;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(219, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 60);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquareRoot.Location = new System.Drawing.Point(288, 100);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(63, 60);
            this.btnSquareRoot.TabIndex = 19;
            this.btnSquareRoot.Text = "sqrt";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReciprocal.Location = new System.Drawing.Point(288, 166);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(63, 60);
            this.btnReciprocal.TabIndex = 20;
            this.btnReciprocal.Text = "1/X";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(288, 232);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(63, 126);
            this.btnEqual.TabIndex = 21;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Vu Tran 2018";
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnNumZero);
            this.Controls.Add(this.btnNumThree);
            this.Controls.Add(this.btnNumTwo);
            this.Controls.Add(this.btnNumOne);
            this.Controls.Add(this.btnNumSix);
            this.Controls.Add(this.btnNumFive);
            this.Controls.Add(this.btnNumFour);
            this.Controls.Add(this.btnNumNine);
            this.Controls.Add(this.btnNumEight);
            this.Controls.Add(this.btnNumSeven);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDisplay);
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNumSeven;
        private System.Windows.Forms.Button btnNumEight;
        private System.Windows.Forms.Button btnNumNine;
        private System.Windows.Forms.Button btnNumFour;
        private System.Windows.Forms.Button btnNumFive;
        private System.Windows.Forms.Button btnNumSix;
        private System.Windows.Forms.Button btnNumOne;
        private System.Windows.Forms.Button btnNumTwo;
        private System.Windows.Forms.Button btnNumThree;
        private System.Windows.Forms.Button btnNumZero;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Label label1;
    }
}

