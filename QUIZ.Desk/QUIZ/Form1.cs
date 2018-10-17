using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ
{
    public partial class Form1 : Form
    {
        private Jogador _banco = new Jogador();

        public Form1()
        {
            InitializeComponent();
            _banco.Nome = "Histórico do Jogador";
            _banco.Conectar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            try
            {
                //string nome = txtNome.Text;
                if (txtNome.Text.Length < 3)
                {
                    MessageBox.Show("Nome inválido. Muito curto!");
                }
                else
                {
                    string sql = "INSERT INTO jogador ";
                    sql += "(id, nome) VALUES (NULL,'" + txtNome.Text + "')";

                    _banco.Inserir(sql);
                    txtNome.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comecar_Click(object sender, EventArgs e)
        {
            if (facil.Checked == true)
            {
                ShowDialog.s
            }
        }
    }
}
