using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_LucasLavin
{
    public partial class CalculadoraLucasLavin : Form
    {
        // Variables a usar
        String Operacion = "";
        Decimal firstNumber=0.0m, secondNumber=0.0m;
        Decimal ans = 0.0m;
        int milliseconds = 2000;
        
        public CalculadoraLucasLavin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (textDisplay.TextLength > 0)
                {
                    textDisplay.Text = textDisplay.Text.Remove(textDisplay.TextLength - 1, 1);
                }
            if (textDisplay.TextLength == 0)
            {
                textDisplay.Text = "0";
            }
            
        }



        private void Operaciones(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstNumber = Decimal.Parse(textDisplay.Text);
            Operacion = b.Text;
            textDisplay.Text = "";
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            secondNumber = Decimal.Parse(textDisplay.Text);
            
            switch (Operacion)
            {
                case "+":
                    textDisplay.Text = Convert.ToString(firstNumber + secondNumber);
                    if (textDisplay.TextLength > 24)
                    {
                        textDisplay.Text= "System ERROR";
                        System.Threading.Thread.Sleep(milliseconds);
                        textDisplay.Text = "0";
                        break;
                    }
                    ans = Decimal.Parse(textDisplay.Text);
                    break;
                case "-":
                    textDisplay.Text = Convert.ToString(firstNumber - secondNumber);
                    if (textDisplay.TextLength > 24)
                    {
                        textDisplay.Text = "System ERROR";
                        System.Threading.Thread.Sleep(milliseconds);
                        textDisplay.Text = "0";

                        break;
                    }
                    ans = Decimal.Parse(textDisplay.Text);
                    break;
                case "/":
                    if (secondNumber!=0)
                    {
                        textDisplay.Text = Convert.ToString(firstNumber / secondNumber);
                        
                        if (textDisplay.TextLength > 24)
                        {
                            textDisplay.Text = "System ERROR";
                            System.Threading.Thread.Sleep(milliseconds);
                            textDisplay.Text = "0";

                            break;
                        }
                        ans = Decimal.Parse(textDisplay.Text);
                    }
                    else
                    {
                        textDisplay.Text = "Math ERROR";
                    }   
                    break;
                case "x":
                    textDisplay.Text = Convert.ToString(firstNumber * secondNumber);
                    if (textDisplay.TextLength > 24)
                    {
                        textDisplay.Text = "System ERROR";
                        System.Threading.Thread.Sleep(milliseconds);
                        textDisplay.Text = "0";

                        break;
                    }
                    ans = Decimal.Parse(textDisplay.Text);

                    break;
                default:
                    textDisplay.Text.Contains("");
                    textDisplay.Text = "System ERROR";
                    break;
            }
            
        }

        private void Punto_Click(object sender, EventArgs e)
        {
            // Funciona poner el punto, pero no los calcula como decimal, sino que como enteros.
            Button btn = (Button)sender;
            if (!textDisplay.Text.Contains("."))
            {
                textDisplay.Text += btn.Text;
            }
        }

        private void Ans_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textDisplay.Text = Convert.ToString(ans);

        }

        private void Historial_Click(object sender, EventArgs e)
        {
            
        }

        private void Numeros(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textDisplay.Text == "0")
            {
                textDisplay.Clear();

            }
            textDisplay.Text = textDisplay.Text + btn.Text;

        }




    }
}
