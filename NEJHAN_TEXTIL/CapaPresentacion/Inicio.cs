using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }


        #region "Mis Variables"

        private Form activeForm = null;

        #endregion

        #region "Mis Metodos"

        private void openChildForm(Form childForm)
        {

            if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Pln_cuerpo.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();


        }

        #endregion





















































        private void Inicio_Load(object sender, EventArgs e)
        {

            this.Pln_procesos.Visible = false;
            this.Pln_mantenedores.Visible = false;
            this.Pln_accesos.Visible = false;



        }

        private void Btn_Procesos_Click(object sender, EventArgs e)
        {
            if (this.Pln_procesos.Visible == false)
            {

                this.Pln_procesos.Visible = true;

            }
            else
            {

                this.Pln_procesos.Visible = false;

            }

            this.Pln_mantenedores.Visible = false;
            this.Pln_accesos.Visible = false;

        }

        private void Btn_mantenedores_Click(object sender, EventArgs e)
        {

            if(this.Pln_mantenedores.Visible == false)
            {


                this.Pln_mantenedores.Visible=true;
            }
            else
            {

                this.Pln_mantenedores.Visible=false;
            }

            this.Pln_procesos.Visible = false;
            this.Pln_accesos.Visible = false;

        }

        private void Btn_sistema_Click(object sender, EventArgs e)
        {

            if(this.Pln_accesos.Visible == false)
            {

                this.Pln_accesos.Visible=true;
            }
            else
            {
                this.Pln_accesos.Visible = false;

            }


            this.Pln_procesos.Visible = false;
            this.Pln_mantenedores.Visible = false;
  

        }

        private void Btn_entradaproductos_Click(object sender, EventArgs e)
        {

            openChildForm(new Frm_EntradaProductos());


        }

        private void Btn_CategoriaProductos_Click(object sender, EventArgs e)
        {

            openChildForm(new Frm_CategoriaProductos());


        }

        private void Btn_marcas_Click(object sender, EventArgs e)
        {


            openChildForm(new Frm_MarcaProductos());



        }

        private void Btn_unidadmedida_Click(object sender, EventArgs e)
        {

            //openChildForm(new Frm_MedidaProductos());


        }



    }
}
