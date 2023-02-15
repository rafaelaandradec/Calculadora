using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6, Sair = 7}

        static void Main(string[] args)
        {

            bool escolheuSair = false;
            while (!escolheuSair) 
            { 
                Console.WriteLine("Bem vindo(a) ao CALC, selecione uma das opções: ");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
               
                Console.Clear();
            }
            
        }

        static void Soma()
        {
            Console.WriteLine("Você selecionou a opção SOMA: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte o ENTER para voltar ao menu.");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Você selecionou a opção SUBTRAÇÃO: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte o ENTER para voltar ao menu.");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Você selecionou a opção DIVISÃO: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float) a / (float) b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte o ENTER para voltar ao menu.");
            Console.ReadLine();
        }

        static void Multiplicacao() 
        {
            Console.WriteLine("Você selecionou a opção MULTIPLICAÇÃO: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte o ENTER para voltar ao menu.");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("Você selecionou a opção POTÊNCIA: ");
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo) ;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte o ENTER para voltar ao menu.");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Você selecionou a opção RAIZ: ");
            Console.WriteLine("Digite o número: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte o ENTER para voltar ao menu.");
            Console.ReadLine();
        }
    }
}
