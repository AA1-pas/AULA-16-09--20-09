using AULAMARCELO1909.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULAMARCELO1909
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Random rdm = new Random();

            HashSet<int> dados = new HashSet<int>();
            for (int i = 0; i < 100; i++)
            {
                dados.Add(rdm.Next(100));
            }
            HashSet<int> dados2 = new HashSet<int>();
            while (dados.Count < 100)
            {
                dados.Add(rdm.Next(10000));
            }


            //****************************************************************************************************************



            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa p1 = new Pessoa();
            p1.Nome = "Gabriel";
            p1.Sexo = "M";
            p1.Altura = 2.01;
            p1.Idade = 29;

            pessoas.Add(p1);

            Pessoa p2 = new Pessoa();
            p2.Nome = "Elóra";
            p2.Sexo = "F";
            p2.Altura = 1.53;
            p2.Idade = 21;

            pessoas.Add(p2);

            Pessoa p3 = new Pessoa();
            p3.Nome = "Beatriz";
            p3.Sexo = "F";
            p3.Altura = 1.83;
            p3.Idade = 17;

            pessoas.Add(p3);

            List<Pessoa> menoresDeIdade = new List<Pessoa>();

            foreach (Pessoa p in pessoas)
            {
                if (p.Idade < 18)
                {
                    menoresDeIdade.Add(p);
                }
            }

            //Lambda = Where / OrderBY / FirstOrdefault

            string.Compare("Celo","celo",true);

            List<Pessoa> pessoasOrdenadasPorAltura = pessoas.OrderBy(p => p.Altura).ToList();
            pessoas.Where(pes => pes.Idade < 18);

            List<Pessoa> pessoasOrdenadasPorAlturaDecres = pessoas.OrderByDescending(p => p.Altura).ToList();
            pessoas.Where(pes => pes.Idade < 18);

            List<Pessoa> pessoasOrdenadas = pessoas.OrderBy(p => p.Altura).ThenBy(c => c.Idade).ToList();
            pessoas.Where(pes => pes.Idade < 18);


            //****************************************************************************************************************

            for (int i = 0; i < 10; i++)
            {
                //Gera numero aleatorio de 0 a 100
                int valorGeradoAleatoriamente = rdm.Next(100);
                //Verifica se a lista não contém este número gerado
                bool eRepetido = numeros.Contains(valorGeradoAleatoriamente);

                if(!eRepetido)
                {
                    //adiciona o número gerado pelo random (que não é repetido)
                    numeros.Add(valorGeradoAleatoriamente);
                }
                else
                    i--;            
            }
            Console.ReadKey();
        }

    }
}
