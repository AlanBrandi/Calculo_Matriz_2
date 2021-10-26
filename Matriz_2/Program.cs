using System;

namespace Matriz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variável para armazenar número para o teste.
            int num = 0;

            //Pegando os valores para criar a matriz.
            Console.WriteLine("Escreva um valor para M");
            int M = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva um valor para N");
            int N = int.Parse(Console.ReadLine());
            
            //Criação da matriz com os números fornecidos.
            int[,] matriz = new int[M, N];
            //Pegando o número inteiro para armazenar.
            for (int i = 0; i < M; i++)
            {
                for (int o = 0; o < N; o++)
                {
                    Console.WriteLine("Escreva um número inteiro para armazenar!");
                    matriz[i, o] = int.Parse(Console.ReadLine());
                }
            }
            //Coletando qual valor buscar dentro da matriz.
            Console.WriteLine("Escreva um valor que quer buscar: ");
            int val = int.Parse(Console.ReadLine());
            //Procurando e chamando os métodos para calcular seus números a direita, esquerda, cima e baixo.
            for (int i = 0; i < M; i++)
            {
                for (int o = 0; o < N; o++)
                {
                    if (val == matriz[i, o])
                    {
                        Esquerda(i, o);
                        Direita(i, o);
                        Abaixo(i, o);
                        Acima(i, o);
                        Console.WriteLine("--------------------------");
                    }
                }
            }
            //Método que calcula o número da esquerda do fornecido.
           void Esquerda(int i, int o)
           {
                o = o - 1;
                //Realizando um teste para caso não exista número ele retornar uma mensagem.
                if (o < N && o >= 0)
                {
                    num = matriz[i, o];
                    Console.WriteLine("Número da esquerda: " + num);
                }
                else
                {
                    Console.WriteLine("Não possui um número a esquerda");
                }
           }
            //Método que calcula o número da direita do fornecido.
           void Direita(int i, int o)
           {
                o = o + 1;
                //Realizando um teste para caso não exista número ele retornar uma mensagem.
                if (o < N && o >= 0)
                {
                    num = matriz[i, o];
                    Console.WriteLine("Número da direita: " + num);
                }
                else
                {
                    Console.WriteLine("Não possui um número a direita");
                }
           }
            //Método que calcula o número de baixo do fornecido.
           void Abaixo(int i, int o)
           {
                i = i - 1;
                //Realizando um teste para caso não exista número ele retornar uma mensagem.
                if (i < M && i >= 0)
                {
                    num = matriz[i, o];
                    Console.WriteLine("Número abaixo: " + num);
                }
                else
                {
                    Console.WriteLine("Não possui um número abaixo");
                }
               
           }
            //Método que calcula o número de cima do fornecido.
           void Acima(int i, int o)
           {
                i = i + 1;
                //Realizando um teste para caso não exista número ele retornar uma mensagem.
                if (i < M && i >= 0)
                {
                    num = matriz[i, o];
                    Console.WriteLine("Número acima: " + num);
                }
                else
                {
                    Console.WriteLine("Não possui um número acima");
                }
            }
        }
    }
}
