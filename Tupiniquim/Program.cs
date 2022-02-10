using System;
using System.Collections.Generic;

namespace Tupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxY = 0, maxX = 0;
            string posicao;
            List<Robo> robos = new List<Robo>();
            while (true)
            {
                Robo robo = new Robo();
                if (robos.Count == 0)
                {
                    Console.WriteLine("digite os valores maximos de X e Y seperado por espaco (X Y)");
                    posicao = Console.ReadLine();
                    try
                    {
                        maxX = int.Parse(posicao.Split(' ')[0]);
                        maxY = int.Parse(posicao.Split(' ')[1]);
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("sequencia contem valore(s) invalido(s)");
                        Console.ReadKey();
                        Console.ResetColor();
                        continue;
                    }
                }
            volta:
                Console.Clear();
                Console.WriteLine($"digite os valores  iniciais do robo {robos.Count + 1} seperado por espaco (X Y Orientação)");
                posicao = Console.ReadLine();
                try
                {
                    robo.X = int.Parse(posicao.Split(' ')[0]);
                    robo.Y = int.Parse(posicao.Split(' ')[1]);
                    robo.Orientacao = char.Parse(posicao.ToUpper().Split(' ')[2]);
                    if (robo.Orientacao != 'l' && robo.Orientacao != 'O' && robo.Orientacao != 'N' && robo.Orientacao != 'S')
                        throw new Exception();
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("sequencia contem valore(s) invalido(s)");
                    Console.ReadKey();
                    Console.ResetColor();
                    goto volta;
                }
                Console.Clear();

                Console.Write("instruções: \n Letra E gira 90 graus para a esquerda\n Letra D gira 90" +
                    " graus para a direita \n Letra M movimenta para frente \n");

                Console.WriteLine("digite os commandos");
                string stringCommandos = Console.ReadLine();

                foreach (char commando in stringCommandos.Trim())
                {
                    if (commando != 'E' && commando != 'D' && commando != 'M')
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("sequencia contem valore(s) invalido(s)");
                        Console.ReadKey();
                        Console.ResetColor();
                        goto volta; // coninue faz o commando aconetecer novamnete para todos os valores incorretos
                    }
                }

                    foreach (char commando in stringCommandos.Trim())
                {

                        switch (commando)
                        {
                            case 'E':

                            robo.Orientacao = Funcoes.esquerda(robo.Orientacao);
                                continue;
                            case 'D':
                            robo.Orientacao = Funcoes.direita(robo.Orientacao); 
                                continue;
                            case 'M':
                                if (robo.Orientacao == 'N' || robo.Orientacao == 'S')
                                robo.Y = Funcoes.movimento(robo.Orientacao, robo.Y, maxY);
                                else
                                robo.X = Funcoes.movimento(robo.Orientacao, robo.X, maxX);
                                continue;
                        }
                    }
                    robos.Add(robo);
                    Console.WriteLine( robo.X + " " + robo.Y + " " + robo.Orientacao);
                    Console.ReadKey(true);
                if (robos.Count != 2)
                {
                    continue;
                }
                else
                {
                    foreach (var item in robos)
                    {
                        Console.WriteLine($"robo {robos.IndexOf(item) + 1} posição : " + item.X + " " + item.Y + " " + item.Orientacao);
                    }
                    Console.ReadKey(true);
                    break;
                }
            }
        }
    }
}

