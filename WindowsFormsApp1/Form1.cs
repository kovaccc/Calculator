using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string operacija="";
        string drugeoperacije;
        double op1, op2, rez;
        bool isPerformed;
       
    
     
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_broj1_Click(object sender, EventArgs e)
        {
            if (isPerformed == true)
            {
                textBox1.Text = "";
                isPerformed = false;
                textBox1.Text = textBox1.Text + "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_broj2_Click(object sender, EventArgs e)
        {
            if (isPerformed == true)
            {
                textBox1.Text = "";
                isPerformed = false;
                textBox1.Text = textBox1.Text + "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void btn_broj3_Click(object sender, EventArgs e)
        {
            if (isPerformed == true)
            {
                textBox1.Text = "";
                isPerformed = false;
                textBox1.Text = textBox1.Text + "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void btn_broj4_Click(object sender, EventArgs e)
        {
            if (isPerformed == true)
            {
                textBox1.Text = "";
                isPerformed = false;
                textBox1.Text = textBox1.Text + "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void btn_broj5_Click(object sender, EventArgs e)
        {
            if (isPerformed == true)
            {
                textBox1.Text = "";
                isPerformed = false;
                textBox1.Text = textBox1.Text + "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void btn_broj6_Click(object sender, EventArgs e)
        {
            if (isPerformed == true)
            {
                textBox1.Text = "";
                isPerformed = false;
                textBox1.Text = textBox1.Text + "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void btn_broj7_Click(object sender, EventArgs e)
        {
            if (isPerformed == true)
            {
                textBox1.Text = "";
                isPerformed = false;
                textBox1.Text = textBox1.Text + "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void btn_broj8_Click(object sender, EventArgs e)
        {
            if (isPerformed == true)
            {
                textBox1.Text = "";
                isPerformed = false;
                textBox1.Text = textBox1.Text + "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void btn_broj9_Click(object sender, EventArgs e)
        {
            if (isPerformed == true)
            {
                textBox1.Text = "";
                isPerformed = false;
                textBox1.Text = textBox1.Text + "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void btn_broj0_Click(object sender, EventArgs e)
        {
                if (isPerformed == true)
                {
                    textBox1.Text = "";
                    isPerformed = false;
                    textBox1.Text = textBox1.Text + "0";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "0";
                }
          
        }

        private void btn_decimalnizarez_Click(object sender, EventArgs e)
        {
            if (isPerformed == true)
            {
                textBox1.Text = "";
                isPerformed = false;
                textBox1.Text = textBox1.Text + ",";
            }
            else
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
           
            if(operacija == "" )
            {
                operacija = "-";

                try
                {
                    op1 = Convert.ToDouble(textBox1.Text);
                    btn_plus.Hide();
                    btn_minus.Hide();
                    btn_dijeljenje.Hide();
                    btn_mnozenje.Hide();
                    btn_log.Hide();
                    btn_sin.Hide();
                    btn_cos.Hide();
                    btn_sqrt.Hide();
                    btn_tan.Hide();
                    btn_pow.Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Pogresan unos operanda", "Greska");
                }
                textBox1.Text = "";
            }

           
            else
            {
                textBox1.Text = textBox1.Text + "-";
            }

        }

        private void btn_mnozenje_Click(object sender, EventArgs e)
        {
            operacija = "*";
            try
            {
                op1 = Convert.ToDouble(textBox1.Text);
                btn_plus.Hide();
                btn_minus.Hide();
                btn_dijeljenje.Hide();
                btn_mnozenje.Hide();
                btn_log.Hide();
                btn_sin.Hide();
                btn_cos.Hide();
                btn_sqrt.Hide();
                btn_tan.Hide();
                btn_pow.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Pogresan unos operanda", "Greska");
            }
    
            textBox1.Text = "";
        }

        private void btn_dijeljenje_Click(object sender, EventArgs e)
        {
            operacija = "/";
            try
            {
                op1 = Convert.ToDouble(textBox1.Text);
                btn_plus.Hide();
                btn_minus.Hide();
                btn_dijeljenje.Hide();
                btn_mnozenje.Hide();
                btn_log.Hide();
                btn_sin.Hide();
                btn_cos.Hide();
                btn_sqrt.Hide();
                btn_tan.Hide();
                btn_pow.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Pogresan unos operanda", "Greska");
            }
    
            textBox1.Text = "";
        }

        private void btn_jednako_Click(object sender, EventArgs e)
        {
            isPerformed = true;
            if (operacija == "sin" || operacija == "cos" || operacija == "tan" || operacija == "log" || operacija =="sqrt" || operacija =="pow")
            {
                switch (operacija)
                {
                    case "sin":
                        drugeoperacije = textBox1.Text;
                        try
                        {
                            op1 = Convert.ToDouble(drugeoperacije.Substring(3));
                            rez = Math.Sin(op1);
                        }
                        catch (Exception)
                        {
                          
                            MessageBox.Show("Pogresan unos operanda", "Greska");
                        }
                       
                        break;
                    case "log":
                        drugeoperacije = textBox1.Text;
                        try
                        {
                            op1 = Convert.ToDouble(drugeoperacije.Substring(3));
                            rez = Math.Log10(op1);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Pogresan unos operanda", "Greska");
                        }
                        
                        break;
                    case "cos":
                        drugeoperacije = textBox1.Text;
                        try
                        {
                            op1 = Convert.ToDouble(drugeoperacije.Substring(3));
                            rez = Math.Cos(op1);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Pogresan unos operanda", "Greska");
                         
                        }
                     
                        break;
                    case "tan":
                        drugeoperacije = textBox1.Text;
                        try
                        {
                            op1 = Convert.ToDouble(drugeoperacije.Substring(3));
                            rez = Math.Tan(op1);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Pogresan unos operanda", "Greska");
                        }
                       
                        break;
                    case "sqrt":
                        drugeoperacije = textBox1.Text;
                        try
                        {
                            op1 = Convert.ToDouble(drugeoperacije.Substring(1));
                            rez = Math.Sqrt(op1);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Pogresan unos operanda", "Greska");
                        }
                     
                        break;
                    case "pow":  
                        rez = Math.Pow(op1,2);
                        break;
                }
                textBox1.Text = rez.ToString();
            }
            else
            {
                try
                {
                    op2 = Convert.ToDouble(textBox1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Pogresan unos operanda", "Greska");
                }
                switch (operacija)
                {
                    case "+":
                        rez = op1 + op2;
                        break;
                    case "-":
                        rez = op1 - op2;
                        break;
                    case "*":
                        rez = op1 * op2;
                        break;
                    case "/":
                        rez = op1 / op2;
                        break;
                    case "":
                        rez = Convert.ToDouble(textBox1.Text);
                        break;

                }
                textBox1.Text = rez.ToString();
            }
           
            btn_plus.Show();
            btn_minus.Show();
            btn_dijeljenje.Show();
            btn_mnozenje.Show();
            btn_log.Show();
            btn_sin.Show();
            btn_cos.Show();
            btn_sqrt.Show();
            btn_tan.Show();
            btn_pow.Show();
            operacija = "";
         

        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btn_sin_Click(object sender, EventArgs e)
        {
            if (isPerformed == true )
            {
                textBox1.Text = "";
                isPerformed = false;
                operacija = "sin";
                textBox1.Text = textBox1.Text + "sin";
                btn_plus.Hide();
               
                btn_dijeljenje.Hide();
                btn_mnozenje.Hide();
                btn_log.Hide();
                btn_sin.Hide();
                btn_cos.Hide();
                btn_sqrt.Hide();
                btn_tan.Hide();
                btn_pow.Hide();
            }
            else
            {
                operacija = "sin";
                textBox1.Text = textBox1.Text + "sin";
                btn_plus.Hide();
       
                btn_dijeljenje.Hide();
                btn_mnozenje.Hide();
                btn_log.Hide();
                btn_sin.Hide();
                btn_cos.Hide();
                btn_sqrt.Hide();
                btn_tan.Hide();
                btn_pow.Hide();
            }

           

        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            if (isPerformed == true )
            {
                textBox1.Text = "";
                isPerformed = false;
                operacija = "sqrt";
                textBox1.Text = textBox1.Text + "√";
                btn_plus.Hide();
                btn_minus.Hide();
                btn_dijeljenje.Hide();
                btn_mnozenje.Hide();
                btn_log.Hide();
                btn_sin.Hide();
                btn_cos.Hide();
                btn_sqrt.Hide();
                btn_tan.Hide();
                btn_pow.Hide();
            }
            else
            {
                operacija = "sqrt";
                textBox1.Text = textBox1.Text + "√";
                btn_plus.Hide();
                btn_minus.Hide();
                btn_dijeljenje.Hide();
                btn_mnozenje.Hide();
                btn_log.Hide();
                btn_sin.Hide();
                btn_cos.Hide();
                btn_sqrt.Hide();
                btn_tan.Hide();
                btn_pow.Hide();
            }
        }

        private void btn_cos_Click(object sender, EventArgs e)
        {
            if (isPerformed == true )
            {
                textBox1.Text = "";
                isPerformed = false;
                operacija = "cos";
                textBox1.Text = textBox1.Text + "cos";
                btn_plus.Hide();
             
                btn_dijeljenje.Hide();
                btn_mnozenje.Hide();
                btn_log.Hide();
                btn_sin.Hide();
                btn_cos.Hide();
                btn_sqrt.Hide();
                btn_tan.Hide();
                btn_pow.Hide();
            }
            else
            {
                operacija = "cos";
                textBox1.Text = textBox1.Text + "cos";
                btn_plus.Hide();
    
                btn_dijeljenje.Hide();
                btn_mnozenje.Hide();
                btn_log.Hide();
                btn_sin.Hide();
                btn_cos.Hide();
                btn_sqrt.Hide();
                btn_tan.Hide();
                btn_pow.Hide();
            }
        }
            private void btn_tan_Click(object sender, EventArgs e)
        {
            if (isPerformed == true )
            {
                textBox1.Text = "";
                isPerformed = false;
                operacija = "tan";
                textBox1.Text = textBox1.Text + "tan";
                btn_plus.Hide();
        
                btn_dijeljenje.Hide();
                btn_mnozenje.Hide();
                btn_log.Hide();
                btn_sin.Hide();
                btn_cos.Hide();
                btn_sqrt.Hide();
                btn_tan.Hide();
                btn_pow.Hide();
            }
            else
            {
                operacija = "tan";
                textBox1.Text = textBox1.Text + "tan";
                btn_plus.Hide();
       
                btn_dijeljenje.Hide();
                btn_mnozenje.Hide();
                btn_log.Hide();
                btn_sin.Hide();
                btn_cos.Hide();
                btn_sqrt.Hide();
                btn_tan.Hide();
                btn_pow.Hide();
            }
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            if (isPerformed == true )
            {
                textBox1.Text = "";
                isPerformed = false;
                operacija = "log";
                textBox1.Text = textBox1.Text + "log";
                btn_plus.Hide();
                btn_minus.Hide();
                btn_dijeljenje.Hide();
                btn_mnozenje.Hide();
                btn_log.Hide();
                btn_sin.Hide();
                btn_cos.Hide();
                btn_sqrt.Hide();
                btn_tan.Hide();
                btn_pow.Hide();
            }
            else
            {
                operacija = "log";
                textBox1.Text = textBox1.Text + "log";
                btn_plus.Hide();
                btn_minus.Hide();
                btn_dijeljenje.Hide();
                btn_mnozenje.Hide();
                btn_log.Hide();
                btn_sin.Hide();
                btn_cos.Hide();
                btn_sqrt.Hide();
                btn_tan.Hide();
                btn_pow.Hide();
            }

        }

        private void btn_pow_Click(object sender, EventArgs e)
        {
            operacija = "pow";

            textBox1.Text = textBox1.Text + "^2";
            try
            {
                op1 = Convert.ToDouble(textBox1.Text.Substring(0,textBox1.Text.Length - 2));
                btn_plus.Hide();
                btn_minus.Hide();
                btn_dijeljenje.Hide();
                btn_mnozenje.Hide();
                btn_log.Hide();
                btn_sin.Hide();
                btn_cos.Hide();
                btn_sqrt.Hide();
                btn_tan.Hide();
                btn_pow.Hide();

            }
            catch (Exception)
            {
                MessageBox.Show("Pogresan unos operanda", "Greska");
                textBox1.Text = "";
            }

        

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            isPerformed = false;
            op1 = 0;
            op2 = 0;
            rez = 0;
            btn_plus.Show();
            btn_minus.Show();
            btn_dijeljenje.Show();
            btn_mnozenje.Show();
            btn_log.Show();
            btn_sin.Show();
            btn_cos.Show();
            btn_sqrt.Show();
            btn_tan.Show();
            btn_pow.Show();
            textBox1.Text = "";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
           
            operacija = "+";
            try
            {
                op1 = Convert.ToDouble(textBox1.Text);
                btn_plus.Hide();
                btn_minus.Hide();
                btn_dijeljenje.Hide();
                btn_mnozenje.Hide();
                btn_log.Hide();
                btn_sin.Hide();
                btn_cos.Hide();
                btn_sqrt.Hide();
                btn_tan.Hide();
                btn_pow.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Pogresan unos operanda", "Greska");
            }
       
            textBox1.Text = "";
        }
    }
}
