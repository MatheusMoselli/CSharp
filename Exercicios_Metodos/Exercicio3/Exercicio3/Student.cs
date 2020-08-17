using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    class Student
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string PassaAno()
        {
            if (NotaFinal() < 60.0)
            {
                return "REPROVADO";
            } else
            {
                return "APROVADO";
            }
        }
    }
}
