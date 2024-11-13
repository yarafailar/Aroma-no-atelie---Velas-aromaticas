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
        private int Id;
        public FormVela()
        {
            InitializeComponent();
        }

        private void AtualizarListView()
        { }
        private void ClearFields()
        {
            txbnome.Clear();
            txbtamanho.Clear();
            txbdescricao.Clear();
            txbpreco.Clear();
        }


        private void FormVela_Load(object sender, EventArgs e)
        {
            ltvvela.Items.Clear();
            VelaDAO velaDAO = new VelaDAO();
            List<Vela> velas = velaDAO.ListarTodasVelas();
            foreach (var vela in velas)
            {
                ListViewItem linha = new ListViewItem(vela.CodVela.ToString());

                linha.SubItems.Add(vela.NomeVela);
                linha.SubItems.Add(vela.TamanhoVela);
                linha.SubItems.Add(vela.DescricaoVela);
                linha.SubItems.Add(vela.PrecoVela.ToString("F2"));
                ltvvela.Items.Add(linha);

            }
        }

        private void bttsalvar_Click(object sender, EventArgs e)
        {
            string nome = txbnome.Text;
            string tamanho = txbtamanho.Text;
            string descricao = txbdescricao.Text;
            decimal preco = (decimal.Parse(txbpreco.Text));

            Vela vela = new Vela(nome, tamanho, descricao, preco);

            VelaDAO velaDAO = new VelaDAO();


            velaDAO.Insert(vela);
            AtualizarListView();

        }
        private void FrmBroker_Load(object EventArgs)
        {
            AtualizarListView();
        }

        private void ltvvela_MouseDoubleClick(object MouseEventArgs)
        {
            int index;
            try
            {
                index = ltvvela.FocusedItem.Index;
                Id = int.Parse(ltvvela.Items[index].SubItems[0].Text);
                txbnome.Text = ltvvela.Items[index].SubItems[1].Text;
                txbtamanho.Text = ltvvela.Items[index].SubItems[2].Text;
                txbdescricao.Text = ltvvela.Items[index].SubItems[3].Text;
                txbpreco.Text = ltvvela.Items[index].SubItems[4].Text;

            }

            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object EventArgs)
        {
            VelaDAO velaDao = new VelaDAO();

            DialogResult resultado = MessageBox.Show("Tem certeza" +
            " que deseja excluir?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    velaDao.Excluir(Id);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                AtualizarListView();
                ClearFields();
            }
        }

        private void btnClear_Click(object EventArgs)
        {
            ClearFields();

        }

        private void btnUpdate_Click(object EventArgs)
        {
            
                try
                {
                //Capture inputed text from fields.
                new VelaDAO().Atualizar(new Vela(
                    Id, txbnome.Text, txbtamanho.Text, txbdescricao.Text, decimal.Parse(txbpreco.Text)));

                    MessageBox.Show("Corretor atualizado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                AtualizarListView();
                ClearFields();
            
        }
    }
}
        

