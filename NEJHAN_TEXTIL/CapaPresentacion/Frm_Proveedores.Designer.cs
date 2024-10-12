namespace CapaPresentacion
{
    partial class Frm_Proveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Listado = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ruc_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RazonSocial_TXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_codigo_sx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_codigo_RB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_correo_pv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_telefono_pv = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_retornar = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_observacion_pv = new System.Windows.Forms.TextBox();
            this.Listado.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Listado
            // 
            this.Listado.Controls.Add(this.tabPage2);
            this.Listado.Controls.Add(this.tabPage1);
            this.Listado.Location = new System.Drawing.Point(44, 44);
            this.Listado.Name = "Listado";
            this.Listado.SelectedIndex = 0;
            this.Listado.Size = new System.Drawing.Size(624, 339);
            this.Listado.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(616, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_observacion_pv);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.Btn_retornar);
            this.tabPage2.Controls.Add(this.Btn_guardar);
            this.tabPage2.Controls.Add(this.btn_cancelar);
            this.tabPage2.Controls.Add(this.txt_telefono_pv);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txt_correo_pv);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt_codigo_RB);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt_codigo_sx);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txt_apellido);
            this.tabPage2.Controls.Add(this.txt_nombre);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.RazonSocial_TXT);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.ruc_txt);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(616, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Proveedores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RUC:";
            // 
            // ruc_txt
            // 
            this.ruc_txt.BackColor = System.Drawing.SystemColors.Control;
            this.ruc_txt.Location = new System.Drawing.Point(80, 11);
            this.ruc_txt.Name = "ruc_txt";
            this.ruc_txt.Size = new System.Drawing.Size(184, 20);
            this.ruc_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Razon Social:";
            // 
            // RazonSocial_TXT
            // 
            this.RazonSocial_TXT.BackColor = System.Drawing.SystemColors.Control;
            this.RazonSocial_TXT.Location = new System.Drawing.Point(80, 49);
            this.RazonSocial_TXT.Name = "RazonSocial_TXT";
            this.RazonSocial_TXT.Size = new System.Drawing.Size(251, 20);
            this.RazonSocial_TXT.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(186, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellidos:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.SystemColors.Control;
            this.txt_nombre.Location = new System.Drawing.Point(33, 110);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(142, 20);
            this.txt_nombre.TabIndex = 6;
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.SystemColors.Control;
            this.txt_apellido.Location = new System.Drawing.Point(189, 110);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(142, 20);
            this.txt_apellido.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(30, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sexo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_codigo_sx
            // 
            this.txt_codigo_sx.BackColor = System.Drawing.SystemColors.Control;
            this.txt_codigo_sx.Location = new System.Drawing.Point(33, 158);
            this.txt_codigo_sx.Name = "txt_codigo_sx";
            this.txt_codigo_sx.Size = new System.Drawing.Size(159, 20);
            this.txt_codigo_sx.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(30, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rubro:";
            // 
            // txt_codigo_RB
            // 
            this.txt_codigo_RB.BackColor = System.Drawing.SystemColors.Control;
            this.txt_codigo_RB.Location = new System.Drawing.Point(33, 207);
            this.txt_codigo_RB.Name = "txt_codigo_RB";
            this.txt_codigo_RB.Size = new System.Drawing.Size(159, 20);
            this.txt_codigo_RB.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(392, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email:";
            // 
            // txt_correo_pv
            // 
            this.txt_correo_pv.BackColor = System.Drawing.SystemColors.Control;
            this.txt_correo_pv.Location = new System.Drawing.Point(395, 45);
            this.txt_correo_pv.Name = "txt_correo_pv";
            this.txt_correo_pv.Size = new System.Drawing.Size(196, 20);
            this.txt_correo_pv.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(392, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Telefono:";
            // 
            // txt_telefono_pv
            // 
            this.txt_telefono_pv.BackColor = System.Drawing.SystemColors.Control;
            this.txt_telefono_pv.Location = new System.Drawing.Point(395, 107);
            this.txt_telefono_pv.Name = "txt_telefono_pv";
            this.txt_telefono_pv.Size = new System.Drawing.Size(196, 20);
            this.txt_telefono_pv.TabIndex = 15;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Salmon;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelar.Location = new System.Drawing.Point(33, 256);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 24);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.ForeColor = System.Drawing.Color.Black;
            this.Btn_guardar.Location = new System.Drawing.Point(126, 256);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(75, 24);
            this.Btn_guardar.TabIndex = 17;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // Btn_retornar
            // 
            this.Btn_retornar.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_retornar.ForeColor = System.Drawing.Color.Black;
            this.Btn_retornar.Location = new System.Drawing.Point(218, 256);
            this.Btn_retornar.Name = "Btn_retornar";
            this.Btn_retornar.Size = new System.Drawing.Size(75, 24);
            this.Btn_retornar.TabIndex = 18;
            this.Btn_retornar.Text = "Retornar";
            this.Btn_retornar.UseVisualStyleBackColor = false;
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.Khaki;
            this.Btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevo.ImageIndex = 0;
            this.Btn_nuevo.Location = new System.Drawing.Point(44, 397);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(75, 56);
            this.Btn_nuevo.TabIndex = 7;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.Khaki;
            this.Btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.ImageIndex = 1;
            this.Btn_actualizar.Location = new System.Drawing.Point(131, 397);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(75, 56);
            this.Btn_actualizar.TabIndex = 8;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.Khaki;
            this.Btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.ImageIndex = 2;
            this.Btn_eliminar.Location = new System.Drawing.Point(223, 397);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(75, 56);
            this.Btn_eliminar.TabIndex = 9;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.Khaki;
            this.Btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.ImageIndex = 4;
            this.Btn_salir.Location = new System.Drawing.Point(316, 397);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(75, 56);
            this.Btn_salir.TabIndex = 11;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 20;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(392, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Observación:";
            // 
            // txt_observacion_pv
            // 
            this.txt_observacion_pv.BackColor = System.Drawing.SystemColors.Control;
            this.txt_observacion_pv.Location = new System.Drawing.Point(395, 184);
            this.txt_observacion_pv.Name = "txt_observacion_pv";
            this.txt_observacion_pv.Size = new System.Drawing.Size(196, 20);
            this.txt_observacion_pv.TabIndex = 22;
            // 
            // Frm_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(840, 465);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.Listado);
            this.Name = "Frm_Proveedores";
            this.Text = "Frm_Proveedores";
            this.Listado.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Listado;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ruc_txt;
        private System.Windows.Forms.TextBox RazonSocial_TXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codigo_sx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_telefono_pv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_correo_pv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_codigo_RB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_retornar;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.TextBox txt_observacion_pv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}