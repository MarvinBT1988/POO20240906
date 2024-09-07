using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleAppPOO2024.INTRO;
namespace DesktopProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Calculadora fx85 = new Calculadora();
            fx85.Numero1 = double.Parse(txtNumero1.Text);
            fx85.Numero2= double.Parse(txtNumero2.Text);
            txtResultado.Text=fx85.Sumar().ToString();            
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            Calculadora fx85 = new Calculadora();
            fx85.Numero1 = double.Parse(txtNumero1.Text);
            fx85.Numero2 = double.Parse(txtNumero2.Text);
            txtResultado.Text = fx85.Restar().ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Calculadora fx85 = new Calculadora();
            fx85.Numero1 = double.Parse(txtNumero1.Text);
            fx85.Numero2 = double.Parse(txtNumero2.Text);
            txtResultado.Text = fx85.Multiplicar().ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Calculadora fx85 = new Calculadora();
            fx85.Numero1 = double.Parse(txtNumero1.Text);
            fx85.Numero2 = double.Parse(txtNumero2.Text);
            if (fx85.Numero2 > 0)
                txtResultado.Text = fx85.Dividir().ToString();
            else
                MessageBox.Show("El numero 2 deber ser mayor a cero");
        }
    }
}
