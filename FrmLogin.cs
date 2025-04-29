using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Master
{
    public partial class FrmLogin : Form
    {
        database db = new database();
        public FrmLogin()
        {

            InitializeComponent();
            database db = new database();

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnOk.PerformClick();
        }

        private void txtUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtContraseña.Focus();
            }
        }

        private void txtContraseña_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOk.Focus();
            }
        }

        private void btnOk_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOk.PerformClick();
                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;

                if (db.VerificarCredenciales(usuario, contraseña))
                {
                    FrmBienvenido bienvenido = new FrmBienvenido();
                    bienvenido.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (db.VerificarCredenciales(usuario, contraseña))
            {
                FrmBienvenido bienvenido = new FrmBienvenido();
                bienvenido.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
