using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InicioSesionClient
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var serviceClient = new LogInServiceReference.Service1Client();
            if (textEditInicioSesionUsuario.Text != "" && textEditInicioSesionPassword.Text != "")
            {
                var respuesta = serviceClient.Autenticar(textEditInicioSesionUsuario.Text,
                    textEditInicioSesionPassword.Text);
                if (!respuesta.Error)
                {
                    new Dashboard().Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña no valida");
                }
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
        }
    }
}
