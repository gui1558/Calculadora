using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Xml;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();

            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' });

            Calculadora calculadora = new Calculadora();
            Stack<double> pilhaResultados = new Stack<double>();

            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.calcular(operacao);

                Console.WriteLine("Operacao realizada: ");
                Console.WriteLine("");
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);
                Console.WriteLine("");
             
                pilhaResultados.Push((double)operacao.resultado);

                
                Console.WriteLine("Operações restantes:");
                
                foreach (Operacoes op in filaOperacoes)
                {
                    
                    Console.WriteLine("{0} {1} {2}", op.valorA, op.operador, op.valorB);
                    
                }

                Console.WriteLine("");
            }

            if (filaOperacoes.Count == 0)
            {
                Console.WriteLine(" Todas as operacoes foram realizadas");
                Console.WriteLine("");


            }
            else
            {
                Console.WriteLine("");
                
            }

           
            Console.WriteLine("Resultados na pilha:");
            Console.WriteLine("---------------------");
            foreach (var resultado in pilhaResultados)
            {
                
                Console.WriteLine(resultado);
            }
        }
    }
}