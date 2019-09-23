using EXERCICIOS19092019.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaAmigos = new List<Amigos>()
            {
                new Amigos
                {
                    Nome = "José",
                    TempoAmizade = 5
                },

                 new Amigos
                {
                    Nome = "Mathues",
                    TempoAmizade = 15
                },

                  new Amigos
                {
                    Nome = "Renato",
                    TempoAmizade = 1
                }
            };
            listaAmigos.ForEach(i => Console.WriteLine($"O amigo é o {i.Nome} com {i.TempoAmizade} ano(s) de amizade."));
            Console.ReadKey();
        }
    }
}
