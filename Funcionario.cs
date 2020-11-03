using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_ClassMethod_C_Shap
{
    class Funcionario
    {
        // Atributos
        public string Nome;
        public double Salario;
        public int Imposto;
        public float Aumento;

        public double Calc_Imposto() //Método para o calculo do imposto.
        {
            double resultado = Salario - Imposto; 

            Salario = resultado; // Salario recebe a atualização, para que os outros métodos possam calcular com o salario atual e não o inserido.

            return Salario; 
        }
    
        public double Calc_Aumento() //Método para o calculo do Aumento.
        {
            double resultado = Aumento / 100; // Calculo de porcetagem.

            resultado++; // Recebe +1 para depois multiplicar pelo salário atualizado.

            return resultado * Salario;
        }
    }
}
