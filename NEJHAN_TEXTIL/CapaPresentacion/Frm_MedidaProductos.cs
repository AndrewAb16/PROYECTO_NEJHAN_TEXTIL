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
        int IdMedidaProducto = 0;

        #endregion


        #region "Mis Metodos"
        private void Formato_me()
        {
            Dgv_principal.Columns[0].Width = 100;
            Dgv_principal.Columns[0].HeaderText = "CODIGO_ME";
            Dgv_principal.Columns[1].Width = 100;
            Dgv_principal.Columns[1].HeaderText = "ABREVIATURA";
            Dgv_principal.Columns[2].Width = 300;
            Dgv_principal.Columns[2].HeaderText = "MEDIDA";

        }

        private void Listado_me(string cTexto)
        {

            try
            {

                Dgv_principal.DataSource = N_Medidas.Listado_me(cTexto);
                this.Formato_me();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);


            }


        }


        #endregion

        private void Frm_MedidaProductos_Load(object sender, EventArgs e)
        {


            this.Listado_me("%");



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
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["IdMedidaProducto"].Value)))
            {
                MessageBox.Show("No se tiene informacion para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                this.IdMedidaProducto = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["IdMedidaProducto"].Value);
                Txt_abreviatura.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["abreviatura_me"].Value);
                Txt_descripcion_me.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_me"].Value);

            }




        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {

            if (Txt_abreviatura.Text==String.Empty ||Txt_descripcion_me.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else //Se procederia a registrar la informacion
            {
                E_Medidas oMe = new E_Medidas();

                string Rpta = "";
                oMe.IdMedidaProducto = this.IdMedidaProducto;
                oMe.Abreviatura_me = Txt_abreviatura.Text.Trim();
                oMe.Descripcion_me = Txt_descripcion_me.Text.Trim();
                Rpta = N_Medidas.Guardar_me(Estadoguarda, oMe);

                if (Rpta == "OK")
                {
                    this.Listado_me("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0; //Sin Ninguna accion
                    this.Estado_Botonesprincipales(true);
                    this.Estado_Botonesprocesos(false);
                    Txt_abreviatura.Text = "";
                    Txt_descripcion_me.Text = "";
                    Txt_descripcion_me.ReadOnly = true;
                    Tbp_principal.SelectedIndex = 0;
                    this.IdMedidaProducto = 0;


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
            Txt_abreviatura.Text = "";
            Txt_descripcion_me.Text = "";
            Txt_abreviatura.ReadOnly = false;
            Txt_descripcion_me.ReadOnly = false;
            Tbp_principal.SelectedIndex = 1;
            Txt_abreviatura.Focus();




        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {

            Estadoguarda = 2; //Actualizar Registro
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Selecciona_item();
            Tbp_principal.SelectedIndex = 1;
            Txt_abreviatura.ReadOnly = false;
            Txt_descripcion_me.ReadOnly = false;
            Txt_descripcion_me.Focus();



        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            Estadoguarda = 0; //Sin ninguna accion
            this.IdMedidaProducto = 0;
            Txt_abreviatura.Text = "";
            Txt_descripcion_me.Text = "";
            Txt_abreviatura.ReadOnly = true;
            Txt_descripcion_me.ReadOnly = true;
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

            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["IdMedidaProducto"].Value)))
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
                    this.IdMedidaProducto = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["IdMedidaProducto"].Value);
                    // Enviar a ejecutar la eliminacion de datos
                    rpta = N_Medidas.Eliminar_me(this.IdMedidaProducto);
                    if (rpta.Equals("OK"))
                    {
                        this.Listado_me("%");
                        this.IdMedidaProducto = 0;
                        MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }


                }




            }



        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {


            this.Listado_me(Txt_buscar.Text.Trim());


        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {


            this.Close();


        }
    }
}
