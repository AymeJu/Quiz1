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
    public partial class Facil : Form
    {
        private Jogador _banco = new Jogador();
        public Facil()
        {
            InitializeComponent();
            _banco.Nome = "quiz";
            _banco.Conectar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radio1.Checked == true)
            {
                MessageBox.Show("Resposta certa!");
                try
                {
                    //string nome = txtNome.Text;
                    string sql = "update jogador set pontos = 1 order by id desc limit 1";
                    _banco.Inserir(sql);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }
            
            else
            {
                MessageBox.Show("Resposta errada! Tente novamente.");
                radio1.Checked = false;
                radio2.Checked = false;
                radio3.Checked = false;
                radio4.Checked = false;
            }
        }
    }
}
