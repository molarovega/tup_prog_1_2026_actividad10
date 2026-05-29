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
            tbValor.Clear();
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
                lbEncontrado.Text = "No se ingreso nada";
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int enc= servicio.Buscar(Convert.ToInt32(tbBuscar.Text));
            tbResultado.Clear();
            tbBuscar.Clear();
            if (enc > 0)
            {
                tbResultado.Text = "Numero encontrado: " + Convert.ToString(enc);
            }
            else 
            {
                tbResultado.Text = "Numero no encontrado";
            }
            
        }

        private void btnListarOrdenado_Click(object sender, EventArgs e)
        {
            tbResultado.Clear();
            servicio.OrdenarValores();
            for (int i = 0; i < servicio.VerContador(); i++)
            {
                tbResultado.AppendText($"{Convert.ToString(servicio.VerValores(i))}\r\n");
            }

            /*
            #region Comprobacion del metodo ListarValoresSuperiores()
            tbResultado.Clear();
            int cs = 3;
            int[] vasup = new int[cs];
            vasup = servicio.ListarValoresSuperiores(cs);
            for (int a = 0; a < cs; a++)
            {
                tbResultado.AppendText($"{Convert.ToString(vasup[a])}\r\n");
            }
            #endregion
            */

        }
    }
}
