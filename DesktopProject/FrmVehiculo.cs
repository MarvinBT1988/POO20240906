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
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
           vehiculo.Encender();
            lbEstado.Text = vehiculo.Estado;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            vehiculo.Apagar();
            lbEstado.Text = vehiculo.Estado;
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            vehiculo.Acelarar();
            lbVelocidad.Text = vehiculo.Velocidades.ToString();
        }

        private void btnFrenar_Click(object sender, EventArgs e)
        {
            vehiculo.Frenar();
            lbVelocidad.Text = vehiculo.Velocidades.ToString();
        }
    }
}
