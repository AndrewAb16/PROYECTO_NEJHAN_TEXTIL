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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();

            form.Show();

            this.Hide();

            form.FormClosing += FrmClosing;

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void FrmClosing (object sender, FormClosingEventArgs e)
        {
            Txt_documento.Text = "";

            Txt_password.Text = "";


            this.Show();

        }






    }
}
