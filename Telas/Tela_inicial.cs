using Sistema_vendas.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_cliente Cadastro_Cliente = new Cadastro_cliente();
            Cadastro_Cliente.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_produto cadastro_Produto = new Cadastro_produto();
            cadastro_Produto.Show();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos_itens Pedidos = new Pedidos_itens();
            Pedidos.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
