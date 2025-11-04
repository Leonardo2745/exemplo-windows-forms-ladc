using Exemplo.Classes;
using System;

namespace Exemplo
{
    public partial class Form1 : Form
    {
        string calc = "";
        Operacoes op;

        public Form1()
        {
            InitializeComponent();
            op = new Operacoes();
        }

      
        private void precisaDeCampoY()
        {
            bool usaY = calc == "soma" || calc == "subtracao" || calc == "multiplicacao" || calc == "divisao" || calc == "porcentagem" || calc == "elevado";

            inputTextY.Enabled = usaY;
            if (!usaY)
            {
                inputTextY.Visible = false;
            }
            else
            {
                inputTextY.Visible = true;
            }
                
        }


        public bool setInputs()
        {
            try
            {
                double x = double.Parse(inputTextX.Text);
                op.setXFromInput(x);

                
                if (inputTextY.Enabled )
                {
                    double y = double.Parse(inputTextY.Text);
                    op.setYFromInput(y);
                }
                else
                {
                    op.setYFromInput(0); 
                }

                return true;
            }
            catch
            {
                labelOutput.Visible = true;
             
                return false;
            }
        }

        public void printResult(double x, double y, string operacao, double result)
        {
            string formatoSaida;

            if (calc == "soma" || calc == "subtracao" || calc == "multiplicacao" ||
                calc == "divisao" || calc == "porcentagem" || calc == "elevado")
            {
                formatoSaida ="Resultado da" + operacao + "entre " + x + " e " + y + "é igual a: " + result;
            }
            else
            {
                formatoSaida = "Resultado da" + operacao + " de " + x + " é: " + result;
            }

            labelOutput.Visible = true;
            labelOutput.Text = formatoSaida;
        }

        
        private void btnSoma_Click(object sender, EventArgs e)
        {
            calc = "soma"; 
            precisaDeCampoY();
            if (!setInputs()) return;

            double result = op.soma();
            printResult(op.getX(), op.getY(), "soma", result);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            calc = "subtracao";
            precisaDeCampoY();
            if (!setInputs()) return;

            double result = op.subtracao();
            printResult(op.getX(), op.getY(), "subtração", result);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            calc = "multiplicacao";
            precisaDeCampoY();
            if (!setInputs()) return;

            double result = op.multi();
            printResult(op.getX(), op.getY(), "multiplicação", result);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            calc = "divisao";
            precisaDeCampoY();
            if (!setInputs()) return;

            double result = op.divisao();
            printResult(op.getX(), op.getY(), "divisão", result);
        }

        private void btnQuad_Click(object sender, EventArgs e)
        {
            calc = "quadrado";
            precisaDeCampoY();
            if (!setInputs()) return;

            double result = op.quadrado();
            printResult(op.getX(), op.getY(), "quadrado", result);
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            calc = "raiz";
            precisaDeCampoY();
            if (!setInputs()) return;

            double result = op.raiz();
            printResult(op.getX(), op.getY(), "raiz quadrada", result);
        }

        private void btnPorc_Click(object sender, EventArgs e)
        {
            calc = "porcentagem";
            precisaDeCampoY();
            if (!setInputs()) return;

            double result = op.porcentagem();
            printResult(op.getX(), op.getY(), "porcentagem", result);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            calc = "binario";
            precisaDeCampoY();
            if (!setInputs()) return;

            double result = op.binario();
            printResult(op.getX(), op.getY(), "binário", result);
        }

        private void btnElev_Click(object sender, EventArgs e)
        {
            calc = "elevado"; 

            if (!setInputs()) return;

            double result = op.elevado();
            printResult(op.getX(), op.getY(), "elevado", result);
        }
    }
}
