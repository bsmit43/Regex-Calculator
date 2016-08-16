using System.Windows.Forms;

namespace WindowsFormsApplication2
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
            this.plus = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.square_root = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.back = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(374, 475);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(114, 52);
            this.plus.TabIndex = 27;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(254, 475);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(114, 52);
            this.dot.TabIndex = 26;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // equals
            // 
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(494, 387);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(134, 143);
            this.equals.TabIndex = 24;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(374, 417);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(114, 52);
            this.minus.TabIndex = 23;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(254, 417);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(114, 52);
            this.num3.TabIndex = 22;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(374, 358);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(114, 52);
            this.multiply.TabIndex = 18;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // num5
            // 
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(134, 357);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(114, 52);
            this.num5.TabIndex = 17;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(254, 358);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(114, 52);
            this.num6.TabIndex = 16;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(374, 300);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(114, 52);
            this.division.TabIndex = 13;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // num9
            // 
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(254, 298);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(114, 52);
            this.num9.TabIndex = 12;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // square_root
            // 
            this.square_root.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square_root.Location = new System.Drawing.Point(494, 240);
            this.square_root.Name = "square_root";
            this.square_root.Size = new System.Drawing.Size(134, 141);
            this.square_root.TabIndex = 9;
            this.square_root.Text = "√";
            this.square_root.UseVisualStyleBackColor = true;
            this.square_root.Click += new System.EventHandler(this.square_root_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(254, 240);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(234, 52);
            this.clear.TabIndex = 7;
            this.clear.Text = "CE";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 118);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(610, 115);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown_1);
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(18, 18);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(609, 106);
            this.richTextBox2.TabIndex = 28;
            this.richTextBox2.Text = "";
            this.richTextBox2.SelectionAlignment = HorizontalAlignment.Right;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(16, 240);
            this.back.Name = "back";
            this.back.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.back.Size = new System.Drawing.Size(231, 52);
            this.back.TabIndex = 5;
            this.back.Text = "<—";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // num7
            // 
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(16, 300);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(111, 52);
            this.num7.TabIndex = 10;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(134, 298);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(114, 52);
            this.num8.TabIndex = 11;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(16, 358);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(111, 52);
            this.num4.TabIndex = 15;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(134, 418);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(114, 52);
            this.num2.TabIndex = 20;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(16, 418);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(111, 52);
            this.num1.TabIndex = 21;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num0
            // 
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(16, 475);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(231, 52);
            this.num0.TabIndex = 25;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 552);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.back);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.square_root);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.division);
            this.Controls.Add(this.clear);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button square_root;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button back;
        private Button num7;
        private Button num8;
        private Button num4;
        private Button num2;
        private Button num1;
        private Button num0;
    }
}

