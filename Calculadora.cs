using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {

        double Primero, Segundo, Resultado;
        string Operacion;
        
        public frmCalculadora()
        {
            InitializeComponent();
        }
        Class.ClsOp op = new Class.ClsOp();
        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";

        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }
        private void btnCuatro_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }


        private void btnCinco_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }
        private void btnNueve_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ",";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text != "")
            {
                Operacion = "+";
                Primero = double.Parse(Pantalla.Text);
                Pantalla.Clear();
            }

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text != "")
            {
                Operacion = "-";
                Primero = double.Parse(Pantalla.Text);
                Pantalla.Clear();
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "-";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text != "")
            {
                Operacion = "/";
                Primero = double.Parse(Pantalla.Text);
                Pantalla.Clear();
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text != "") {
                Operacion = "*";
                Primero = double.Parse(Pantalla.Text);
                Pantalla.Clear();
            }     
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

            if (Pantalla.Text != "") {
                
                
                Segundo = double.Parse(Pantalla.Text);

                switch (Operacion)
                {
                    case "+":
                        Resultado = op.Sumar(Primero, Segundo);
                        Pantalla.Text = Resultado.ToString();
                        break;

                    case "-":
                        Resultado = op.Restar(Primero, Segundo);
                        Pantalla.Text = Resultado.ToString();
                        break;

                    case "*":
                        Resultado = op.Multiplicar(Primero,Segundo);
                        Pantalla.Text = Resultado.ToString();
                        break;

                    case "/":
                        Resultado = op.Dividir(Primero,Segundo);
                        Pantalla.Text = Resultado.ToString();
                        break;
                    case "n!":
                        Resultado = op.Fact(Primero);
                        Pantalla.Text = Resultado.ToString();
                        break;


                }
            }

        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text != "")
            {

                Primero = double.Parse(Pantalla.Text);
                Resultado = op.Fact(Primero);
                Pantalla.Text = Resultado.ToString();
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/ignacio-sabatini-29b45217b/");
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text != "")
            {

                Primero = double.Parse(Pantalla.Text);
                Resultado = Math.Abs(Primero);
                Pantalla.Text = Resultado.ToString();
            }
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text != "")
            {

                Primero = double.Parse(Pantalla.Text);
                Resultado = Math.Sqrt(Primero);
                Pantalla.Text = Resultado.ToString();
            }
        }

        private void btnQuad_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text != "")
            {

                Primero = double.Parse(Pantalla.Text);
                Resultado = Primero*Primero;
                Pantalla.Text = Resultado.ToString();
            }

        }

        private void btnLog10_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text != "")
            {

                Primero = double.Parse(Pantalla.Text);
                Resultado = Math.Log10(Primero);
                Pantalla.Text = Resultado.ToString();
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text != "")
            {

                Primero = double.Parse(Pantalla.Text);
                Resultado = Math.Log(Primero);
                Pantalla.Text = Resultado.ToString();
            }
        }

        private void btnAc_Click(object sender, EventArgs e)
        {

            Pantalla.Clear();
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(Pantalla.Text != "")
            {
                string aux;
                aux = Pantalla.Text;
                aux = aux.Remove(aux.Length - 1);
                Pantalla.Text = aux;

            }

        }
    }
}
