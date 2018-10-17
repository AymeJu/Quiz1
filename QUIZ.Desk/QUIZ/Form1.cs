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
            _banco.Nome = "quiz";
            _banco.Conectar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            
        }

        private void comecar_Click(object sender, EventArgs e)
        {
            try
            {
                //string nome = txtNome.Text;
                string sql = "INSERT INTO jogador ";
                sql += "(id, nome) VALUES (NULL,'" + txtNome.Text + "')";
                _banco.Inserir(sql);
                txtNome.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (facil.Checked == true)
            {
                Facil facil = new Facil();
                facil.Show();
            }
            if (medio.Checked == true)
            {
                Medio medio = new Medio();
                medio.Show();
            }
            if (dificil.Checked == true)
            {
                Dificil dificil = new Dificil();
                dificil.Show();
                
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtNome.Text.Length < 3)
            {
                comecar.Enabled = false;
            } else
            {
                comecar.Enabled = true;
            }
        }
    }
}
