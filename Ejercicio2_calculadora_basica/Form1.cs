using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_calculadora_basica
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            InitializeComponent();
            txt_resta.Enabled = false;
            txt_multi.Enabled = false;
            txt_divi.Enabled = false;
            txt_suma.Enabled = false;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            int valor1, valor2;
            //Entrada de datos
            valor1 = int.Parse(txt_valor1.Text);
            valor2 = int.Parse(txt_valor2.Text);
            //Proceso
            int resultado_suma = valor1 + valor2;
            int resultado_resta = valor1 - valor2;
            int resultado_multiplicacion = valor1 * valor2;
            int resultado_division = valor1 / valor2;
            //Salida de datos
            txt_suma.Text = resultado_suma.ToString();
            txt_resta.Text = resultado_resta.ToString();
            txt_multi.Text = resultado_multiplicacion.ToString();
            txt_divi.Text = resultado_division.ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_valor1.Clear();
            txt_valor2.Clear();
            txt_suma.Clear();
            txt_resta.Clear();
            txt_multi.Clear();
            txt_divi.Text = string.Empty;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
