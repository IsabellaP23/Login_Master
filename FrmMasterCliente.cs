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
    public partial class FrmMasterCliente : Form
    {
        public FrmMasterCliente()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgClientes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgClientes.SelectedRows)
                {
                    dtgClientes.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }

            if (dtgClientes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgClientes.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        ((DataTable)dtgClientes.DataSource).Rows[row.Index].Delete();
                    }
                }
            }
        }
    }
}
