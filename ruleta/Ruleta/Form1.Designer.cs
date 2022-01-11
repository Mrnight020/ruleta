namespace Ruleta
{
    partial class start
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start));
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.zetony = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vsazenyzetony = new System.Windows.Forms.TextBox();
            this.RNG = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(245, 323);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(45, 36);
            this.seven.TabIndex = 0;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(310, 323);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(45, 36);
            this.eight.TabIndex = 1;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(390, 268);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(45, 36);
            this.one.TabIndex = 2;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(390, 208);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(45, 36);
            this.two.TabIndex = 3;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(310, 148);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(45, 36);
            this.three.TabIndex = 4;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(245, 148);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(45, 36);
            this.four.TabIndex = 5;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(167, 208);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(45, 36);
            this.five.TabIndex = 6;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(167, 268);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(45, 36);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Počet žetonů:";
            // 
            // zetony
            // 
            this.zetony.AutoSize = true;
            this.zetony.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zetony.Location = new System.Drawing.Point(246, 23);
            this.zetony.Name = "zetony";
            this.zetony.Size = new System.Drawing.Size(55, 29);
            this.zetony.TabIndex = 9;
            this.zetony.Text = "500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kolik chceš vsadit žetonů ?";
            // 
            // vsazenyzetony
            // 
            this.vsazenyzetony.Location = new System.Drawing.Point(433, 70);
            this.vsazenyzetony.Name = "vsazenyzetony";
            this.vsazenyzetony.Size = new System.Drawing.Size(144, 22);
            this.vsazenyzetony.TabIndex = 11;
            this.vsazenyzetony.TextChanged += new System.EventHandler(this.vsazenyzetony_TextChanged);
            // 
            // RNG
            // 
            this.RNG.AutoSize = true;
            this.RNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RNG.ForeColor = System.Drawing.Color.Gold;
            this.RNG.Location = new System.Drawing.Point(290, 242);
            this.RNG.Name = "RNG";
            this.RNG.Size = new System.Drawing.Size(0, 25);
            this.RNG.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(475, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 74);
            this.button1.TabIndex = 13;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(603, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RNG);
            this.Controls.Add(this.vsazenyzetony);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zetony);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "start";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label zetony;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vsazenyzetony;
        private System.Windows.Forms.Label RNG;
        private System.Windows.Forms.Button button1;
    }
}

