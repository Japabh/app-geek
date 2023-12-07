using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_geek
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            List<frmCliente> clientes = cliente.listacliente();
            dgvCliente.DataSource = clientes;
            btneditar.Enabled = false;
            btnexcluir.Enabled = false;
            this.ActiveControl = lblnome;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCliente.Rows[e.RowIndex];
                this.dgvCliente.Rows[e.RowIndex].Selected = true;
                lblid.Text = row.Cells[0].Value.ToString();
                lblnome.Text = row.Cells[1].Value.ToString();
                mtxtcpf.Text = row.Cells[2].Value.ToString();
                mtxtcelular.Text = row.Cells[3].Value.ToString();
            }
            btneditar.Enabled = true;
            btnexcluir.Enabled = true;
        }
    }
}
