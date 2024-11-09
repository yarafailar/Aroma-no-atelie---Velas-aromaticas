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
    public partial class FormVela : Form
    {
        public FormVela()
        {
            InitializeComponent();
        }

        private void FormVela_Load(object sender, EventArgs e)
        {
            ltvvela.Items.Clear();
            VelaDAO velaDAO = new VelaDAO(); 
            List<Vela> velas = velaDAO.ListarTodasVelas();
            foreach(var vela in velas)
            {
                ListViewItem linha = new ListViewItem(vela.CodVela.ToString());

                linha.SubItems.Add(vela.NomeVela);
                linha.SubItems.Add(vela.TamanhoVela);
                linha.SubItems.Add(vela.DescricaoVela);
                linha.SubItems.Add(vela.PrecoVela.ToString());
                ltvvela.Items.Add(linha);
            
            }
        }

        private void bttsalvar_Click(object sender, EventArgs e)
        {
            string nome = txbnome.Text;
            string tamanho = txbtamanho.Text;
            string descricao = txbdescricao.Text;
            decimal preco = (decimal.Parse(txbpreco.Text));

            Vela vela = new Vela(nome, tamanho, descricao, decimal.Round(preco, 2));

            VelaDAO velaDAO = new VelaDAO();

            velaDAO.Insert(vela); 
        }
    }
}
