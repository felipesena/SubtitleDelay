using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legenda
{
    public partial class frmLegenda : Form
    {
        string arquivo;

        int contador;       

        Fala retorno;

        Legenda legenda;

        public frmLegenda()
        {
            InitializeComponent();            
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog arq = new OpenFileDialog();
            arq.Filter = "Arquivo SRT |*.srt|Arquivo sem formatação |*.txt";

            if (arq.ShowDialog() == DialogResult.OK)
            {
                txbArquivo.Text = arq.FileName;
                arquivo = arq.FileName;

                try
                {
                    legenda = new Legenda(arquivo);
                    cbFalas.Visible = true;
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Gentileza insira algum arquivo a ser modificado", "Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void Retorno(Fala procurada)
        {
            this.contador = procurada.numeroDaFala - 1;
            this.retorno = procurada;

            lbFala.Text = legenda.ArrumaFala(procurada.fala);
            lbFala.Visible = true;
            txbFala.Text = "";
        }        

        private void btnSincronizar_Click(object sender, EventArgs e)
        {
            if (cbFalas.SelectedItem == null)
                MessageBox.Show("Selecione quais falas deseja alterar.", "Legenda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                string radioButton;

                if (rbAdiantada.Checked)
                {
                    radioButton = "Adiantada";
                }
                else
                {
                    radioButton = "Atrasada";
                }

                try
                {
                    legenda.SincronizaLegenda(contador, txbDelay.Text, radioButton);
                }
                catch (DelayMinimoException)
                {
                    MessageBox.Show("Deve ser inserido no mínimo o valor dos milisegundos para o tempo de delay.", "Tempo de Delay", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void btnProcurarFala_Click(object sender, EventArgs e)
        {         
            List<Fala> resultBusca = new List<Fala>();

            resultBusca = legenda.BuscaFala(txbFala.Text);

            if (resultBusca.Count == 0)
                MessageBox.Show("Palavra buscada não foi encontrada em nenhuma parte da Legenda", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                frmPesquisa pesquisa = new frmPesquisa(resultBusca, this);
                pesquisa.ShowDialog();
            }
        }

        private void cbFalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFalas.SelectedIndex == 0)
            {
                contador = 0;

                lbInicio.Visible = false;
                txbFala.Visible = false;
                btnProcurarFala.Visible = false;
                lbFala.Visible = false;
                lbAPartirDe.Visible = false;
            }
            else
            {
                lbInicio.Visible = true;
                txbFala.Visible = true;
                btnProcurarFala.Visible = true;
                lbAPartirDe.Visible = true;
            }
        }
    }
}
