using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_CRUD___Comp.Aerea.Dl
{
    class DataBase
    {
        private SqlConnection Conexao = null;
        private SqlCommand cmd = null;
        private SqlDataAdapter da = null;
        private DataSet ds = null;
        private DataTable dt = null;



        public static string StringdeConexaoSist_vendas()
        {
            var Servidor = ConfigurationManager.AppSettings["Servidor"].ToString();
            var DataBase = ConfigurationManager.AppSettings["BaseDados"].ToString();
            var Usuario = ConfigurationManager.AppSettings["Usuario"].ToString();
            var Senha = ConfigurationManager.AppSettings["Senha"].ToString();

            return $"Data Source={Servidor};Initial Catalog={DataBase};Persist Security Info=True;User ID={Usuario};Password={Senha}";
            
        }


        private SqlConnection AbreBanco()
        {
            Conexao = new SqlConnection(StringdeConexaoSist_vendas());
            try
            {
                if (Conexao.State == ConnectionState.Open)
                {
                    Conexao.Open();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return Conexao;

        }

        private void FechaBanco(SqlConnection conexao)
        {
            if (Conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        public DataSet RetornaDataSet(string strQuery)
        {
            Conexao = new SqlConnection();

            try
            {
                Conexao = AbreBanco();
                cmd = new SqlCommand(strQuery, Conexao);
                cmd.Connection = Conexao;
                da = new SqlDataAdapter(cmd); // O SqlDataAdapter é usado para preencher um conjunto de dados (DataSet) com os resultados da consulta
                ds = new DataSet(); // Armazena os dados da consulta
                da.SelectCommand = cmd;
                da.Fill(ds); // Preenche o dataset com os resultados
                return ds; // Acessa os dados recuperados
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                FechaBanco(Conexao);
            }

        }

        public void ExecutaSQLComando(string Commando)
        {
            Conexao = new SqlConnection(StringdeConexaoSist_vendas());
            cmd = new SqlCommand();
            try
            {
                Conexao.Open();
                cmd.Connection = Conexao;
                cmd.CommandText = Commando;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                FechaBanco(Conexao);
                Conexao.Dispose();
                cmd.Dispose();
            }
        }


    }

}
