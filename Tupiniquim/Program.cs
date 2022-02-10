using System;
namespace Tupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x2 = 3, y2 = 3, x = 1, y = 2,maxX=0,maxY=0;
            string posicao;
            char orientacao2 = 'L';
            bool segundorobo = false;
            char orientacao = 'N';
            while (true)
            {
            volta:
                Console.Clear();
                if (segundorobo == false)
                {
                    Console.WriteLine("digite os valores maximos de X e Y seperado por espaco (X Y)");
                    posicao = Console.ReadLine();// 4 5
                    try
                    {
                        maxX = int.Parse(posicao.Split(' ')[0]);//4 5
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
                    volta1:
                    Console.WriteLine($"digite os valores  iniciais do robo 1 seperado por espaco (X Y Orientação)");
                    posicao = Console.ReadLine();
                    try
                    {
                       x = int.Parse(posicao.Split(' ')[0]);
                       y = int.Parse(posicao.Split(' ')[1]);
                       orientacao = char.Parse(posicao.ToUpper().Split(' ')[2]);
                        if (x>maxX || y>maxY || x< 0 || y < 0)
                            throw new InvalidOperationException();
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("sequencia contem valore(s) invalido(s)");
                        Console.ReadKey();
                        Console.ResetColor();
                        goto volta1;
                    }
                    Console.Clear();
                }
                else
                {
                    volta2:
                    Console.WriteLine($"digite os valores  iniciais do robo 2 seperado por espaco (X Y Orientação)");
                    posicao = Console.ReadLine();
                    try
                    {
                        x2= int.Parse(posicao.Split(' ')[0]);
                        y2 = int.Parse(posicao.Split(' ')[1]);
                        orientacao2 = char.Parse(posicao.ToUpper().Split(' ')[2]);
                        if (x > maxX || y > maxY || x < 0 || y < 0)
                                throw new InvalidOperationException();
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("sequencia contem valore(s) invalido(s)");
                        Console.ReadKey();
                        Console.ResetColor();
                        goto volta2;
                    }
                    Console.Clear();
                }
                Console.Write("instruções: \n Letra E gira 90 graus para a esquerda\n Letra D gira 90" +
                   " graus para a direita \n Letra M movimenta para frente \n");

                Console.WriteLine("digite os commandos");


                string stringCommandos = Console.ReadLine();
                foreach (char commando in stringCommandos.Trim()) //EMME
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
                }
                foreach (char commando in stringCommandos.Trim())
                {
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
                                        if (x < maxX)
                                        {
                                            x = x + 1;
                                        }
                                        break;
                                    case 'N':
                                        if (y < maxY)
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
                if (segundorobo == false)
                {
                    Console.WriteLine(+x + " " + y + " " + orientacao);
                    Console.ReadKey();
                    segundorobo = true;
                    continue;
                }
                else
                {
                    Console.WriteLine(+x + " " + y + " " + orientacao);
                    Console.WriteLine(x2 + " " + y2 + " " + orientacao2);
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}