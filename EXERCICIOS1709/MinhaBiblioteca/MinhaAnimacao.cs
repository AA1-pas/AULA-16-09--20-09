using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public static class MinhaAnimacao
    {
        /// <summary>
        /// Metodo desenha cada linha da arvore
        /// </summary>
        /// <param name="espacador">recebe quantos espacos deve imprimir</param>
        private static void EspacoArvore(double espacador)
        {
            for (int i = 0; i < espacador; i++)
            {
                Console.Write(" ");
            }
        }

        /// <summary>
        /// metodo contem os dados e desenha a arvore
        /// </summary>
        public static void DesenhaArvore()
        {
            List<int> formatoArvore = new List<int>
            { 5,9,8,14,12,16,13,17,14,15,12,13,10,10,4,4,4,4,4,4,4,4,5,6,8,13,40};
            int k = 0;
            var cont = 0;

            for (int j = 20; j <= 25; j++)
            {
                if (j < 25)
                {
                    foreach (var i in formatoArvore)
                    {
                        EspacoArvore(40 - i);
                        if (cont >= 19 && cont <= 20)
                            DesenhandoALinhaArvore(2 * (i - k));
                        else
                            DesenhandoALinhaArvore(2 * i);
                        Console.Write("\n");
                        cont++;
                    }
                    Thread.Sleep(250);
                    k++;
                    cont = 0;
                    Console.Clear();
                }
                else
                {
                    foreach (var i in formatoArvore)
                    {
                        EspacoArvore(40 - i);
                        if (cont > 20)
                            DesenhandoALinhaArvore(2 * i);
                        Console.Write("\n");
                        cont++;
                    }
                }
            }
           
        }

        /// <summary>
        /// Metodo desenha cada linha da arvore
        /// </summary>
        /// <param name="espacador">recebe quantos caracteres deve imprimir</param>
        private static void DesenhandoALinhaArvore(int espacador)
        {
            for (int i = 0; i < espacador; i++)
            {
                Console.Write("#");
            }
        }
    }
}
