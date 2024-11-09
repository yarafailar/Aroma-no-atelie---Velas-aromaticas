using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aroma_no_atelie___Velas_aromaticas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        
        }

        private void pictureBox3_Cli(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = cbx2.Text;
            string tamanho = cbx3.Text;
            string descricao = cbx4.Text;
            decimal preco = decimal.Parse(txt1.Text);

            Vela vela = new Vela(nome, tamanho, descricao, preco);
            VelaDAO veladao = new VelaDAO();
            veladao.Insert(vela);

            cbx2.SelectedIndex = 0;
            cbx3.SelectedIndex = 0;
            cbx4.SelectedIndex = 0; 
            txt1.Clear(); 

        }
    }
}
