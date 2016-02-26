using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculadora
{
// hello
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1; 
        double ans;
        double result;
        int count;

        // Botão 1
        private void button1_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 1;}

        // Botão 2
        private void button2_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 2;}

        // Botão 3
        private void button3_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 3;}

        // Botão 4
        private void button4_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 4;}

        // Botão 5 
        private void button5_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 5;}

        // Botão 6
        private void button6_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 6;}

        // Botão 7
        private void button7_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 7;}

        // Botão 8
        private void button8_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 8;}

        // Botão 9
        private void button9_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 9;}

        // Botão 0
        private void button10_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + 0;}

        // Botão "="
        private void button16_Click(object sender, EventArgs e){
            compute(count);
        }
        // Operacões
        public void compute(int count){
            switch (count){
                case 1:
                    ans = num1 - Double.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 5:
                    ans = num1 % float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 6:
                    ans = Math.Pow(num1, Double.Parse(textBox1.Text));
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }
        // Botão Adição
        private void button13_Click(object sender, EventArgs e){
            if (textBox1.Text != ""){
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 2;
            }   
        }

        // Botão  "."
        private void button11_Click(object sender, EventArgs e){
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++){
                if (text[i].ToString() == ".") { flag = 1; break; } else { flag = 0; }}
                    if (flag == 0) { textBox1.Text = textBox1.Text + "."; }}

        // Botão Subtração
        private void button12_Click(object sender, EventArgs e){
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1; 
        }

        // Botão Multiplicação
        private void button14_Click(object sender, EventArgs e){
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3; 
        }

        // Botão Divisão
        private void button15_Click(object sender, EventArgs e){
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4; 
        }

        // Botão "C"
        private void button17_Click(object sender, EventArgs e){
            textBox1.Clear();
            count = 0; 
        }

        // Botão "Raiz²"
        private void button18_Click(object sender, EventArgs e){
            double sqrt = Math.Sqrt(float.Parse(textBox1.Text));
            textBox1.Text = sqrt.ToString();
        }

        // Botão Resto da Divisão
        private void button19_Click(object sender, EventArgs e){
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 5;
        }

        // Botão Potenciação
        private void button20_Click(object sender, EventArgs e){
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 6;
        }

        // Botão Seno
        private void button21_Click(object sender, EventArgs e){
            double seno = Math.Sin(float.Parse(textBox1.Text));
            textBox1.Text = seno.ToString();
        }

        // Botão Cosseno
        private void button22_Click(object sender, EventArgs e){
            double Cosseno = Math.Cos(float.Parse(textBox1.Text));
            textBox1.Text = Cosseno.ToString();
        }

        // Botão Tangente
        private void button23_Click(object sender, EventArgs e){
            double Tangente = Math.Tan(float.Parse(textBox1.Text));
            textBox1.Text = Tangente.ToString();
        }

        // Botão Apagar
        private void button24_Click(object sender, EventArgs e){
            int lenght = textBox1.TextLength - 1;
            string text = textBox1.Text;  
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
                textBox1.Text = textBox1.Text + text[i]; 
        }

        // Botão CE
        private void button25_Click(object sender, EventArgs e){
            if (num1 == 0 && textBox1.TextLength > 0)
            { num1 = 0; textBox1.Clear(); }
            else if (num1 > 0 && textBox1.TextLength > 0)
            { textBox1.Clear(); }
        }

        // Botão Cálculo Fatorial Iterativo
        private void button26_Click(object sender, EventArgs e){
            result = Fatorial_Iterativa(Double.Parse(textBox1.Text));
            textBox1.Text = Convert.ToString(result);
        }
        private double Fatorial_Iterativa(double value){
            double num = value;
            for (double i = num - 1; i > 1; i--){
                num *= i;
            }
            return num;
        }

        // Botão Cálculo Fatorial Recursivo
        private void button27_Click(object sender, EventArgs e){
            result = Fatorial_Recursivo(Double.Parse(textBox1.Text));
            textBox1.Text = Convert.ToString(result);
        }
        // Botão Recursivo Fatorial
        private double Fatorial_Recursivo(double value){
            double num = value;
            if (num <= 1) return num = 1;
            return num = num * Fatorial_Recursivo(num - 1);
        }

        //Botão Iterativa Fibonacci
        private void button28_Click(object sender, EventArgs e){
            result = Fibonacci_Iterativa(Double.Parse(textBox1.Text));
            textBox1.Text = Convert.ToString(result);
        }
        //Iterativa Fibonacci
        private double Fibonacci_Iterativa(double value){
            if (value <= 2)
                return 1;

            double p = 1, s = 1;

            for (double i = 2; i < value; i++){
                double temp = p + s;
                p = s;
                s = temp;
            }

            return s;
        }

        // Botão Recursiva Fibonacci
        private void button29_Click(object sender, EventArgs e){
            result = Fibonacci_Recursiva(Double.Parse(textBox1.Text));
            textBox1.Text = Convert.ToString(result);
        }

        //Recursiva Fibonacci
        private double Fibonacci_Recursiva(double x){
            if (x <= 2){
                return 1;
            }
            return Fibonacci_Recursiva(x - 1) + Fibonacci_Recursiva(x - 2);
        }  
    }
}
