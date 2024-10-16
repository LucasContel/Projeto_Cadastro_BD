using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Cadastro_BD
{
    public partial class FormCursos : MaterialForm
    {
        bool isAlteracao = false;
        string conexao = @"server=127.0.0.1;" +
                        "uid=root;" +
                        "pwd=ifsp;" +
                        "database=academico";

        public FormCursos()
        {
            InitializeComponent();
        }

        private void Salvar()
        {

            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "";

            if (isAlteracao)
            {
                sql = "UPDATE curso SET " +
                    "codigo = @codigo, " +
                    "nome = @nome, " +
                    "nivel = @nivel, " +
                    "duracao = @duracao, " +
                    "periodo = @periodo, " +
                    "area = @area " +
                    " WHERE id = @id";
            }
            else
            {

                sql = "INSERT INTO curso " +
                    " (codigo, nome, nivel, duracao, periodo, " +
                    " area) " +
                    " VALUES " +
                    " (@codigo, @nome, @nivel, @duracao, @periodo, " +
                    " @area)";
            }
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@nivel", txtNivel.Text);
            cmd.Parameters.AddWithValue("@duracao", int.Parse(txtDuracao.Text));
            cmd.Parameters.AddWithValue("@periodo", txtPeriodo.Text);
            cmd.Parameters.AddWithValue("@area", txtArea.Text);
            if (isAlteracao)
                cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            con.Close();
            LimpaCampos();

        }


        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Código obrigatório!");
                txtCodigo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome obrigatório!");
                txtNome.Focus();
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();
                tabControlCadastros.SelectedIndex = 1;
            }
        }

        private void CarregaGrid()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "SELECT * FROM curso";
            var sqlAd = new MySqlDataAdapter(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridViewCurso.DataSource = dt;
            con.Close();
        }

        private void dataGridViewCurso_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void Editar()
        {
            if (dataGridViewCurso.SelectedRows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridViewCurso.SelectedRows[0];
                txtId.Text = linha.Cells["id"].Value.ToString();
                txtCodigo.Text = linha.Cells["codigo"].Value.ToString();
                txtNome.Text = linha.Cells["nome"].Value.ToString();
                txtNivel.Text = linha.Cells["nivel"].Value.ToString();
                txtDuracao.Text = linha.Cells["duracao"].Value.ToString();
                txtPeriodo.Text = linha.Cells["periodo"].Value.ToString();
                txtArea.Text = linha.Cells["area"].Value.ToString();
                tabControlCadastros.SelectedIndex = 0;
                txtCodigo.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum curso", "IFSP", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewCurso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Excluir(int id)
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "DELETE FROM curso WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewCurso.SelectedRows.Count > 0)
            {


                if (MessageBox.Show("Deseja realmente excluir?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridViewCurso.SelectedRows[0].Cells["id"].Value;
                    Excluir(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum curso!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            tabControlCadastros.SelectedIndex = 0;
            txtCodigo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Atenção: Informações não salvar serão perdidas.\r\n" + "Deseja cancelar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabControlCadastros.SelectedIndex = 1;
            }
        }
    }
}
