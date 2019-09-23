using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class CalculosDeArea
    {
        /// <summary>
        /// Metodo para retornar a área de um quadrado
        /// </summary>
        /// <param name="ladoDoQuadrado">Lado do quadrado</param>
        /// <returns>Retorna área total do quadrado</returns>
        public double CalculaAreaDoQuadrado(double ladoDoQuadrado)
        {
            return ladoDoQuadrado * ladoDoQuadrado;
        }
    }
}
