﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tupiniquim
{
    public class Funcoes
    {
        public static char esquerda(char orientacao)
        {
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
            return orientacao;
        }
        public static char direita(char orientacao)
        {
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
            return orientacao;
        }
        public static int movimento(char orientacao, int valor)
        {
            switch (orientacao)
            {
                case 'L':
                    if (valor < 5)
                    {
                        valor = valor + 1;
                    }
                    break;
                case 'N':
                    if (valor < 5)
                    {
                        valor = valor + 1;
                    }

                    break;
                case 'S':
                    if (valor > 0)
                    {
                        valor = valor - 1;
                    }
                    break;
                case 'O':
                    if (valor > 0)
                    {
                        valor = valor - 1;
                    }
                    break;
            }
            return valor;
        }
    }
}
