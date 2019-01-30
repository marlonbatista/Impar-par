using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_de_Impar_ou_Par
{
    class Program
    {
        static void Main(string[] args)
        {//Declaração de variável
            double num;
            //Entrada de Dados

            Console.Write("Informe o valor :");
            num = double.Parse(Console.ReadLine());
            //processamento

            if ( num%2==0)
            {
                Console.Write("\nO número é par : " + num);
            }
            else
            {
                Console.Write("\nO número é impar :" + num);
            }
            Console.ReadKey();
        }
    }
}
