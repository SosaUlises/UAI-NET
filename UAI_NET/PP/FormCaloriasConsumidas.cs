using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP
{
    public partial class FormCaloriasConsumidas : Form
    {
        public FormCaloriasConsumidas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string alimento = txtAlimento.Text;
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int indice = -1;
            int resultado = 0;


            for(int i = 0; i < ClassListas.listAlimento.Count; i++)
            {

                if (ClassListas.listAlimento.Contains(alimento))
                {
                     indice = ClassListas.listAlimento.IndexOf(ClassListas.listAlimento[i]);
                }
            }

            if(indice != -1)
            {
                int valorCalorico = Convert.ToInt32(ClassListas.listValorCalorico[indice]);
                resultado = cantidad * valorCalorico;
                ClassListas.ResultadoConsumido.Add(resultado); // Guardamos en la List para resumen

                lblresultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Alimento no encontrado! Debe agregarlo!");
            }
            
            
        }


    }
}
