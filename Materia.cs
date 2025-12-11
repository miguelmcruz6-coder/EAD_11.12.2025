using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD_11._12._2025
{
    public class Materia
    {
        public string Nome { get; set; }
        public double Nota { get; set; }

        public void MelhorNota(double maximo)
        {
            if (Nota == maximo)
            {
                Console.WriteLine($"Você teve a melhor nota em {Nome} com uma nota de {Nota}.");
            }
        }
        public void MelhoresNotas(double maximo)
        {
            if (Nota == maximo)
            {
                Console.Write($"{Nome}, ");
            }
        }
    }
}
