
namespace Blackjack_Card_Counter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnAce = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.txtDecksUsed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRunningCount = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTrueCount = new System.Windows.Forms.Label();
            this.lblBetAmount = new System.Windows.Forms.Label();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.lbl16vs9 = new System.Windows.Forms.Label();
            this.lbl16vs10 = new System.Windows.Forms.Label();
            this.lbl15vs10 = new System.Windows.Forms.Label();
            this.lbl13vs2 = new System.Windows.Forms.Label();
            this.lbl13vs3 = new System.Windows.Forms.Label();
            this.lbl12vs2 = new System.Windows.Forms.Label();
            this.lbl12vs3 = new System.Windows.Forms.Label();
            this.lbl12vs4 = new System.Windows.Forms.Label();
            this.lbl12vs5 = new System.Windows.Forms.Label();
            this.lbl12vs6 = new System.Windows.Forms.Label();
            this.lbl11vsA = new System.Windows.Forms.Label();
            this.lbl10vs10 = new System.Windows.Forms.Label();
            this.lbl10vsA = new System.Windows.Forms.Label();
            this.lbl9vs2 = new System.Windows.Forms.Label();
            this.lbl9vs7 = new System.Windows.Forms.Label();
            this.lbl20vs5 = new System.Windows.Forms.Label();
            this.lbl20vs6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(12, 145);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(54, 23);
            this.btnSeven.TabIndex = 0;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(72, 145);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(54, 23);
            this.btnEight.TabIndex = 1;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(132, 145);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(54, 23);
            this.btnNine.TabIndex = 2;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(12, 174);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(54, 23);
            this.btnFour.TabIndex = 3;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(72, 174);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(54, 23);
            this.btnFive.TabIndex = 4;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(132, 174);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(54, 23);
            this.btnSix.TabIndex = 5;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnAce
            // 
            this.btnAce.Location = new System.Drawing.Point(12, 203);
            this.btnAce.Name = "btnAce";
            this.btnAce.Size = new System.Drawing.Size(54, 23);
            this.btnAce.TabIndex = 6;
            this.btnAce.Text = "A / 1";
            this.btnAce.UseVisualStyleBackColor = true;
            this.btnAce.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(72, 203);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(54, 23);
            this.btnTwo.TabIndex = 7;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(132, 203);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(54, 23);
            this.btnThree.TabIndex = 8;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(12, 232);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(174, 23);
            this.btnTen.TabIndex = 9;
            this.btnTen.Text = "T J Q K";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // txtDecksUsed
            // 
            this.txtDecksUsed.Location = new System.Drawing.Point(87, 12);
            this.txtDecksUsed.Name = "txtDecksUsed";
            this.txtDecksUsed.Size = new System.Drawing.Size(99, 20);
            this.txtDecksUsed.TabIndex = 13;
            this.txtDecksUsed.Text = "8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Decks Used:";
            // 
            // lblRunningCount
            // 
            this.lblRunningCount.AutoSize = true;
            this.lblRunningCount.Location = new System.Drawing.Point(9, 64);
            this.lblRunningCount.Name = "lblRunningCount";
            this.lblRunningCount.Size = new System.Drawing.Size(90, 13);
            this.lblRunningCount.TabIndex = 14;
            this.lblRunningCount.Text = "Running Count: 0";
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(12, 116);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(84, 23);
            this.btnMinus.TabIndex = 15;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(102, 116);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(84, 23);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 38);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(174, 23);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTrueCount
            // 
            this.lblTrueCount.AutoSize = true;
            this.lblTrueCount.Location = new System.Drawing.Point(9, 82);
            this.lblTrueCount.Name = "lblTrueCount";
            this.lblTrueCount.Size = new System.Drawing.Size(72, 13);
            this.lblTrueCount.TabIndex = 18;
            this.lblTrueCount.Text = "True Count: 0";
            // 
            // lblBetAmount
            // 
            this.lblBetAmount.AutoSize = true;
            this.lblBetAmount.Location = new System.Drawing.Point(9, 100);
            this.lblBetAmount.Name = "lblBetAmount";
            this.lblBetAmount.Size = new System.Drawing.Size(96, 13);
            this.lblBetAmount.TabIndex = 19;
            this.lblBetAmount.Text = "Bet Amount: 1 Unit";
            // 
            // lblInsurance
            // 
            this.lblInsurance.AutoSize = true;
            this.lblInsurance.Location = new System.Drawing.Point(192, 9);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(74, 13);
            this.lblInsurance.TabIndex = 20;
            this.lblInsurance.Text = "Insurance: No";
            // 
            // lbl16vs9
            // 
            this.lbl16vs9.AutoSize = true;
            this.lbl16vs9.Location = new System.Drawing.Point(192, 27);
            this.lbl16vs9.Name = "lbl16vs9";
            this.lbl16vs9.Size = new System.Drawing.Size(61, 13);
            this.lbl16vs9.TabIndex = 21;
            this.lbl16vs9.Text = "16 vs 9: Hit";
            // 
            // lbl16vs10
            // 
            this.lbl16vs10.AutoSize = true;
            this.lbl16vs10.Location = new System.Drawing.Point(192, 45);
            this.lbl16vs10.Name = "lbl16vs10";
            this.lbl16vs10.Size = new System.Drawing.Size(67, 13);
            this.lbl16vs10.TabIndex = 22;
            this.lbl16vs10.Text = "16 vs 10: Hit";
            // 
            // lbl15vs10
            // 
            this.lbl15vs10.AutoSize = true;
            this.lbl15vs10.Location = new System.Drawing.Point(192, 63);
            this.lbl15vs10.Name = "lbl15vs10";
            this.lbl15vs10.Size = new System.Drawing.Size(67, 13);
            this.lbl15vs10.TabIndex = 23;
            this.lbl15vs10.Text = "15 vs 10: Hit";
            // 
            // lbl13vs2
            // 
            this.lbl13vs2.AutoSize = true;
            this.lbl13vs2.Location = new System.Drawing.Point(192, 81);
            this.lbl13vs2.Name = "lbl13vs2";
            this.lbl13vs2.Size = new System.Drawing.Size(76, 13);
            this.lbl13vs2.TabIndex = 24;
            this.lbl13vs2.Text = "13 vs 2: Stand";
            // 
            // lbl13vs3
            // 
            this.lbl13vs3.AutoSize = true;
            this.lbl13vs3.Location = new System.Drawing.Point(192, 99);
            this.lbl13vs3.Name = "lbl13vs3";
            this.lbl13vs3.Size = new System.Drawing.Size(76, 13);
            this.lbl13vs3.TabIndex = 25;
            this.lbl13vs3.Text = "13 vs 3: Stand";
            // 
            // lbl12vs2
            // 
            this.lbl12vs2.AutoSize = true;
            this.lbl12vs2.Location = new System.Drawing.Point(192, 117);
            this.lbl12vs2.Name = "lbl12vs2";
            this.lbl12vs2.Size = new System.Drawing.Size(61, 13);
            this.lbl12vs2.TabIndex = 26;
            this.lbl12vs2.Text = "12 vs 2: Hit";
            // 
            // lbl12vs3
            // 
            this.lbl12vs3.AutoSize = true;
            this.lbl12vs3.Location = new System.Drawing.Point(192, 135);
            this.lbl12vs3.Name = "lbl12vs3";
            this.lbl12vs3.Size = new System.Drawing.Size(61, 13);
            this.lbl12vs3.TabIndex = 27;
            this.lbl12vs3.Text = "12 vs 3: Hit";
            // 
            // lbl12vs4
            // 
            this.lbl12vs4.AutoSize = true;
            this.lbl12vs4.Location = new System.Drawing.Point(192, 153);
            this.lbl12vs4.Name = "lbl12vs4";
            this.lbl12vs4.Size = new System.Drawing.Size(76, 13);
            this.lbl12vs4.TabIndex = 28;
            this.lbl12vs4.Text = "12 vs 4: Stand";
            // 
            // lbl12vs5
            // 
            this.lbl12vs5.AutoSize = true;
            this.lbl12vs5.Location = new System.Drawing.Point(192, 171);
            this.lbl12vs5.Name = "lbl12vs5";
            this.lbl12vs5.Size = new System.Drawing.Size(76, 13);
            this.lbl12vs5.TabIndex = 29;
            this.lbl12vs5.Text = "12 vs 5: Stand";
            // 
            // lbl12vs6
            // 
            this.lbl12vs6.AutoSize = true;
            this.lbl12vs6.Location = new System.Drawing.Point(192, 189);
            this.lbl12vs6.Name = "lbl12vs6";
            this.lbl12vs6.Size = new System.Drawing.Size(76, 13);
            this.lbl12vs6.TabIndex = 30;
            this.lbl12vs6.Text = "12 vs 6: Stand";
            // 
            // lbl11vsA
            // 
            this.lbl11vsA.AutoSize = true;
            this.lbl11vsA.Location = new System.Drawing.Point(192, 207);
            this.lbl11vsA.Name = "lbl11vsA";
            this.lbl11vsA.Size = new System.Drawing.Size(62, 13);
            this.lbl11vsA.TabIndex = 31;
            this.lbl11vsA.Text = "11 vs A: Hit";
            // 
            // lbl10vs10
            // 
            this.lbl10vs10.AutoSize = true;
            this.lbl10vs10.Location = new System.Drawing.Point(192, 225);
            this.lbl10vs10.Name = "lbl10vs10";
            this.lbl10vs10.Size = new System.Drawing.Size(67, 13);
            this.lbl10vs10.TabIndex = 32;
            this.lbl10vs10.Text = "10 vs 10: Hit";
            // 
            // lbl10vsA
            // 
            this.lbl10vsA.AutoSize = true;
            this.lbl10vsA.Location = new System.Drawing.Point(192, 243);
            this.lbl10vsA.Name = "lbl10vsA";
            this.lbl10vsA.Size = new System.Drawing.Size(62, 13);
            this.lbl10vsA.TabIndex = 33;
            this.lbl10vsA.Text = "10 vs A: Hit";
            // 
            // lbl9vs2
            // 
            this.lbl9vs2.AutoSize = true;
            this.lbl9vs2.Location = new System.Drawing.Point(192, 261);
            this.lbl9vs2.Name = "lbl9vs2";
            this.lbl9vs2.Size = new System.Drawing.Size(55, 13);
            this.lbl9vs2.TabIndex = 34;
            this.lbl9vs2.Text = "9 vs 2: Hit";
            // 
            // lbl9vs7
            // 
            this.lbl9vs7.AutoSize = true;
            this.lbl9vs7.Location = new System.Drawing.Point(192, 279);
            this.lbl9vs7.Name = "lbl9vs7";
            this.lbl9vs7.Size = new System.Drawing.Size(55, 13);
            this.lbl9vs7.TabIndex = 35;
            this.lbl9vs7.Text = "9 vs 7: Hit";
            // 
            // lbl20vs5
            // 
            this.lbl20vs5.AutoSize = true;
            this.lbl20vs5.Location = new System.Drawing.Point(192, 297);
            this.lbl20vs5.Name = "lbl20vs5";
            this.lbl20vs5.Size = new System.Drawing.Size(91, 13);
            this.lbl20vs5.TabIndex = 36;
            this.lbl20vs5.Text = "10-10 vs 5: Stand";
            // 
            // lbl20vs6
            // 
            this.lbl20vs6.AutoSize = true;
            this.lbl20vs6.Location = new System.Drawing.Point(192, 315);
            this.lbl20vs6.Name = "lbl20vs6";
            this.lbl20vs6.Size = new System.Drawing.Size(91, 13);
            this.lbl20vs6.TabIndex = 37;
            this.lbl20vs6.Text = "10-10 vs 6: Stand";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 338);
            this.Controls.Add(this.lbl20vs6);
            this.Controls.Add(this.lbl20vs5);
            this.Controls.Add(this.lbl9vs7);
            this.Controls.Add(this.lbl9vs2);
            this.Controls.Add(this.lbl10vsA);
            this.Controls.Add(this.lbl10vs10);
            this.Controls.Add(this.lbl11vsA);
            this.Controls.Add(this.lbl12vs6);
            this.Controls.Add(this.lbl12vs5);
            this.Controls.Add(this.lbl12vs4);
            this.Controls.Add(this.lbl12vs3);
            this.Controls.Add(this.lbl12vs2);
            this.Controls.Add(this.lbl13vs3);
            this.Controls.Add(this.lbl13vs2);
            this.Controls.Add(this.lbl15vs10);
            this.Controls.Add(this.lbl16vs10);
            this.Controls.Add(this.lbl16vs9);
            this.Controls.Add(this.lblInsurance);
            this.Controls.Add(this.lblBetAmount);
            this.Controls.Add(this.lblTrueCount);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.lblRunningCount);
            this.Controls.Add(this.txtDecksUsed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnAce);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack Card Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnAce;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.TextBox txtDecksUsed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRunningCount;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTrueCount;
        private System.Windows.Forms.Label lblBetAmount;
        private System.Windows.Forms.Label lblInsurance;
        private System.Windows.Forms.Label lbl16vs9;
        private System.Windows.Forms.Label lbl16vs10;
        private System.Windows.Forms.Label lbl15vs10;
        private System.Windows.Forms.Label lbl13vs2;
        private System.Windows.Forms.Label lbl13vs3;
        private System.Windows.Forms.Label lbl12vs2;
        private System.Windows.Forms.Label lbl12vs3;
        private System.Windows.Forms.Label lbl12vs4;
        private System.Windows.Forms.Label lbl12vs5;
        private System.Windows.Forms.Label lbl12vs6;
        private System.Windows.Forms.Label lbl11vsA;
        private System.Windows.Forms.Label lbl10vs10;
        private System.Windows.Forms.Label lbl10vsA;
        private System.Windows.Forms.Label lbl9vs2;
        private System.Windows.Forms.Label lbl9vs7;
        private System.Windows.Forms.Label lbl20vs5;
        private System.Windows.Forms.Label lbl20vs6;
    }
}

