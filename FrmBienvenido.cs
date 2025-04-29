using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Master
{
    public partial class FrmBienvenido : Form
    {
        public FrmBienvenido()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmMasterCliente cliente = new FrmMasterCliente();
            cliente.Show();
            this.Close();
        }
    }
}
