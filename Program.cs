using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_ClassMethod_C_Shap
{
    class Program
    {
        static void Main()
        {

            Funcionario p = new Funcionario();

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Salário: ");
            p.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Imposto: ");
            p.Imposto = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Aumento: ");
            p.Aumento = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Funcionario {0}, {1} Salário, {2} Imposto.", p.Nome, p.Salario, p.Imposto);
            Console.WriteLine("\n");

            double Sal = p.Calc_Imposto();

            Console.Write("Devido ao imposto seu salário é de {0}.", Sal);
            Console.WriteLine("\n");

            double Aumento = p.Calc_Aumento();

            Console.Write("Mas {0} obteve um aumento de {1}%. Seu salário agora é de {2}", p.Nome, p.Aumento, Aumento);

            Console.Read();
        }
    }
}
