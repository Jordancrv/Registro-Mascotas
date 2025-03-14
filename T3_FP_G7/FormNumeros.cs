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
    public partial class FormNumeros : Form
    {
        //CREAMOS UNA LISTA DE TIPO int EL CUAL SE LLAMA 'G7_lista_numeros'
        private List<int> G7_lista_numeros = new List<int>();
        public FormNumeros()
        {
            InitializeComponent();
        }

        private void btn_registrar_num_Click(object sender, EventArgs e)
        {
            //CREACIÓN DEL BLOQUE TRY-CATCH
            try
            {
                //SI LO QUE PASA EL USUARIO POR EL txt 'G7_txt_num.Text' ES UN NÚMERO
                //LO TRATARÁ DE PARSEAR A UN ENTERO
                if (int.TryParse(G7_txt_num.Text, out int numero))
                {
                    //Colocamos un nuevo renglon en la lista 
                    int G7_n = G7_dtgv_numeros.Rows.Add();
                    //Se colocará el numero parseado en la celda correspondiente
                    G7_dtgv_numeros.Rows[G7_n].Cells[0].Value = numero;
                    // Y Añadimos a la lista 'G7_lista_numeros' el número 
                    G7_lista_numeros.Add(numero);
                }
                //DE LO CONTRARIO
                else
                {
                    //SE LANZARÁ UNA EXCEPCIÓN CON UN MENSAJE
                    throw new Exception("Ingrese un valor Númerico.");
                }
            }
            //AL LANZARSE UNA EXCEPCIÓN EL 'catch' LO ATRAPARÁ
            //PASANDOLE COMO PARAMETRO UN OBJETO DE TIPO 'Exception'
            catch (Exception ex)
            {
                //POR LO QUE SE MOSTRARÁ EL SIGUIENTE MENSAJE
                MessageBox.Show($"Error: {ex.Message}", "Validación de Número", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //LIMPIAMOS EL txt 'G7_txt_num'
            G7_txt_num.Clear();
            //REALIZAMOS FOCUS AL txt 'G7_txt_num'
            G7_txt_num.Focus();
        }

        private void btn_eliminar_numero_Click(object sender, EventArgs e)
        {
            //REALIZACIÓN DEL BLOQUE TRY-CATCH
            try
            {
                string G7_numeroEliminar = G7_txt_num.Text;

                if (string.IsNullOrEmpty(G7_numeroEliminar))
                {
                    //SE LANZARÁ UNA EXCEPCIÓN CON UN MENSAJE
                    throw new Exception("Ingrese un número para eliminar.");
                }

                if (!int.TryParse(G7_numeroEliminar, out int G7_numero))
                {
                    //SE LANZARÁ UNA EXCEPCIÓN CON UN MENSAJE
                    throw new Exception("Ingrese un número válido.");
                }

                if (!G7_lista_numeros.Contains(G7_numero))
                {
                    //SE LANZARÁ UNA EXCEPCIÓN CON UN MENSAJE
                    throw new Exception("El número no se encuentra en la lista.");
                }

                // Eliminar el número de la lista
                G7_lista_numeros.Remove(G7_numero);

                // Buscar la fila en el DataGridView que corresponde al número
                DataGridViewRow G7_filaAEliminar = null;
                foreach (DataGridViewRow G7_fila in G7_dtgv_numeros.Rows)
                {
                    if (G7_fila.Cells[0].Value != null && G7_fila.Cells[0].Value.ToString() == G7_numeroEliminar)
                    {
                        G7_filaAEliminar = G7_fila;
                        break;
                    }
                }

                if (G7_filaAEliminar != null)
                {
                    G7_dtgv_numeros.Rows.Remove(G7_filaAEliminar);
                    MessageBox.Show("Número eliminado correctamente.");
                }

                G7_txt_num.Clear(); // Limpiar el cuadro de texto después de la eliminación.
            }
            //AL LANZARSE UNA EXCEPCIÓN EL 'catch' LO ATRAPARÁ
            //PASANDOLE COMO PARAMETRO UN OBJETO DE TIPO 'Exception'
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void G7_btnOrdenar_Click(object sender, EventArgs e)
        {
            //USO DE PROPIEDAD SORT DEL DATAGREDVIEW
            if (G7_dtgv_numeros.Columns.Contains("Column1"))
            {
                G7_dtgv_numeros.Sort(G7_dtgv_numeros.Columns["Column1"], ListSortDirection.Descending);
            }
        }
        private bool BuscarNumeroEnLista(List<int> lista, int numero, int valor = 0)
        {
            if (valor >= lista.Count)
            {
                return false; // EL NUMERO NO SE ENCONTRO EN LA LISTA
            }

            if (lista[valor] == numero)
            {
                return true; // EL NUMERO SE ENCONTRO EN LA LISTA
            }

            // RECURSIVIDAD: Llamada recursiva, PUES SE LLAMA ASI MISMO para seguir buscando en la lista
            return BuscarNumeroEnLista(lista, numero, valor + 1);
        }

        private void G7_BTNbuscar_Click(object sender, EventArgs e)
        {
            string G7_numeroBuscar = G7_TXTbuscar.Text;
            // VERIFICAR QUE LA CAJA DE TEXTO NO ESTE VACIA O TENGA VALOR NULO
            if (!string.IsNullOrEmpty(G7_numeroBuscar))
            {
                if (int.TryParse(G7_numeroBuscar, out int numero))
                {
                    //LLAMADO DEL METODO BOOLEANO BOOL PARA VERIFICAR SI SE ENCONTRO O NO EL NUMERO EN LA LISTA
                    bool G7_valorBooleano = BuscarNumeroEnLista(G7_lista_numeros, numero);
                    if (G7_valorBooleano)
                    {
                        MessageBox.Show("Número "+numero+" encontrado en la lista.");
                    }
                    else
                    {
                        MessageBox.Show("Número "+numero+" no se encuentra en la lista.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido para buscar.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número para buscar.");
            }
        }

        private void G7_botonOrdenarAscendeten_Click(object sender, EventArgs e)
        {
            //USAMOS LA  PROPIEDAD SORT DEL DATAGREDVIEW PARA ORDENAR DE MANERA ASCENDENTE
            if (G7_dtgv_numeros.Columns.Contains("Column1"))
            {
                G7_dtgv_numeros.Sort(G7_dtgv_numeros.Columns["Column1"], ListSortDirection.Ascending);
            }
        }
    }
}
