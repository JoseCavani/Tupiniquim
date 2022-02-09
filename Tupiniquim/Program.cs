using System;

namespace Tupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contador = 0;
            int x2 = 3, y2 = 3, x = 1, y = 2;
            char orientacao2 = 'L';
            bool segundorobo = false;
            char orientacao = 'N';
            while (true)
            {
            volta:
                Console.Clear();
                Console.WriteLine("5 5");
                if (segundorobo == false)
                {
                    x = 1; y = 2; orientacao = 'N';//caso de algum valor invalido essa linha reseta os valores
                    Console.WriteLine(x + " " + y + " " + orientacao);
                }
                else
                {
                    x2 = 3; y2 = 3; orientacao2 = 'L'; //caso de algum valor invalido essa linha reseta os valores
                    Console.WriteLine(x2 + " " + y2 + " " + orientacao2);
                }

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
                        goto volta; // coninue nao funcionou nao reseta valores na linha 26 e 21 e tambem faz o commando aconetecer novamnete para todos os valores incorretos
                    }

                    if (segundorobo == false)
                    {
                        switch (commando)
                        {
                            case 'E':

                                switch (orientacao)
                                {


                                    case 'N':
                                        orientacao = 'O';
                                        break;
                                    case 'O':
                                        orientacao = 'S';
                                        break;
                                    case 'S':
                                        orientacao = 'L';
                                        break;
                                    case 'L':
                                        orientacao = 'N';
                                        break;
                                }
                                continue;
                            case 'D':
                                switch (orientacao)
                                {
                                    case 'N':
                                        orientacao = 'L';
                                        break;
                                    case 'O':
                                        orientacao = 'N';
                                        break;
                                    case 'S':
                                        orientacao = 'O';
                                        break;
                                    case 'L':
                                        orientacao = 'S';
                                        break;
                                }
                                continue;
                            case 'M':
                                switch (orientacao)
                                {
                                    case 'L':
                                        if (x < 5)
                                        {
                                            x = x + 1;
                                        }
                                        break;
                                    case 'N':
                                        if (y < 5)
                                        {
                                            y = y + 1;
                                        }

                                        break;
                                    case 'S':
                                        if (y > 0)
                                        {
                                            y = y - 1;
                                        }
                                        break;
                                    case 'O':
                                        if (x > 0)
                                        {
                                            x = x - 1;
                                        }
                                        break;
                                }
                                continue;
                        }
                    }
                    else
                    {
                        switch (commando)
                        {
                            case 'E':

                                switch (orientacao2)
                                {

                                    case 'N':
                                        orientacao2 = 'O';
                                        break;
                                    case 'O':
                                        orientacao2 = 'S';
                                        break;
                                    case 'S':
                                        orientacao2 = 'L';
                                        break;
                                    case 'L':
                                        orientacao2 = 'N';
                                        break;
                                }
                                continue;
                            case 'D':
                                switch (orientacao2)
                                {
                                    case 'N':
                                        orientacao2 = 'L';
                                        break;
                                    case 'O':
                                        orientacao2 = 'N';
                                        break;
                                    case 'S':
                                        orientacao2 = 'O';
                                        break;
                                    case 'L':
                                        orientacao2 = 'S';
                                        break;
                                }
                                continue;
                            case 'M':
                                switch (orientacao2)
                                {
                                    case 'L':
                                        if (x2 < 5)
                                        {
                                            x2 = x2 + 1;
                                        }
                                        break;
                                    case 'N':
                                        if (y2 < 5)
                                        {
                                            y2 = y2 + 1;
                                        }
                                        break;
                                    case 'S':
                                        if (y2 > 0)
                                        {
                                            y2 = y2 - 1;
                                        }
                                        break;
                                    case 'O':
                                        if (x2 > 0)
                                        {
                                            x2 = x2 - 1;
                                        }
                                        break;
                                }
                                continue;
                        }
                    }
                }

                segundorobo = true;
                contador++;
                if (contador == 1)
                {
                    Console.WriteLine("posição do robo 1 : " + x + " " + y + " " + orientacao);
                    Console.WriteLine("aperta alguma tecla para iniciar o segundo robo");
                    Console.ReadKey();
                    continue;
                }
                else
                    Console.WriteLine("posição do robo 2 : " + x2 + " " + y2 + " " + orientacao2);
                Console.ReadKey();
                break;
            }
        }
    }
}