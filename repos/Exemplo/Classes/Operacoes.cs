using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.Classes
{
    internal class Operacoes
    {
        double x, y;
        public Operacoes()
        {
            x = 0; y = 0;
        }

        //Getters e Setters

        public void setXFromInput(double x)
        {
            this.x = x;
        }

        public double getX()
        {
            return this.x;
        }



        public void setYFromInput(double y)
        {
            this.y = y;
        }
        public double getY()
        {
            return this.y;
        }


        //--------------------

        public double soma()
        {
            return this.x + this.y;
        }

       
        public double subtracao()
        {
            return this.x - this.y;
        }
        public double multi()
        {
            return this.x * this.y;
        }
        public double divisao()
        {
            return Math.Round((this.x / this.y),5);
        }

        public double quadrado()
        {
            return this.x * this.x;
        }
        public double raiz()
        {
            return Math.Round(Math.Sqrt(this.x), 5);
        }

        public double porcentagem()
        {
            return (this.x / 100) * this.y;
        }

        public int binario()
        {
            long value = (long)this.x;

            if (value <= 0)
            {
                return 0000;
            }
            else
            {
                string restos = "";

                while (value > 0)
                {
                    restos += value % 2;

                    value = value / 2;

                }
                string resultadoBinario = "";
                for (int i = restos.Length-1;i >= 0; i--)
                {
                    resultadoBinario += restos[i];
                }
                return int.Parse(resultadoBinario);
            }
        }
        public double elevado()
        {
            int count = 0;
            double result = this.x;
            while(count < this.y-1)
            {
                result += this.y;
                count++;

            }
            return result;
        }

    }
}