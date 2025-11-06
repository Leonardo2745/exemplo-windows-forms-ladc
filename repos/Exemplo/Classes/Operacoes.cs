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
            return this.x / this.y;
        }

        public double quadrado()
        {
            return this.x * this.x;
        }
        public double raiz()
        {
            return Math.Round(Math.Sqrt(this.x));
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
                string resultado = "";

                while (value > 0)
                {
                    long resto = value % 2;

                    value /= 2;

                    resultado += (resto == 0) ? 1 : 0;

                }
                return int.Parse(resultado);

            }
        }
        public double elevado()
        {
            return Math.Pow(this.x, this.y);
        }

    }
}