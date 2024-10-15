using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace Projeto_Teste
{
    [TestClass]
    public class UnitTest1
    {
        public MySqlConnection GetConnection()
        {
            string c = @"server=127.0.0.1;" +
                        "uid=root;" +
                        "pwd=ifsp;" +
                        "database=academico";
            return new MySqlConnection(c);
        }

        [TestMethod]
        public void TestConnect()
        {

            var con = GetConnection();
            con.Open();
            Assert.IsTrue(con.State == System.Data.ConnectionState.Open);
        }

        [TestMethod]
        public void TestInsert()
        {
            string sql = "INSERT INTO aluno " +
                " (matricula, dt_nascimento, nome, endereco, " +
                " bairro, cidade, estado, senha) " +
                " VALUES " +
                " (@matricula, @dt_nascimento, @nome, @endereco, " +
                " @bairro, @cidade, @estado, @senha)";
            var con = GetConnection();
            con.Open();
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matricula", "BI112616");
            cmd.Parameters.AddWithValue("@dt_nascimento", new DateTime(2002,10,13));
            cmd.Parameters.AddWithValue("@nome", "Murilo Vargues");
            cmd.Parameters.AddWithValue("@endereco", "Rua Pedro Cavalo 709");
            cmd.Parameters.AddWithValue("@bairro", "Portal");
            cmd.Parameters.AddWithValue("@cidade", "Birigui");
            cmd.Parameters.AddWithValue("@estado", "SP");
            cmd.Parameters.AddWithValue("@senha", "123456");
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            con.Close();
        }

        [TestMethod]
        public void TesteSelect()
        {
            var con = GetConnection();
            con.Open();
            var sql = "SELECT * FROM aluno";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                Debug.Write(dr["matricula"] + " ");
                Debug.Write(dr["nome"] + " ");
                Debug.Write(dr["dt_nascimento"] + " ");
                Debug.Write(dr["endereco"] + " ");
                Debug.Write(dr["bairro"] + " ");
                Debug.Write(dr["cidade"] + " ");
                Debug.Write(dr["estado"] + " ");
                Debug.Write(dr["senha"] + " ");
                Debug.WriteLine(" ");
            }
            
            con.Close();
        }
    }
}