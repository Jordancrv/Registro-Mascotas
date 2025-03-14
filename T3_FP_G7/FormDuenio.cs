using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G7_nm_Duenio;
using G7_nm_Mascota;

namespace T3_FP_G7
{
    public partial class FormDuenio : Form
    {
        //CREAMOS UNA LISTA DE TIPO Duenio EL CUAL SE LLAMA 'G7_Lista_Duenio'
        private List<Duenio> G7_Lista_Duenio = new List<Duenio>();
        //CREAMOS UNA LISTA DE TIPO Mascotas EL CUAL SE LLAMA 'G7_Lista_Mascotas'
        private List<Mascotas> G7_Lista_Mascotas = new List<Mascotas>();
        public FormDuenio()
        {
            InitializeComponent();
            
        }

        private void G7_btn_registrar_Click(object sender, EventArgs e)
        {
            //CREACIÓN DEL BLOQUE TRY-CATCH
            try
            {
                //PRIMERO CREAMOS UN OBJETO DE TIPO MEDICAMENTO, EL CUAL ES 'G7_duenio'
                //LUEGO A SU CONSTRUCTOR LE PASAMOS COMO PARAMETRO LOS VALORES INGRESADOS POR EL USUARIO EN EL FORM
                Duenio G7_duenio = new Duenio(
                    G7_txt_nombre.Text,
                    G7_txt_direc.Text,
                    //LO CONVERTIMOS A INT, YA QUE DEL FORM VIENE COMO STRING
                    int.Parse(G7_txt_telf.Text));
                    G7_cboDuenios.Items.Add(G7_txt_nombre.Text);

                // SI LO QUE PASA EL USUARIO POR EL txt 'G7_txt_nombre.Text' ES DISTINTO DE UN NÚMERO Y LO QUE QUE PASA POR EL txt 'G7_txt_telf' ES UN NUMERO
                if (int.TryParse(G7_txt_nombre.Text, out int numero) == false && int.TryParse(G7_txt_telf.Text, out int n2))
                {
                    //Colocamos un nuevo renglon en la lista 
                    int G7_n = G7_dtgvDuenios.Rows.Add();
                    //Colocamos la infromacion
                    G7_dtgvDuenios.Rows[G7_n].Cells[0].Value = G7_txt_nombre.Text;
                    G7_dtgvDuenios.Rows[G7_n].Cells[1].Value = G7_txt_direc.Text;
                    G7_dtgvDuenios.Rows[G7_n].Cells[2].Value = n2;
                    //AÑADIMOS A LA LISTA 'G7_Lista_Duenio' UN OBJETO 'G7_duenio' CADA VEZ QUE SE REALICE LLAME AL METODO 'G7_btn_registrar_Click'
                    G7_Lista_Duenio.Add(G7_duenio);
                    //POR ULTIMO, LIMPIAMOS LOS TEXTBOX
                    G7_txt_nombre.Clear();
                    G7_txt_direc.Clear();
                    G7_txt_telf.Clear();
                    //REALIZAMOS FOCUS AL 'G7_txt_nombre'
                    G7_txt_nombre.Focus();
                }
               //DE LO CONTRARIO
                else
                {
                    //SE LANZARÁ UNA EXCEPCIÓN CON UN MENSAJE
                    throw new Exception("Ingrese valores validos, segun cada campo.");
                }

            }
            //AL LANZARSE UNA EXCEPCIÓN EL 'catch' LO ATRAPARÁ
            //PASANDOLE COMO PARAMETRO UN OBJETO DE TIPO 'Exception'
            catch (Exception ex)
            {
                //POR LO QUE SE MOSTRARÁ EL SIGUIENTE MENSAJE
                MessageBox.Show($"Error: {ex.Message}", "Validación de Formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void G7_btn_registrar_mascotas_Click(object sender, EventArgs e)
        {
            try
            {
                //PRIMERO CREAMOS UN OBJETO DE TIPO MEDICAMENTO, EL CUAL ES 'G7_duenio'
                //LUEGO A SU CONSTRUCTOR LE PASAMOS COMO PARAMETRO LOS VALORES INGRESADOS POR EL USUARIO EN EL FORM
                Mascotas G7_Mascota = new Mascotas(
                    G7_txt_Mascota.Text,
                    G7_txt_Raza.Text,
                    //LO CONVERTIMOS A INT, YA QUE DEL FORM VIENE COMO STRING
                    int.Parse(G7_txt_edad.Text));

                if (int.TryParse(G7_txt_Mascota.Text, out int numero) == false && int.TryParse(G7_txt_edad.Text, out int G7_n2))
                {
                    //Colocamos un nuevo renglon en la lista 
                    int G7_n = G7_dgv_mascotas.Rows.Add();
                    //Colocamos la infromacion
                    G7_dgv_mascotas.Rows[G7_n].Cells[0].Value = G7_txt_Mascota.Text;
                    G7_dgv_mascotas.Rows[G7_n].Cells[1].Value = G7_n2;
                    G7_dgv_mascotas.Rows[G7_n].Cells[2].Value = G7_txt_Raza.Text;
                    G7_dgv_mascotas.Rows[G7_n].Cells[3].Value = G7_cboDuenios.Text;
                    G7_Lista_Mascotas.Add(G7_Mascota);
                    //POR ULTIMO, LIMPIAMOS LOS TEXTBOX
                    G7_txt_Mascota.Clear();
                    G7_txt_Raza.Clear();
                    G7_txt_edad.Clear();
                    //REALIZAMOS FOCUS AL 'G7_txt_nombre'
                    G7_txt_Mascota.Focus();
                }

                else
                {
                    //SE LANZARÁ UNA EXCEPCIÓN CON UN MENSAJE
                    throw new Exception("Ingrese valores validos, segun cada campo.");
                }

            }

            catch (Exception ex)
            {
                //AL LANZARSE UNA EXCEPCIÓN EL 'catch' LO ATRAPARÁ
                //PASANDOLE COMO PARAMETRO UN OBJETO DE TIPO 'Exception'
                MessageBox.Show($"Error: {ex.Message}", "Validación de Formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void validacionLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan Letras", "Validación de Letras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
 
        private void G7_txt_Mascota_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validacionLetras(e);
        }
        string dato = "";
        //BOTON DE BUSQUEDA
        private void G7_botonBuscarMascotas_Click(object sender, EventArgs e)
        {
            Buscar_en_Grid(G7_dgv_mascotas, 0);
           
        }
       //FUNCION PARA BUSCAR LA MASCOTA
        private void Buscar_en_Grid(DataGridView G7_dg, int col)
        {
          //RECORRE LA LISTA DONDE ESTAN LAS MASCOTAS Y LA CELDA EN LA QUE BUSCARA
            for(int G7_i=0; G7_i < G7_dg.Rows.Count - 1; G7_i++)
            {
                dato = Convert.ToString(G7_dg.Rows[G7_i].Cells[col].Value);
                if (dato == txt_NombreBusMacota.Text.Trim())
                {
                    MessageBox.Show($"La mascota {txt_NombreBusMacota.Text} se encuentra");
                    break;
                }
                else
                {
                    if (txt_NombreBusMacota.Text.Trim() == "")
                    {
                        MessageBox.Show("Ingrese el nombre de la mascota");
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"La mascota {txt_NombreBusMacota.Text} no se encuentra ");
                        break;
                    }

                    
                }
            }
        }
    }
}


