using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        //initaliaze starting values for calculator
        string input = "0";
        double total = 0;
        //initialize a variable to represent any operator
        char operation;
        //Match all variations that include an addition operator
        Regex add = new Regex(@"[0-9]+\+[0-9]+|[0-9]+\+[0-9]+");
        //Match all variations that include an subtract operator
        Regex subtract = new Regex(@"[0-9]+\-[0-9]+|\-[0-9]+\-[0-9]+");
        //Match all variations that begin wtih a subtract operator
        Regex negative = new Regex(@"\-[0-9]+\-[0-9]+|\-[0-9]+\.[0-9]+\-[0-9]+\-[0-9]+\.[0-9]+|\-[0-9]+\.[0-9]+\-[0-9]+|\-[0-9]+\-[0-9]+\.[0-9]");
        //Match all variations that include any operator
        Regex multi = new Regex(@"[0-9]+\*[0-9]+|\-[0-9]+\*[0-9]+");
        //Match all variations that include a division operator
        Regex divide = new Regex(@"[0-9]+\/[0-9]+");
        //Match all variations that include bothe the add and subtract operator
        Regex addsub = new Regex(@"\-[0-9]+\+[0-9]+");
        //Match any two operators next to each other
        Regex wrong = new Regex(@"\+\-|\-\+|\+\-\*");
        //Match the specied pattern that calculations should be in
        Regex pattern = new Regex(@"[0-9]\+[0-9]\+|\-[0-9]\-[0-9]\-|\-[0-9]|[0-9]\-[0-9]\-|\*|\/|[0-9]\-[0-9]");
        //Match all operation that include zero as the only or starting number
        Regex zero = new Regex(@"0\/0|\-[0-9]+\/0|[0-9]+\/0|\-[0-9]+\.\[0-9]+/0|[0-9]+\.[0-9]\/0|0\/[0-9]+|0\/[0-9]+\.\[0-9]|-0\/\-[0-9]");

        public Form1()
        {
            InitializeComponent();
            //input = "0";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void equals_Click(object sender, EventArgs e)
        {
            //Match all regexes to calculator textbox value
            Match p = add.Match(richTextBox1.Text);
            Match s = subtract.Match(richTextBox1.Text);
            Match m = multi.Match(richTextBox1.Text);
            Match d = divide.Match(richTextBox1.Text);
            Match n = negative.Match(richTextBox1.Text);
            Match b = addsub.Match(richTextBox1.Text);
            Match z = zero.Match(richTextBox1.Text);

            //Split the text at the operator to get the numbers and place them in an array
            string[] operate = richTextBox1.Text.Split(operation);
            try
            {   //if the operation performed was addition and the textbox matches the addition regex then perform
                if (operation == '+' && p.Success)
                {
                    //add the first and second number in the operate array together
                    total = double.Parse(operate[0]) + double.Parse(operate[1]);
                }

                if (operation == '-' && !n.Success && !b.Success)
                {
                    total = double.Parse(operate[0]) - double.Parse(operate[1]);
                }
                if (n.Success)
                {
                    operation = '-';
                    string firstpart = richTextBox1.Text.Split(operation)[1];
                    string secondpart = richTextBox1.Text.Split(operation)[2];
                    //string won = operate[0];
                    total = 0 - double.Parse(firstpart);
                    total = total - double.Parse(secondpart);
                }
                else if (b.Success)
                {
                    operation = '+';
                    string firstpart = richTextBox1.Text.Split(operation)[0];
                    string secondpart = richTextBox1.Text.Split(operation)[1];
                    //string won = operate[0];
                    total = double.Parse(firstpart) + double.Parse(secondpart);
                }

                if (operation == '*' && m.Success)
                {
                    total = double.Parse(operate[0]) * double.Parse(operate[1]);
                }

                if (operation == '/' && d.Success && !z.Success)
                {
                        total = double.Parse(operate[0]) / double.Parse(operate[1]);
                }

                if (operation == '±')
                {
                    operation = '-';
                    string firstpart = richTextBox1.Text.Split(operation)[1];
                    string secondpart = richTextBox1.Text.Split(operation)[2];
                    //string won = operate[0];
                    total = 0 - double.Parse(firstpart);
                    total = total - double.Parse(secondpart);
                }
                if (z.Success)
                {
                    richTextBox1.Text = "Result is undefined";
                }
                else
                {
                    richTextBox1.Text = total.ToString();
                }
            }
            catch
            {
            }
        }
        

        private void plus_Click(object sender, EventArgs e)
        {
            Match p = add.Match(richTextBox1.Text);
            Match s = subtract.Match(richTextBox1.Text);
            Match m = multi.Match(richTextBox1.Text);
            Match d = divide.Match(richTextBox1.Text);
            Match n = negative.Match(richTextBox1.Text);
            Match pat = pattern.Match(richTextBox1.Text);

                try
                {
                    if (richTextBox1.Text == "" || richTextBox1.Text == "-")
                    {
                        richTextBox1.Text = "";
                    }
                    else
                    {
                        string last = richTextBox1.Text.Substring(richTextBox1.Text.Length - 1);
                        int nr;
                        bool isNumeric = int.TryParse(last.ToString(), out nr);
                        if (isNumeric)
                        {
                            if (p.Success)
                            {
                                operation = '+';
                                equals.PerformClick();
                                richTextBox1.Text += operation;
                                richTextBox2.Text += operation;

                            }
                            else if (!n.Success && s.Success)
                            {
                                operation = '-';
                                equals.PerformClick();
                                richTextBox1.Text = total.ToString();
                                operation = '+';
                                richTextBox1.Text += operation;
                                richTextBox2.Text += operation;

                            }
                            else if (m.Success)
                            {
                                operation = '*';
                                equals.PerformClick();
                                richTextBox1.Text = total.ToString();
                                operation = '+';
                                richTextBox1.Text += operation;
                                richTextBox2.Text += operation;

                            }
                            else if (p.Success)
                            {
                                operation = '/';
                                equals.PerformClick();
                                richTextBox1.Text = total.ToString();
                                operation = '+';
                                richTextBox1.Text += operation;
                                richTextBox2.Text += operation;

                            }
                            else if (n.Success)
                            {
                                operation = '±';
                                equals.PerformClick();
                                operation = '+';
                                richTextBox1.Text += operation;
                                richTextBox2.Text += operation;
                            }
                            else
                            {
                                operation = '+';
                                richTextBox1.Text += operation;
                                richTextBox2.Text += operation;

                            }
                        }
                        else
                    {
                        int index = richTextBox1.Text.LastIndexOfAny(new char[] { '+','-', '*', '/' });
                        string change = richTextBox1.Text.Substring(0, index);                                           
                            richTextBox1.Text = change + "+";
                            richTextBox2.Text = change + "+";
                    }
                }
           }
            catch
                 {
                 }
         }


        private void minus_Click(object sender, EventArgs e)
        {
            Match p = add.Match(richTextBox1.Text);
            Match s = subtract.Match(richTextBox1.Text);
            Match m = multi.Match(richTextBox1.Text);
            Match d = divide.Match(richTextBox1.Text);
            Match n = negative.Match(richTextBox1.Text);
            Match w = wrong.Match(richTextBox1.Text);
            Match w1 = wrong.Match(richTextBox2.Text);
            Match pat = pattern.Match(richTextBox2.Text);

            try
            {
                if (richTextBox1.Text == "" || richTextBox1.Text == "-")
                {
                    richTextBox1.Text = "-";
                }
                else
                {
                    string last = richTextBox1.Text.Substring(richTextBox1.Text.Length - 1);
                    int nr;
                    bool isNumeric = int.TryParse(last.ToString(), out nr);
                    if (isNumeric == true)
                    {
                        if (p.Success)
                        {
                            operation = '+';
                            equals.PerformClick();
                            richTextBox1.Text = total.ToString();
                            operation = '-';
                            richTextBox1.Text += operation;
                            richTextBox2.Text += operation;
                        }
                        else if (!n.Success && s.Success)
                        {
                            operation = '-';
                            equals.PerformClick();
                            richTextBox1.Text = total.ToString();
                            richTextBox1.Text += operation;
                            richTextBox2.Text += operation;
                        }
                        else if (m.Success)
                        {
                            operation = '*';
                            equals.PerformClick();
                            richTextBox1.Text = total.ToString();
                            operation = '-';
                            richTextBox1.Text += operation;
                            richTextBox2.Text += operation;
                        }
                        else if (d.Success)
                        {
                            operation = '/';
                            equals.PerformClick();
                            richTextBox1.Text = total.ToString();
                            operation = '-';
                            richTextBox1.Text += operation;
                            richTextBox2.Text += operation;
                        }
                        else if (n.Success)
                        {
                            operation = '±';
                            equals.PerformClick();
                            operation = '-';
                            richTextBox1.Text += operation;
                            richTextBox2.Text += operation;
                        }
                        else
                        {
                            operation = '-';
                            input += operation;
                            richTextBox1.Text += operation;
                            richTextBox2.Text += operation;
                        }
                    }
                    else
                    {
                        int index = richTextBox1.Text.LastIndexOfAny(new char[] { '+', '-', '*', '/' });
                        string change = richTextBox1.Text.Substring(0, index);                                                
                            richTextBox1.Text = change + "-";
                            richTextBox2.Text = change + "-";
                    }
                }
            }
            catch
            {
            }
        }          

        private void multiply_Click(object sender, EventArgs e)
        {
            Match p = add.Match(richTextBox1.Text);
            Match s = subtract.Match(richTextBox1.Text);
            Match m = multi.Match(richTextBox1.Text);
            Match d = divide.Match(richTextBox1.Text);
            Match n = negative.Match(richTextBox1.Text);
            Match w = wrong.Match(richTextBox1.Text);
            Match w1 = wrong.Match(richTextBox2.Text);
            Match pat = pattern.Match(richTextBox2.Text);

            try
            {
                if (richTextBox1.Text == "" || richTextBox1.Text == "-")
                {
                    richTextBox1.Text = "";
                }
                else
                {
                    char last = richTextBox1.Text[richTextBox1.Text.Length - 1];
                    int nr;
                    bool isNumeric = int.TryParse(last.ToString(), out nr);
                    if (isNumeric)
                    {
                        if (p.Success)
                        {
                            operation = '+';
                            equals.PerformClick();
                            richTextBox1.Text = total.ToString();
                            operation = '*';
                            richTextBox1.Text += operation;
                            richTextBox2.Text += operation;
                        }
                        else if (!n.Success && s.Success)
                        {
                            operation = '-';
                            equals.PerformClick();
                            richTextBox1.Text = total.ToString();
                            operation = '*';
                            richTextBox1.Text += operation;
                            richTextBox2.Text += operation;
                        }
                        else if (m.Success)
                        {
                            operation = '*';
                            equals.PerformClick();
                            richTextBox1.Text = total.ToString();
                            richTextBox1.Text += operation;
                            richTextBox2.Text += operation;
                        }
                        else if (d.Success)
                        {
                            operation = '/';
                            equals.PerformClick();
                            richTextBox1.Text = total.ToString();
                            operation = '*';
                            richTextBox1.Text += operation;
                            richTextBox2.Text += operation;
                        }
                        else if (n.Success)
                        {
                            operation = '±';
                            equals.PerformClick();
                            operation = '*';
                            richTextBox1.Text += operation;
                            richTextBox2.Text += operation;
                        }
                        else
                        {
                            operation = '*';
                            richTextBox1.Text += operation;
                            richTextBox2.Text += operation;
                        }
                    }
                    else
                    {
                        int index = richTextBox1.Text.LastIndexOfAny(new char[] { '+', '-', '*', '/' });
                        string change = richTextBox1.Text.Substring(0, index);
                            richTextBox1.Text = change + "*";
                            richTextBox2.Text = change + "*";
                    }
                }
            }
            catch
            {
            }
        }
        

        private void division_Click(object sender, EventArgs e)
        {
            Match p = add.Match(richTextBox1.Text);
            Match s = subtract.Match(richTextBox1.Text);
            Match m = multi.Match(richTextBox1.Text);
            Match d = divide.Match(richTextBox1.Text);
            Match n = negative.Match(richTextBox1.Text);
            Match w = wrong.Match(richTextBox1.Text);
            Match w1 = wrong.Match(richTextBox2.Text);
            Match pat = pattern.Match(richTextBox2.Text);

            try
            {
                if (richTextBox1.Text == "" || richTextBox1.Text == "-")
                {
                    richTextBox1.Text = "";
                }
                else
                {
                    char last = richTextBox1.Text[richTextBox1.Text.Length - 1];
                    int nr;
                    bool isNumeric = int.TryParse(last.ToString(), out nr);
                    if (isNumeric)
                    {
                        if (p.Success)
                        {
                            operation = '+';
                            equals.PerformClick();
                            richTextBox1.Text = total.ToString();
                            operation = '/';
                            richTextBox1.Text += operation;
                            richTextBox2.Text += operation;
                        }
                        else if (!n.Success && s.Success)
                        {
                            operation = '-';
                            equals.PerformClick();
                            richTextBox1.Text = total.ToString();
                            operation = '/';
                            richTextBox1.Text += operation;
                            richTextBox2.Text += operation;
                        }
                        else if (m.Success)
                        {
                            operation = '*';
                            equals.PerformClick();
                            richTextBox1.Text = total.ToString();
                            operation = '/';
                            richTextBox1.Text += operation;
                            richTextBox2.Text += operation;
                        }
                        else if (d.Success)
                        {
                            operation = '/';
                            equals.PerformClick();
                            richTextBox1.Text = total.ToString();
                            richTextBox1.Text += operation;
                            richTextBox2.Text += operation;
                        }
                        else if (n.Success)
                        {
                            operation = '±';
                            equals.PerformClick();
                            operation = '/';
                            richTextBox1.Text += operation;
                            richTextBox2.Text += operation;
                        }
                        else
                        {
                            operation = '/';
                            richTextBox1.Text += operation;
                            richTextBox2.Text += operation;
                        }
                    }
                    else
                    {
                        int index = richTextBox1.Text.LastIndexOfAny(new char[] { '+', '-', '*', '/' });
                        string change = richTextBox1.Text.Substring(0, index);
                            richTextBox1.Text = change + "/";
                            richTextBox2.Text = change + "/";
                    }
                }
            }
            catch
            {
            }

            }

        private void square_root_Click(object sender, EventArgs e)
        {
            try
            {
                operation = '√';
                //equals.PerformClick();
                total = Math.Sqrt(double.Parse(richTextBox1.Text));
                //input = total.ToString();
                richTextBox1.Text = total.ToString();
                richTextBox2.Text = total.ToString();
                input = string.Empty;
            }
            catch { }     
        }

        private void percent_Click(object sender, EventArgs e)
        {
            operation = '%';
            total = total + double.Parse(richTextBox1.Text);
            //input = total.ToString();      
            richTextBox1.Text += operation;
            richTextBox2.Text += operation;
            input = string.Empty;
        }

        private void button20_Click(object sender, EventArgs e)
        {
         
        }
       
        private void num0_Click(object sender, EventArgs e)
        {         
            input += "0";
            richTextBox1.Text += "0";
            richTextBox2.Text += "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            input += "1";
            richTextBox1.Text += "1";
            richTextBox2.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            input += "2";
            richTextBox1.Text += "2";
            richTextBox2.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            input += "3";
            richTextBox1.Text += "3";
            richTextBox2.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            input += "4";
            richTextBox1.Text += "4";
            richTextBox2.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            input += "5";
            richTextBox1.Text += "5";
            richTextBox2.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            input += "6";
            richTextBox1.Text += "6";
            richTextBox2.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            input += "7";
            richTextBox1.Text += "7";
            richTextBox2.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            input += "8";
            richTextBox1.Text += "8";
            richTextBox2.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            input += "9";
            richTextBox1.Text += "9";
            richTextBox2.Text += "9";
        }
        private void dot_Click(object sender, EventArgs e)
        {
            try
            {
                int count = richTextBox1.Text.Count(x => x == '.');
                if (richTextBox1.Text.Any(char.IsDigit) && !Regex.IsMatch(richTextBox1.Text, @"\+|\-|\*|\/"))
                {
                    if (count < 1)
                    {
                        this.richTextBox1.Text += ".";
                        this.richTextBox2.Text += ".";
                    }
                }
                var result = richTextBox1.Text.Substring(richTextBox1.Text.LastIndexOfAny(new char[] { '+', '-', '*', '/' }) + 1);
                int count1 = result.Count(x => x == '.');
                if (Regex.IsMatch(richTextBox1.Text, @"\+[0-9]|\-[0-9]|\*[0-9]|\/[0-9]"))
                {
                    if (count1 < 1)
                    {
                        this.richTextBox1.Text += ".";
                        this.richTextBox2.Text += ".";
                    }        
                }
            }
            catch
            {
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            this.richTextBox2.Text = string.Empty;
            this.richTextBox1.Text = string.Empty;
            this.total = 0;
            operation = '0';
            input = string.Empty;
        }

        private void back_Click(object sender, EventArgs e)
        {
            string s = richTextBox1.Text;
            string s1 = richTextBox2.Text;
            string s2 = input;

            if (s.Length > 1)
            {
                richTextBox1.Text = "0";
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "";
            }

            if (s1.Length > 1)
            {
                this.richTextBox2.Text = "0";
                s1 = s1.Substring(0, s1.Length - 1);
            }
            else
            {
                s1 = "";
            }
            richTextBox1.Text = s;
            this.richTextBox2.Text = s1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.D0) || e.KeyCode.Equals(Keys.NumPad0))
            {
                num0.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D1) || e.KeyCode.Equals(Keys.NumPad1))
            {
                num1.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D2) || e.KeyCode.Equals(Keys.NumPad2))
            {
                num2.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D3) || e.KeyCode.Equals(Keys.NumPad3))
            {
                num3.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D4) || e.KeyCode.Equals(Keys.NumPad4))
            {
                num4.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D5) || e.KeyCode.Equals(Keys.NumPad5))
            {
                num5.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D6) || e.KeyCode.Equals(Keys.NumPad6))
            {
                num6.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D7) || e.KeyCode.Equals(Keys.NumPad7))
            {
                num7.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D8) || e.KeyCode.Equals(Keys.NumPad8))
            {
                num8.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D9) || e.KeyCode.Equals(Keys.NumPad9))
            {
                num9.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Add))
            {
                plus.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Subtract))
            {
                minus.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Multiply))
            {
                multiply.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Divide))
            {
                division.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Enter))
            {
                equals.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Delete))
            {
                clear.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Back))
            {
                back.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Decimal))
            {
                dot.PerformClick();
            }
        }
    }
}
