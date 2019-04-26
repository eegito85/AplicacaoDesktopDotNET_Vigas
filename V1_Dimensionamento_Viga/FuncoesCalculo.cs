using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_Dimensionamento_Viga
{
    class FuncoesCalculo
    {
        //CALCULA MOMENTO FLETOR
        public double[] calculaMomentoFletor1(double Eaco, double d, double Ecmax, double dl, double fyk, double fck, double alfa, double lambda, double b, double As, double Asl)
        {
            //DECLARAÇÃO DE VARIÁVEIS
            double[] resultados = new double[4];
            double Es = 0;
            double Esl = 0;
            double fsl = 0;
            double fcd = (fck / 1.4);
            double Rcc = 0;
            double Rcs = 0;
            double T = 0;
            double R = 0;
            double erro = 0;
            double x = 0;
            //ESTABELECE-SE INICIALMENTE UM VALOR PARA A LINHA NEUTRA
            x = d / 3;
            //CALCULA A DEFORMAÇÃO DO AÇO À COMPRESSÃO A PARTIR DA DEFORMAÇÃO MÁXIMA DO CONCRETO
            Esl = ((x - dl) / x) * Ecmax;
            fsl = Eaco * (Esl / 1000);
            //CALCULA COMPRESSÃO NO CONCRETO
            Rcc = (alfa * fcd * b * lambda * x * 0.1);
            //CALCULA COMPRESSÃO NO AÇO
            Rcs = Asl * 0.1 * (fsl - (alfa * fcd)); //----->>> LIVRO DO WIGHT & MCGREGOR
            //TRAÇÃO NO AÇO
            T = As * (fyk / 1.15) * 0.1;
            //RESULTANTE TOTAL DE COMPRESSÃO
            R = Rcc + Rcs;
            erro = (Math.Abs(R - T)) / R;
            //INÍCIO DA SÉRIE DE ITERAÇÕES PARA SE OBTER O RESULTADO MAIS PRÓXIMO
            //ESTABELECI UM ERRO DE 2%
            while (erro > 0.02)
            {
                if (T > R) { x = x + 0.01; }
                else if (T < R) { x = x - 0.01; }
                Esl = ((x - dl) / x) * Ecmax;
                fsl = Eaco * (Esl / 1000);
                Rcc = (alfa * fcd * b * lambda * x * 0.1);
                Rcs = Asl * 0.1 * (fsl - (alfa * fcd));
                R = Rcc + Rcs;
                erro = (Math.Abs(R - T)) / R;
            }
            Es = ((d - x) / x) * Ecmax;
            //CÁLCULO DO MOMENTO
            double momento = (Rcc * 0.01*(d - ((lambda * x) / 2))) + (Rcs * 0.01*(d - dl));
            resultados[0] = Math.Round(momento, 2);
            resultados[1] = Math.Round(x, 2);
            resultados[2] = Math.Round(Es, 2);
            resultados[3] = Math.Round(Esl, 2);
            return resultados;
        }

    }
}
