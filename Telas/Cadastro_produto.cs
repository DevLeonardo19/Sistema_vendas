using Primeiro_CRUD___Comp.Aerea.Dl;
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
    public partial class Cadastro_produto : Form
    {
        public Cadastro_produto()
        {
            InitializeComponent();
        }
        private void Cadastro_produto_Load(object sender, EventArgs e)
        {
            Carregar_reg_prod();
        }

        private void button5_Click(object sender, EventArgs e)
        {
                DataSet ds = new DataSet();
                DataBase database = new DataBase();

                try
                {
                    ds = database.RetornaDataSet($@"SELECT Cod_prod as Codigo_Produto, Nome_prod as Nome_produto, Preco_prod as Preco FROM PRODUTO WHERE Nome_prod like '%' + '{txtBusca_Nome.Text}' + '%'");

                    dgwProduto.DataSource = ds.Tables[0];
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

        public void Carregar_reg_prod()
        {
            DataSet ds = new DataSet();
            DataBase database = new DataBase();

            try
            {
                ds = database.RetornaDataSet($@"SELECT Cod_prod as Codigo_Produto, Nome_prod as Nome_produto, Preco_prod as Preco FROM PRODUTO ORDER BY COD_PROD");

                dgwProduto.DataSource = ds.Tables[0];
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

        private void btnCriar_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();        

            try
            {
                string sSQL = $@"
                    INSERT INTO PRODUTO
                        VALUES('{txtNome.Text}', {txtPreco.Text})";

                dataBase.ExecutaSQLComando(sSQL);

                txtIdproduto.Clear();
                txtNome.Clear();
                txtPreco.Clear();

                MessageBox.Show("Registro inserido com sucesso.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControlConsulta.SelectedIndex = 0;
                Carregar_reg_prod();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();

            try
            {
                string sSQL = $@"UPDATE PRODUTO SET NOME_PROD = '{txtNome.Text}', PRECO_PROD = {txtPreco.Text} WHERE Cod_prod = {txtIdproduto.Text}";

                dataBase.ExecutaSQLComando(sSQL);

                txtIdproduto.Clear();
                txtNome.Clear(); 
                txtPreco.Clear();

                MessageBox.Show("Registro atualizado com sucesso.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControlConsulta.SelectedIndex = 0;
                Carregar_reg_prod();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Editar registro. Erro: {ex.Message}", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                dataBase = null;
                GC.Collect();
            }
        }

        private void dgwProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControlConsulta.SelectedIndex = 1;
            txtIdproduto.Text = this.dgwProduto.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = this.dgwProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPreco.Text = this.dgwProduto.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();

            try
            {
                string sSql = $@"DELETE FROM PRODUTO WHERE Cod_prod = {txtIdproduto.Text}";
                dataBase.ExecutaSQLComando(sSql);

                txtIdproduto.Clear();
                txtNome.Clear();
                txtPreco.Clear();

                MessageBox.Show("Registro excluido com sucesso.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControlConsulta.SelectedIndex = 0;
                Carregar_reg_prod();
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtIdproduto.Clear();
            txtNome.Clear();
            txtPreco.Clear();
        }
    }
}
