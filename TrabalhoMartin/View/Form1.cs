using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoMartin
{
    public partial class Form1 : Form
    {
        List<Pessoas> listaPessoa = new List<Pessoas>();
        public Form1()
        {
            InitializeComponent();

            maskedTxtBuscaId.Visible = false;
            lblAlterar.Visible = false;

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            maskedTxtBuscaId.Visible = true;
            lblAlterar.Visible = true;

            Pessoas pessoas1 = new Pessoas();

            pessoas1.ID = maskedTxtBuscaId.Text;
            pessoas1.Nome = txtbNome.Text;
            pessoas1.Idade = Convert.ToInt32(txtbIdade.Text);
            pessoas1.Email = textBoxEmail.Text;
            pessoas1.Peso = float.Parse(txtbPeso.Text);
            pessoas1.Altura = float.Parse(txtbAltura.Text);

            listaPessoa.Add(pessoas1);

            dataDados.DataSource = null;
            dataDados.DataSource = listaPessoa;

            limparCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            lblAlterar.Enabled = true;
            maskedTxtBuscaId.Enabled = true;

            foreach (var Pessoas in listaPessoa)
            {
                if (Pessoas.Nome == maskedTxtBuscaId.Text)
                {
                    Pessoas.Nome = txtbNome.Text;
                    Pessoas.Idade = Convert.ToInt32(txtbIdade.Text);
                    Pessoas.Email = textBoxEmail.Text;
                    Pessoas.Peso = float.Parse(txtbPeso.Text);
                    Pessoas.Altura = float.Parse(txtbAltura.Text);

                    dataDados.DataSource = null;
                    dataDados.DataSource = listaPessoa;

                    limparCampos();

                }
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir(maskedTxtBuscaId.Text);

            //mostrando dados no DataGridView
            dataDados.DataSource = null;
            dataDados.DataSource = listaPessoa;

        }


        private void limparCampos()
        {
            txtbNome.Clear();
            txtbIdade.Clear();
            textBoxEmail.Clear();
            txtbPeso.Clear();
            txtbAltura.Clear();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Busca(maskedTxtBuscaId.Text);

            //mostrando dados no DataGridView
            dataDados.DataSource = null;
            dataDados.DataSource = listaPessoa;
        }




        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você Realmente Deseja Sair?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    

        public void Excluir(string exclui_dados)
        {
            //remove dados na lista
            foreach (var Pessoas in listaPessoa)
            {
                if (Pessoas.ID == maskedTxtBuscaId.Text)
                {
                    listaPessoa.Remove(Pessoas);
                    break;
                }

            }
        }

        public void Busca(string buscaDados)
        {
            //procurando dados da lista
            foreach (var Pessoas in listaPessoa)
            {
                if (Pessoas.ID == maskedTxtBuscaId.Text)
                {
                    Pessoas.Nome = txtbNome.Text;
                    Pessoas.Idade = Convert.ToInt32(txtbIdade.Text);
                    Pessoas.Email = textBoxEmail.Text;
                    Pessoas.Peso = float.Parse(txtbPeso.Text);
                    Pessoas.Altura = float.Parse(txtbAltura.Text);
                }
            }
        }
    }
}

