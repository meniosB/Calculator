namespace MyCalculator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.equals = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.equals);
            this.panel1.Controls.Add(this.addition);
            this.panel1.Controls.Add(this.subtraction);
            this.panel1.Controls.Add(this.multiplication);
            this.panel1.Controls.Add(this.division);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.comma);
            this.panel1.Controls.Add(this.zero);
            this.panel1.Controls.Add(this.nine);
            this.panel1.Controls.Add(this.eight);
            this.panel1.Controls.Add(this.seven);
            this.panel1.Controls.Add(this.six);
            this.panel1.Controls.Add(this.five);
            this.panel1.Controls.Add(this.four);
            this.panel1.Controls.Add(this.three);
            this.panel1.Controls.Add(this.two);
            this.panel1.Controls.Add(this.one);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 391);
            this.panel1.TabIndex = 1;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Lucida Sans Unicode", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.delete.Location = new System.Drawing.Point(249, 89);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(70, 50);
            this.delete.TabIndex = 19;
            this.delete.Text = "del";
            this.myToolTip.SetToolTip(this.delete, "Backspace");
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equals.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.equals.Location = new System.Drawing.Point(250, 257);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(70, 106);
            this.equals.TabIndex = 18;
            this.equals.Text = "=";
            this.myToolTip.SetToolTip(this.equals, "Enter");
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // addition
            // 
            this.addition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addition.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addition.Location = new System.Drawing.Point(249, 201);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(70, 50);
            this.addition.TabIndex = 17;
            this.addition.Text = "+";
            this.myToolTip.SetToolTip(this.addition, "+");
            this.addition.UseVisualStyleBackColor = false;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // subtraction
            // 
            this.subtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subtraction.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.subtraction.Location = new System.Drawing.Point(249, 145);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(70, 50);
            this.subtraction.TabIndex = 16;
            this.subtraction.Text = "-";
            this.myToolTip.SetToolTip(this.subtraction, "-");
            this.subtraction.UseVisualStyleBackColor = false;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplication.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.multiplication.Location = new System.Drawing.Point(173, 89);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(70, 50);
            this.multiplication.TabIndex = 15;
            this.multiplication.Text = "x";
            this.myToolTip.SetToolTip(this.multiplication, "*");
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.division.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.division.Location = new System.Drawing.Point(97, 89);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(70, 50);
            this.division.TabIndex = 14;
            this.division.Text = "/";
            this.myToolTip.SetToolTip(this.division, "/");
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Red;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.clear.Location = new System.Drawing.Point(22, 89);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(70, 50);
            this.clear.TabIndex = 13;
            this.clear.Text = "C";
            this.myToolTip.SetToolTip(this.clear, "Clear/delete");
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // comma
            // 
            this.comma.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.comma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comma.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comma.Location = new System.Drawing.Point(174, 313);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(70, 50);
            this.comma.TabIndex = 12;
            this.comma.Text = ".";
            this.myToolTip.SetToolTip(this.comma, ".");
            this.comma.UseVisualStyleBackColor = false;
            this.comma.Click += new System.EventHandler(this.comma_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zero.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.zero.Location = new System.Drawing.Point(22, 313);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(146, 50);
            this.zero.TabIndex = 10;
            this.zero.Text = "0";
            this.myToolTip.SetToolTip(this.zero, "0");
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nine.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nine.Location = new System.Drawing.Point(174, 145);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(70, 50);
            this.nine.TabIndex = 9;
            this.nine.Text = "9";
            this.myToolTip.SetToolTip(this.nine, "9");
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eight.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.eight.Location = new System.Drawing.Point(98, 145);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(70, 50);
            this.eight.TabIndex = 8;
            this.eight.Text = "8";
            this.myToolTip.SetToolTip(this.eight, "8");
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seven.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.seven.Location = new System.Drawing.Point(22, 145);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(70, 50);
            this.seven.TabIndex = 7;
            this.seven.Text = "7";
            this.myToolTip.SetToolTip(this.seven, "7");
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.six.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.six.Location = new System.Drawing.Point(174, 201);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(70, 50);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.myToolTip.SetToolTip(this.six, "6");
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.five.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.five.Location = new System.Drawing.Point(98, 201);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(70, 50);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.myToolTip.SetToolTip(this.five, "5");
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.four.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.four.Location = new System.Drawing.Point(22, 201);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(70, 50);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.myToolTip.SetToolTip(this.four, "4");
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.three.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.three.Location = new System.Drawing.Point(174, 257);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(70, 50);
            this.three.TabIndex = 3;
            this.three.Text = "3";
            this.myToolTip.SetToolTip(this.three, "3");
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.two.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.two.Location = new System.Drawing.Point(98, 257);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(70, 50);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.myToolTip.SetToolTip(this.two, "2");
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.one.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.one.Location = new System.Drawing.Point(22, 257);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(70, 50);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.myToolTip.SetToolTip(this.one, "1");
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 391);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ToolTip myToolTip;
    }
}

