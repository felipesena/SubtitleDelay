using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legenda
{
    public partial class frmPesquisa : Form
    {
        List<Fala> listLegendas;
        frmLegenda formulario;

        public frmPesquisa(List<Fala> resultado, frmLegenda form)
        {
            InitializeComponent();

            this.listLegendas = resultado;
            this.formulario = form;

            ListViewItem item;

            foreach(Fala l in resultado)
            {                
                item = new ListViewItem(new string[]{ $"{l.tempoInicio}", ArrumaFala(l.fala) });
                listViewLegendas.Items.Add(item);                
            }
        }

        private string ArrumaFala(string fala)
        {
            while (fala.Contains("<"))
            {
                if (fala[0] == '<')
                    fala = fala.Substring(fala.IndexOf('>') + 1);
                else
                    fala = fala.Substring(0, fala.IndexOf('<'));
            }

            return fala;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selecionado = listViewLegendas.SelectedItems;

            if (selecionado.Count == 0)
            {
                MessageBox.Show("Favor selecione alguma fala.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Fala retorno = listLegendas.Find(x => x.tempoInicio.ToString() == selecionado[0].Text);

                formulario.Retorno(retorno);
                
                this.Close();
            }
        }
    }
}
