using Newtonsoft.Json;
using Primeiro_CRUD___Comp.Aerea.Dl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_vendas
{
    public partial class Cadastro_cliente : Form
    {
        public Cadastro_cliente()
        {
            InitializeComponent();

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_cliente_Load(object sender, EventArgs e)
        {
            Mostrar_registros_clie();

        }

        private void dgwCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControlConsulta.SelectedIndex = 1;
            txtCPF.Text = this.dgwCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeClie.Text = this.dgwCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTelefone.Text = this.dgwCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCEP.Text = this.dgwCliente.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtLogradouro.Text = this.dgwCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtComplemento.Text = this.dgwCliente.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtBairro.Text = this.dgwCliente.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtLocalidade.Text = this.dgwCliente.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtUF.Text = this.dgwCliente.Rows[e.RowIndex].Cells[8].Value.ToString();            
        }

        private void Mostrar_registros_clie()
        {
            DataSet ds = new DataSet();
            DataBase database = new DataBase();

            try
            {
                ds = database.RetornaDataSet($@"SELECT Cpf, Nome_cli as Cliente, Telefone, CEP, Logradouro, Complemento, Bairro, Localidade, UF FROM CLIENTE ORDER BY CPF");
                dgwCliente.DataSource = ds.Tables[0];
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

        private void btnConsultaCEP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCEP.Text))
            {
                MessageBox.Show("Informe um CEP valido...", this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                string strURL = ($"https://viacep.com.br/ws/{txtCEP.Text.Trim()}/json/");

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var response = client.GetAsync(strURL).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            var result = response.Content.ReadAsStringAsync().Result; //Conteudo da resposta
                            Resultado resultado = JsonConvert.DeserializeObject<Resultado>(result);  //Compara as propriedades da classe resultado com a consulta

                            txtUF.Text = resultado.UF;
                            txtLocalidade.Text = resultado.Localidade;
                            txtBairro.Text = resultado.Bairro;
                            txtLogradouro.Text = resultado.Logradouro;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            try
            {
                string sSQL = $@"
                    INSERT INTO CLIENTE 
            VALUES ({txtCPF.Text},'{txtNomeClie.Text}',{txtTelefone.Text},{txtCEP.Text},
            '{txtLogradouro.Text}', {txtComplemento.Text}, '{txtBairro.Text}', '{txtLocalidade.Text}', '{txtUF.Text}')";

                dataBase.ExecutaSQLComando(sSQL);

                txtCPF.Clear();
                txtNomeClie.Clear();
                txtTelefone.Clear();
                txtCEP.Clear();
                txtLogradouro.Clear();
                txtLocalidade.Clear();
                txtComplemento.Clear();
                txtBairro.Clear();
                txtUF.Clear();

               
                MessageBox.Show("Registro inserido com sucesso.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControlConsulta.SelectedIndex = 0;
                Mostrar_registros_clie();
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
                    string sSQL = $@"UPDATE Cliente SET CPF = {txtCPF.Text}, Nome_cli = '{txtNomeClie.Text}', Telefone = {txtTelefone.Text}, CEP = '{txtCEP.Text}', Logradouro = '{txtLogradouro.Text}', Complemento = {txtComplemento.Text}, Bairro = '{txtBairro.Text}', Localidade = '{txtUF.Text}'
                               WHERE CPF = '{txtCPF.Text}'";

                    dataBase.ExecutaSQLComando(sSQL);

                    txtCPF.Clear();
                    txtNomeClie.Clear();
                    txtTelefone.Clear();
                    txtCEP.Clear();
                    txtLogradouro.Clear();
                    txtComplemento.Clear();
                    txtLocalidade.Clear();
                    txtBairro.Clear();
                    txtUF.Clear();

                    MessageBox.Show("Registro atualizado com sucesso.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tabControlConsulta.SelectedIndex = 0;
                    Mostrar_registros_clie();
                }

                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Erro SQL: {sqlEx.Message}", "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dataBase = null;
                    GC.Collect();
                }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            {
                DataBase dataBase = new DataBase();

                try
                {
                    string sSQL = $@"DELETE FROM Cliente WHERE CPF = '{txtCPF.Text}'";
                    dataBase.ExecutaSQLComando(sSQL);

                    txtCPF.Clear();
                    txtNomeClie.Clear();
                    txtTelefone.Clear();
                    txtCEP.Clear();
                    txtLogradouro.Clear();
                    txtLocalidade.Clear();
                    txtComplemento.Clear();
                    txtBairro.Clear();
                    txtUF.Clear();

                    MessageBox.Show("Registro excluido com sucesso.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tabControlConsulta.SelectedIndex = 0;
                    Mostrar_registros_clie();
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
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCPF.Clear();
            txtNomeClie.Clear();
            txtTelefone.Clear();
            txtCEP.Clear();
            txtLogradouro.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtUF.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataBase database = new DataBase();

            try
            {
                ds = database.RetornaDataSet($@"SELECT Cpf, Nome_cli as Cliente, Telefone, CEP, Logradouro, Complemento, Bairro, Localidade, UF FROM CLIENTE WHERE Cpf like '%' + '{txtBuscar.Text}' + '%'");

                dgwCliente.DataSource = ds.Tables[0];
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
