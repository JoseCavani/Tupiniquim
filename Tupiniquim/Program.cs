using System;
using System.Collections.Generic;

namespace Tupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while (true)
            {
            volta:
                List<Robo> robos = new List<Robo>();
                Robo robo1 = new Robo(1, 2, 'N');
                robos.Add(robo1);
                Robo robo2 = new Robo(3, 3, 'L');
                robos.Add(robo2);
                Console.Clear();
                if (contador == 0)
                {
                    Console.WriteLine("5 5");
                }
                Console.WriteLine(robos[contador].X + " " + robos[contador].Y + " " + robos[contador].Orientacao);
 
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
                        robos.Remove(robos[contador]);
                        goto volta; // coninue nao funcionou nao reseta valores e tambem faz o commando aconetecer novamnete para todos os valores incorretos
                    }

                        switch (commando)
                        {
                            case 'E':

                            robos[contador].Orientacao = Funcoes.esquerda(robos[contador].Orientacao);
                                continue;
                            case 'D':
                            robos[contador].Orientacao = Funcoes.direita(robos[contador].Orientacao); 
                                continue;
                            case 'M':
                                if (robos[contador].Orientacao == 'N' || robos[contador].Orientacao == 'S')
                                robos[contador].Y = Funcoes.movimento(robos[contador].Orientacao, robos[contador].Y);
                                else
                                robos[contador].X = Funcoes.movimento(robos[contador].Orientacao, robos[contador].X);

                                continue;
                        }
                    }

                    Console.WriteLine( robos[contador].X + " " + robos[contador].Y + " " + robos[contador].Orientacao);
                    Console.ReadKey();
                contador++;
                if (robos.Count != contador)
                {
                    continue;
                }
                else
                break;
            }
        }
    }
}

