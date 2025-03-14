using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3_FP_G7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void G7_btn_MenuMascotas_Click(object sender, EventArgs e)
        {
            //CREAMOS UN OBJETO 'formDuenio_Mascotas' PARA QUE AL DARLE AL BOTON 'G7_btn_MenuMascotas'
            FormDuenio formDuenio_Mascotas = new FormDuenio();
            //NOS MUESTRE EL FORMULARIO 
            formDuenio_Mascotas.ShowDialog();
        }

        private void btn_Menu_Numeros_Click(object sender, EventArgs e)
        {
            //CREAMOS UN OBJETO 'formNumeros' PARA QUE AL DARLE AL BOTON 'G7_btn_MenuMascotas'
            FormNumeros formNumeros = new FormNumeros();
            //NOS MUESTRE EL FORMULARIO 
            formNumeros.ShowDialog();
        }
    }
}
