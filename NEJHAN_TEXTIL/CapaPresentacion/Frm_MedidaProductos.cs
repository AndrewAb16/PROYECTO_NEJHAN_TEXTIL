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
    public partial class Frm_MedidaProductos : Form
    {
        public Frm_MedidaProductos()
        {
            InitializeComponent();
        }


        #region "Mis Variables"

        int Estadoguarda = 0; // Sin Ninguna accion
        int IdMarcaProducto = 0;

        #endregion


        #region "Mis Metodos"
        private void Formato_ma()
        {
            Dgv_principal.Columns[0].Width = 100;
            Dgv_principal.Columns[0].HeaderText = "CODIGO_MA";
            Dgv_principal.Columns[1].Width = 300;
            Dgv_principal.Columns[1].HeaderText = "MARCA";

        }

        private void Listado_ma(string cTexto)
        {

            try
            {

                Dgv_principal.DataSource = N_Marcas.Listado_ma(cTexto);
                this.Formato_ma();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }


        }


        #endregion

        private void Frm_MedidaProductos_Load(object sender, EventArgs e)
        {


            this.Listado_ma("%");



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
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["IdMarcaProducto"].Value)))
            {
                MessageBox.Show("No se tiene informacion para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                this.IdMarcaProducto = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["IdMarcaProducto"].Value);
                Txt_descripcion_ma.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_ma"].Value);

            }




        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {

            if (Txt_descripcion_ma.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else //Se procederia a registrar la informacion
            {
                E_Marcas oMa = new E_Marcas();

                string Rpta = "";
                oMa.IdMarcaProducto = this.IdMarcaProducto;
                oMa.Descripcion_ma = Txt_descripcion_ma.Text.Trim();
                Rpta = N_Marcas.Guardar_ma(Estadoguarda, oMa);

                if (Rpta == "OK")
                {
                    this.Listado_ma("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0; //Sin Ninguna accion
                    this.Estado_Botonesprincipales(true);
                    this.Estado_Botonesprocesos(false);
                    Txt_descripcion_ma.Text = "";
                    Txt_descripcion_ma.ReadOnly = true;
                    Tbp_principal.SelectedIndex = 0;
                    this.IdMarcaProducto = 0;


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
            Txt_descripcion_ma.Text = "";
            Txt_descripcion_ma.ReadOnly = false;
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_ma.Focus();




        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {

            Estadoguarda = 2; //Actualizar Registro
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Selecciona_item();
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_ma.ReadOnly = false;
            Txt_descripcion_ma.Focus();



        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            Estadoguarda = 0; //Sin ninguna accion
            this.IdMarcaProducto = 0;
            Txt_descripcion_ma.Text = "";
            Txt_descripcion_ma.ReadOnly = true;
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

            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["IdMarcaProducto"].Value)))
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
                    this.IdMarcaProducto = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["IdMarcaProducto"].Value);
                    // Enviar a ejecutar la eliminacion de datos
                    rpta = N_Marcas.Eliminar_ma(this.IdMarcaProducto);
                    if (rpta.Equals("OK"))
                    {
                        this.Listado_ma("%");
                        this.IdMarcaProducto = 0;
                        MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }


                }




            }



        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {


            this.Listado_ma(Txt_buscar.Text.Trim());


        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {


            this.Close();


        }
    }
}
