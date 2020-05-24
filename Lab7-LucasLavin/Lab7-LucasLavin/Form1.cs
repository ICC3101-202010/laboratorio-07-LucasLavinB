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
        Double firstNumber, secondNumber;
        Double ans = 0;
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
            firstNumber = Double.Parse(textDisplay.Text);
            Operacion = b.Text;
            textDisplay.Text = "";
            


        }

        private void Igual_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(textDisplay.Text);
            
            switch (Operacion)
            {
                case "+":
                    textDisplay.Text = Convert.ToString(firstNumber + secondNumber);
                    if (textDisplay.TextLength > 24)
                    {
                        textDisplay.Text= "System ERROR";
                        textDisplay.Text = "0";
                        break;
                    }
                    break;
                case "-":
                    textDisplay.Text = Convert.ToString(firstNumber - secondNumber);
                    if (textDisplay.TextLength > 24)
                    {
                        textDisplay.Text = "System ERROR";
                        textDisplay.Text = "0";

                        break;
                    }
                    break;
                case "/":
                    if (secondNumber!=0)
                    {
                        textDisplay.Text = Convert.ToString(firstNumber / secondNumber);
                        if (textDisplay.TextLength > 24)
                        {
                            textDisplay.Text = "System ERROR";
                            textDisplay.Text = "0";

                            break;
                        }
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
                        textDisplay.Text = "0";

                        break;
                    }
                    break;
                default:
                    textDisplay.Text.Contains("");
                    textDisplay.Text = "System ERROR";
                    break;
            }
            
        }

        private void Punto_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!textDisplay.Text.Contains("."))
            {
                textDisplay.Text += btn.Text;
            }
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
