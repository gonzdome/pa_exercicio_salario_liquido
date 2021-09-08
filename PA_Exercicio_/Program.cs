using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_Exercicio_
{
    class Program
    {
        static void Main(string[] args)
        {
            double salbruto, valalimento, xfilho, numfilho, xhrextra, valhrextra, descinss, descirpf, salliquido;

            Console.WriteLine("Qual o valor do salário bruto?: ");
            salbruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do vale alimentação?: ");
            valalimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o número de filhos?: ");
            numfilho = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor por filho?: ");
            xfilho = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o número de horas extras?: ");
            xhrextra = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor das horas?: ");
            valhrextra = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do INSS: ");
            descinss = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o Valor do IRPF: ");
            descirpf = double.Parse(Console.ReadLine());

            xfilho = xfilho * numfilho;

            xhrextra = xhrextra * valhrextra;

            salliquido = salbruto + valalimento + xfilho + xhrextra - descinss - descirpf;

            Console.WriteLine("O salário líquido é de: R$" + salliquido.ToString("c") + " !");


            Console.ReadKey();
        }
    }
}
