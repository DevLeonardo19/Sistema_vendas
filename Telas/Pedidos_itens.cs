using Primeiro_CRUD___Comp.Aerea.Dl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_vendas.Telas
{
    public partial class Pedidos_itens : Form
    {
        public Pedidos_itens()
        {
            InitializeComponent();
        }


        private void Pedidos_itens_Load(object sender, EventArgs e)
        {
            Mostrar_data();
            Carrega_Produtos();            
            Retorna_ultimo_id_pedido();
            txtTotallinha.Text = "0";
            txtValorTotalPedido.Text = "0";
            Mostrar_pedidos();
        }

        public void Mostrar_data()
        {
            DateTime data = DateTime.Now;
            txtDataHoje.Text = data.ToString("dd/MM/yyyy");
        }

        public void Total_linha(double valor, double quantidade)
        {
            var total = (valor * quantidade);
            txtTotallinha.Text = total.ToString();
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataBase database = new DataBase();

            try
            {
                if (txtCpf.Text == string.Empty)
                {
                    MessageBox.Show($"Adicione o CPF", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ds = database.RetornaDataSet($@"Select Nome_cli from Cliente WHERE Cpf = '{txtCpf.Text}'");
                    string nomeCliente = ds.Tables[0].Rows[0]["Nome_cli"].ToString();
                    txtNome.Text = nomeCliente;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Carrega_Produtos()
        {
            DataSet ds = new DataSet();
            DataBase dataBase = new DataBase();

            try
            {
                ds = dataBase.RetornaDataSet($@"SELECT Cod_prod, Nome_prod as Nome from produto");
                cboIdprod.DataSource = ds.Tables[0];
                cboIdprod.ValueMember = "Cod_prod";
                cboIdprod.DisplayMember = "Nome";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cboIdprod_Leave(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataBase database = new DataBase();

            ds = database.RetornaDataSet($@"SELECT PRECO_PROD as Preco FROM PRODUTO WHERE Cod_prod = '{cboIdprod.SelectedValue}'");
            string valorProduto = ds.Tables[0].Rows[0]["Preco"].ToString();
            txtValor.Text = valorProduto;
        }

        private void txtQtde_Leave(object sender, EventArgs e)
        {
            Total_linha(double.Parse(txtValor.Text), double.Parse(txtQtde.Text));
        }


        private void Retorna_ultimo_id_pedido()
        {
            DataSet ds = new DataSet();
            DataBase database = new DataBase();

            ds = database.RetornaDataSet($"SELECT MAX(Num_ped) + 1 From PEDIDOS");
            string Numero_pedido = ds.Tables[0].Rows[0][0].ToString();
            txtIdPedido.Text = Numero_pedido;
        }

        public void Calcular_valor_total()
        {
            double valorLinha = double.Parse(txtTotallinha.Text);
            double valorTotalAtual = double.Parse(txtValorTotalPedido.Text);

            double novoValorTotal = valorLinha + valorTotalAtual;
            txtValorTotalPedido.Text = novoValorTotal.ToString();
        }

        private void Inserir_itens(string idPedido, string idProduto, string quantidade, string totalLinha)
        {
            DataBase dataBase = new DataBase();

            try
            {
                string sSQL = $@"
            INSERT INTO Itens_pedido (Num_ped, Cod_prod, Quantidade, Valor_Linha) VALUES 
            ({idPedido}, '{idProduto}', {quantidade}, '{totalLinha}')";

                dataBase.ExecutaSQLComando(sSQL);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir o registro de itens. Erro: {ex.Message}", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataBase = null;
                GC.Collect();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int num_pedido = int.Parse(txtIdPedido.Text);
            int cod_produto = (int)cboIdprod.SelectedValue;            
            double quantidade = double.Parse(txtQtde.Text);
            double total_linha = double.Parse(txtTotallinha.Text);

            dgwPedidos.Rows.Add(num_pedido, cod_produto, quantidade, total_linha);

            MessageBox.Show("Itens inseridos com sucesso.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          
            Calcular_valor_total();
            txtQtde.Clear();
            txtTotallinha.Clear();
            txtValor.Clear();
        }

        private void Inserir_pedido(string cpf, string valorTotal, string dataLancamento)
        {
            DataBase dataBase = new DataBase();

            try
            {
                string sSQL = $@"
            INSERT INTO Pedidos (Cpf, Valor_tot, Data_Lancamento) VALUES 
            ('{cpf}', {valorTotal}, '{dataLancamento}')";

                dataBase.ExecutaSQLComando(sSQL);

                MessageBox.Show("Registro inserido com sucesso.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir o registro. Erro: {ex.Message}", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataBase = null;
                GC.Collect();
            }
        }

        private void btnInsertReg_Click(object sender, EventArgs e)
        {
            if (dgwPedidos.Rows.Count == 1)
            {
                MessageBox.Show("Você não pode adicionar um pedido sem itens informado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBase dataBase = new DataBase();
            Inserir_pedido(txtCpf.Text, txtValorTotalPedido.Text, txtDataHoje.Text);

            foreach (DataGridViewRow row in dgwPedidos.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    int Num_pedido = int.Parse(row.Cells[0].Value.ToString());
                    int Cod_prod = int.Parse(row.Cells[1].Value.ToString());
                    double Quantidade = double.Parse(row.Cells[2].Value.ToString());
                    double Valor_linha = double.Parse(row.Cells[3].Value.ToString());


                    Inserir_itens(Num_pedido.ToString(), Cod_prod.ToString(), Quantidade.ToString(), Valor_linha.ToString());
                }
                else
                {
                    continue;
                }
            }
            MessageBox.Show("Registro de itens inserido com sucesso.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCpf.Clear();
            txtNome.Clear();
            dgwPedidos.Rows.Clear();
            txtValorTotalPedido.Clear();
            txtTotallinha.Clear();
            txtQtde.Clear();
            txtValor.Clear();
            Retorna_ultimo_id_pedido();
            Mostrar_pedidos();
            tabControlPedidos.SelectedIndex = 0;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void Mostrar_pedidos()
        {
            DataSet ds = new DataSet();
            DataBase database = new DataBase();

            try
            {
                String Sql = $@"SELECT ped.Num_ped AS Numero_pedido, clie.Cpf, clie.Nome_cli as Cliente, prod.Nome_prod as Produto, Valor_tot as Valor_total, Data_Lancamento 
                                                FROM Pedidos ped
                                                inner join CLIENTE clie
                                                on ped.Cpf = clie.Cpf
                                                inner join Itens_pedido ite
                                                on ite.Num_ped = ped.Num_ped
                                                inner join PRODUTO prod
                                                on prod.Cod_prod = ite.Cod_prod 
                                                WHERE 1=1";


                ds = database.RetornaDataSet(Sql);
                dgwConsulta.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ds = null;
                database = null;
                GC.Collect();
            }
        }

        private void tabCriar_Click(object sender, EventArgs e)
        {
            Mostrar_pedidos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataBase database = new DataBase();

            try
            {
                String Sql = $@"SELECT ped.Num_ped AS Numero_pedido, clie.Cpf, clie.Nome_cli as Cliente, prod.Nome_prod as Produto, Valor_tot as Valor_total, Data_Lancamento 
                                                FROM Pedidos ped
                                                inner join CLIENTE clie
                                                on ped.Cpf = clie.Cpf
                                                inner join Itens_pedido ite
                                                on ite.Num_ped = ped.Num_ped
                                                inner join PRODUTO prod
                                                on prod.Cod_prod = ite.Cod_prod 
                                                WHERE 1=1";
                if (txtBuscaPedido.Text != string.Empty)
                    Sql = Sql + $" and ped.Num_ped = {txtBuscaPedido.Text}";

                if (txtBuscaNome.Text != string.Empty)
                    Sql = Sql + $" and clie.Nome_cli LIKE '%{txtBuscaNome.Text}%'";

                if (txtBuscaCpf.Text != string.Empty)
                    Sql = Sql + $" and Clie.cpf = '{txtBuscaCpf}'";

                ds = database.RetornaDataSet(Sql);
                dgwConsulta.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ds = null;
                database = null;
                GC.Collect();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();

            try
            {
                string sSQL = $@"DELETE FROM Itens_pedido WHERE NUM_PED = '{txtBuscaPedido.Text}'";
                dataBase.ExecutaSQLComando(sSQL);                
                
                
                string ssSQL = $@"DELETE FROM Pedidos WHERE NUM_PED = '{txtBuscaPedido.Text}'";
                dataBase.ExecutaSQLComando(ssSQL); 
                MessageBox.Show("Pedido excluido com sucesso.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControlPedidos.SelectedIndex = 0;
                Mostrar_pedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir registro. Erro: {ex.Message}", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataBase = null;
                GC.Collect();
            }
        }

        private void dgwConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBuscaPedido.Text = this.dgwConsulta.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
