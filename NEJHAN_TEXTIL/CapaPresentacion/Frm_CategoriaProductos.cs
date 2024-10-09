using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Frm_CategoriaProductos : Form
    {
        public Frm_CategoriaProductos()
        {
            InitializeComponent();
        }


        #region "Mis Variables"

        int Estadoguarda = 0; // Sin Ninguna accion
        int IdCategoriaProducto = 0;

        #endregion


        #region "Mis Metodos"
        private void Formato_ca()
        {
            Dgv_principal.Columns[0].Width = 100;
            Dgv_principal.Columns[0].HeaderText = "CODIGO_CA";
            Dgv_principal.Columns[1].Width = 300;
            Dgv_principal.Columns[1].HeaderText = "CATEGORIA";

        }

        private void Listado_ca(string cTexto)
        {

            try
            {

                Dgv_principal.DataSource = N_Categorias.Listado_ca(cTexto);
                this.Formato_ca();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }


        }


        #endregion

        private void Frm_CategoriaProductos_Load(object sender, EventArgs e)
        {


            this.Listado_ca("%");



        }


        private void Estado_Botonesprincipales(bool lEstado)
        {

            this.Btn_nuevo.Enabled = lEstado;

            this.Btn_actualizar.Enabled = lEstado;

            this.Btn_eliminar.Enabled = lEstado;

            this.Btn_salir.Enabled = lEstado;


        }

        private void Estado_Botonesprocesos(bool lEstado)
        {
            this.btn_cancelar.Visible = lEstado;
            this.Btn_guardar.Visible = lEstado;
            this.Btn_retornar.Visible = !lEstado;

        }


        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["IdCategoriaProducto"].Value)))
            {
                MessageBox.Show("No se tiene informacion para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                this.IdCategoriaProducto = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["IdCategoriaProducto"].Value);
                Txt_descripcion_ca.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_ca"].Value);

            }




        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {

            if (Txt_descripcion_ca.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else //Se procederia a registrar la informacion
            {
                E_Categorias oCa = new E_Categorias();

                string Rpta = "";
                oCa.IdCategoriaProducto = this.IdCategoriaProducto;
                oCa.Descripcion_ca = Txt_descripcion_ca.Text.Trim();
                Rpta = N_Categorias.Guardar_ca(Estadoguarda, oCa);

                if (Rpta == "OK")
                {
                    this.Listado_ca("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0; //Sin Ninguna accion
                    this.Estado_Botonesprincipales(true);
                    this.Estado_Botonesprocesos(false);
                    Txt_descripcion_ca.Text = "";
                    Txt_descripcion_ca.ReadOnly = true;
                    Tbp_principal.SelectedIndex = 0;
                    this.IdCategoriaProducto = 0;


                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }


        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {

            Estadoguarda = 1; //Nuevo Registro

            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            Txt_descripcion_ca.Text = "";
            Txt_descripcion_ca.ReadOnly = false;
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_ca.Focus();




        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {

            Estadoguarda = 2; //Actualizar Registro
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Selecciona_item();
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_ca.ReadOnly = false;
            Txt_descripcion_ca.Focus();



        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            Estadoguarda = 0; //Sin ninguna accion
            this.IdCategoriaProducto = 0;
            Txt_descripcion_ca.Text = "";
            Txt_descripcion_ca.ReadOnly = true;
            this.Estado_Botonesprincipales(true);
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 0;


        }

        private void Dgv_principal_DoubleClick(object sender, EventArgs e)
        {


            this.Selecciona_item();
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 1;


        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["IdCategoriaProducto"].Value)))
            {
                MessageBox.Show("No se tiene informacion para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Estas seguro de Eliminar el registro seleccionado?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string rpta = "";
                    this.IdCategoriaProducto = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["IdCategoriaProducto"].Value);
                    // Enviar a ejecutar la eliminacion de datos
                    rpta = N_Categorias.Eliminar_ca(this.IdCategoriaProducto);
                    if (rpta.Equals("OK"))
                    {
                        this.Listado_ca("%");
                        this.IdCategoriaProducto = 0;
                        MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }


                }




            }



        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {


            this.Listado_ca(Txt_buscar.Text.Trim());


        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {


            this.Close();


        }
    }
}
