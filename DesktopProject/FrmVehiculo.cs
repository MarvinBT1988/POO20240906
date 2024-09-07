using ConsoleAppPOO2024.INTRO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopProject
{
    public partial class FrmVehiculo : Form
    {
        Vehiculo vehiculo;
        public FrmVehiculo()
        {
            InitializeComponent();
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            vehiculo=new Vehiculo();
            vehiculo.Estado = "Apagado";
            lbVelocidad.Text = vehiculo.Velocidades.ToString() + " Km/h";
            lbEstado.Text = vehiculo.Estado;
            btnAcelerar.Enabled = false;
            btnFrenar.Enabled = false;
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
           vehiculo.Encender();
            lbEstado.Text = vehiculo.Estado;
            btnAcelerar.Enabled = true;
            btnFrenar.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            vehiculo.Apagar();
            lbEstado.Text = vehiculo.Estado;
            vehiculo.Frenar();
            lbVelocidad.Text = vehiculo.Velocidades.ToString() + " Km/h";
            btnAcelerar.Enabled = false;
            btnFrenar.Enabled = false;
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            vehiculo.Acelarar();
            lbVelocidad.Text = vehiculo.Velocidades.ToString() +" Km/h";
        }

        private void btnFrenar_Click(object sender, EventArgs e)
        {
            vehiculo.Frenar();
            lbVelocidad.Text = vehiculo.Velocidades.ToString() + " Km/h";
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (vehiculo.LucesOnOff())
                lbLuces.Text = "Luces encendidas";
            else
                lbLuces.Text = "Luces apagadas";
               
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbVelocidad_Click(object sender, EventArgs e)
        {

        }
    }
}
