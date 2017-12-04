using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legenda
{
    public class TempoLegenda
    {
        string tempoLegenda;
        string hora;
        string minuto;
        string segundos;
        string milisegundos;

        public override string ToString()
        {
            return tempoLegenda;
        }

        public TempoLegenda(string tempoLegenda)
        {
            string[] tempos = tempoLegenda.Split(':');

            this.tempoLegenda = tempoLegenda;

            hora = tempos[0];
            minuto = tempos[1];
            segundos = tempos[2].Split(',')[0];
            milisegundos = tempos[2].Split(',')[1];
        }

        public string somaLegenda(string valor)
        {            
            int milisegundos;
            int segundos;                    


            if (valor == "  ,    s")
            { 
                throw new DelayMinimoException();
            }
            else
            {
                segundos = int.Parse(valor.Split(' ')[0].Split(',')[0]);
                milisegundos = int.Parse(valor.Split(' ')[0].Split(',')[1]);
            }

            int horaAtualizado = int.Parse(this.hora);
            int minutoAtualizado = int.Parse(this.minuto);
            int segundosAtualizado = int.Parse(this.segundos);
            int milisegundosAtualizado = int.Parse(this.milisegundos) + milisegundos;

            if(milisegundos > 999)
            {
                milisegundosAtualizado = milisegundos - 1000;
                segundosAtualizado = segundosAtualizado + 1;
            }
            if (segundosAtualizado > 59)
            {
                segundosAtualizado = segundosAtualizado - 60;
                minutoAtualizado = minutoAtualizado + 1;
            }
            if (minutoAtualizado > 59)
            {
                minutoAtualizado = minutoAtualizado - 60;
                horaAtualizado = horaAtualizado + 1;
            }


            segundosAtualizado = segundosAtualizado + segundos;

            if (segundosAtualizado > 59)
            {
                segundosAtualizado = segundosAtualizado - 60;
                minutoAtualizado = minutoAtualizado + 1;
            }
            if (minutoAtualizado > 59)
            {
                minutoAtualizado = minutoAtualizado - 60;
                horaAtualizado = horaAtualizado + 1;
            }

            this.hora = toString(horaAtualizado, false);
            this.minuto = toString(minutoAtualizado, false);
            this.segundos = toString(segundosAtualizado, false);
            this.milisegundos = toString(milisegundosAtualizado, true);

            string legenda;

            legenda = string.Format("{0}:{1}:{2},{3}", hora, minuto, this.segundos, this.milisegundos);

            return legenda;
        }

        public string subLegenda(string valor)
        {
            int milisegundos;
            int segundos;


            if (valor == "  ,    s")
            {
                throw new DelayMinimoException();
            }
            else
            {
                segundos = int.Parse(valor.Split(' ')[0].Split(',')[0]);
                milisegundos = int.Parse(valor.Split(' ')[0].Split(',')[1]);
            }

            int horaAtualizado = int.Parse(this.hora);
            int minutoAtualizado = int.Parse(this.minuto);
            int segundosAtualizado = int.Parse(this.segundos);
            int milisegundosAtualizado = int.Parse(this.milisegundos) - milisegundos;

            if (milisegundos < 0)
            {
                milisegundosAtualizado = 1000 + milisegundosAtualizado;
                segundosAtualizado = segundosAtualizado - 1;
            }
            if (segundosAtualizado < 0)
            {
                segundosAtualizado = 60 + segundosAtualizado;
                minutoAtualizado = minutoAtualizado - 1;
            }
            if (minutoAtualizado < 0)
            { 
                minutoAtualizado = 60 + minutoAtualizado;
                horaAtualizado = horaAtualizado - 1;
            }


            segundosAtualizado = segundosAtualizado - segundos;

            if (segundosAtualizado < 0)
            {
                segundosAtualizado = 60 + segundosAtualizado;
                minutoAtualizado = minutoAtualizado - 1;
            }
            if (minutoAtualizado < 0)
            {
                minutoAtualizado = 60 + minutoAtualizado;
                horaAtualizado = horaAtualizado - 1;
            }

            this.hora = toString(horaAtualizado, false);
            this.minuto = toString(minutoAtualizado, false);
            this.segundos = toString(segundosAtualizado, false);
            this.milisegundos = toString(milisegundosAtualizado, true);

            string legenda;

            legenda = string.Format("{0}:{1}:{2},{3}", hora, minuto, this.segundos, this.milisegundos);

            return legenda;
        }

        protected string toString(double valor, bool milisegundo)
        {
            string texto = valor.ToString();

            if (!milisegundo)
            {
                if (texto.Length < 2)
                {
                    texto = "0" + texto;
                }
            }
            else
            {
                if (texto.Length < 3)
                {
                    int tamanho = 3 - texto.Length;

                    for (int i = 0; i < tamanho; i++)
                    {
                        texto = "0" + texto;
                    }
                }
            }

            return texto;
        }
    }
}