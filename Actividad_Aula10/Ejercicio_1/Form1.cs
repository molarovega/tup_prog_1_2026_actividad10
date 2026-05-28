using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_1.Models;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        private NumericService servicio = new NumericService();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            servicio.Registrar(Convert.ToInt32(tbValor.Text));
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            double p = servicio.CalcularPromedio();
            if (p > 0)
            {
                lbPromedio.Text = Convert.ToString(p);
            }
            else 
            {
                lbPromedio.Text = "No se ingreso nada";
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //int buscado = Convert.ToInt32(tbBuscar.Text);
            //tbBuscar.Text=Convert.ToString(servicio.Buscar(buscado));
        }

        private void btnListarOrdenado_Click(object sender, EventArgs e)
        {

        }
    }
}
