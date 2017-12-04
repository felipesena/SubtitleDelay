using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legenda
{
    public class Fala
    {        
        public TempoLegenda tempoInicio;
        public TempoLegenda tempoFinal;
        public int numeroDaFala { get; }
        public string fala { get; }
        public int index;        

        public Fala(string tempoLegenda, int index, int numeroDaFala, string fala)
        {
            this.tempoInicio = new TempoLegenda(tempoLegenda.Split(' ')[0]);
            this.tempoFinal = new TempoLegenda(tempoLegenda.Split(' ')[2]);

            this.index = index;            
            this.numeroDaFala = numeroDaFala;
            this.fala = fala;
        }

        public string AtualizaFala(string radioButton, string tempoDelay)
        {
            string tempo;

            if (radioButton == "Atrasada")
            {
                tempo = string.Format("{0} --> {1}", tempoInicio.subLegenda(tempoDelay), tempoFinal.subLegenda(tempoDelay));

                return tempo;
            }
            else
            {
                tempo = string.Format("{0} --> {1}", tempoInicio.somaLegenda(tempoDelay), tempoFinal.somaLegenda(tempoDelay));

                return tempo;
            }
        }
    }
}
