using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace Legenda
{
    public class Legenda
    {
        string arquivo;

        List<string> falas = new List<string>();

        List<Fala> listaFalas = new List<Fala>();

        public Legenda(string arquivo)
        {
            this.arquivo = arquivo;

            LeArquivo(arquivo);
        }

        public void SincronizaLegenda(int contador, string tempoDelay, string tipoDelay)
        {
            try
            {
                for (int i = contador; i < listaFalas.Count; i++)
                {
                    falas[listaFalas[i].index] = listaFalas[i].AtualizaFala(tipoDelay, tempoDelay);
                }

                SalvarLegenda(arquivo);                
            }
            catch (DelayMinimoException e)
            {
                throw e;                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Erro");
                return;
            }

            MessageBox.Show("Arquivo atualizado.", "Legenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<Fala> BuscaFala(string texto)
        {
            List<Fala> falas = new List<Fala>();            

            foreach (Fala l in listaFalas)
            {
                if (l.fala.Contains(texto)) falas.Add(l);
            }
            return falas;
        }

        private void SalvarLegenda(string arquivo)
        {
            StreamWriter sw = null;
            int contadorFala = 2;

            try
            {
                File.SetAttributes(arquivo, FileAttributes.Normal);

                sw = new StreamWriter(arquivo, false, Encoding.GetEncoding(28591));

                for (int linha = 0; linha < falas.Count; linha++)
                {
                    sw.WriteLine(falas[linha].Substring(0, falas[linha].Length));
                    
                    if((linha != 0 && linha != falas.Count - 1) && falas[linha + 1] == contadorFala.ToString())
                    {
                        sw.WriteLine();
                        contadorFala++;
                    }
                }

                sw.Close();
            }
            catch (Exception ex)
            {
                sw.Close();
                throw ex;
            }
        }

        public string ArrumaFala(string fala)
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

        private void LeArquivo(string arquivo)
        {
            StreamReader sr = new StreamReader(arquivo, Encoding.GetEncoding(28591));

            string arq = sr.ReadToEnd();
            falas = arq.Split('\n', '\r').Where(x => x != "").ToList();          

            sr.Close();

            int numeroFala, i = 0, contadorFala = 1;
            string textoLegenda = "";

            while(i < falas.Count)
            {
                if (int.TryParse(falas[i], out numeroFala) && numeroFala == contadorFala)
                {
                    int j = i + 2;

                    while (j != falas.Count - 1 && !int.TryParse(falas[j], out numeroFala))
                    {
                        if (numeroFala != contadorFala + 1)
                        {
                            textoLegenda += falas[j] + '\n';

                            j++;
                        }
                    }

                    Fala legenda = new Fala(falas[i + 1], i + 1, contadorFala, textoLegenda);
                    listaFalas.Add(legenda);
                    textoLegenda = "";
                    i = j;
                    contadorFala++;
                }
                else
                    i++;
            }
        }
    }
}
