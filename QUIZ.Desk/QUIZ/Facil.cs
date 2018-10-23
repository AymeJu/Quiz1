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
        public Facil()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a_correta.Checked == true)
            {
                MessageBox.Show("Resposta certa!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Resposta errada! Tente novamente.");
                
            }
        }
    }
}
