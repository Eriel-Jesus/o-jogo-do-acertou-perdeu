using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Jogo_do_acertou_perdeu
{
    internal class doispontozero
    {
        static void Main(string[] args)
        {
            int menor = 1;
            int maior = 100;
            int palpite, oculto;
            bool verifica;

            
            
                Console.Write("Insira o número oculto (entre 1 e 100): ");
                verifica = int.TryParse(Console.ReadLine(), out oculto);

            while ((oculto <= menor || oculto >= maior) || verifica == false)
            {
                Console.Clear();
                Console.Write("Coloca o número certo, seu energúmeno (entre 1 e 100): ");
                verifica = int.TryParse(Console.ReadLine(), out oculto);
            }

            for (int jogador = 1; jogador <= 2; jogador++)
            {
                do
                {
                    Console.Write("Jogador {0}, insira o seu palpite (entre {1} e {2}): ", jogador, menor, maior);
                    verifica = int.TryParse(Console.ReadLine(), out palpite);
                }
                while ((palpite <= menor || palpite >= maior) || verifica == false);

                if (palpite == oculto)
                {
                    Console.WriteLine("Parabéns, jogador {0}, você perdeu!!!", jogador);
                    jogador = 3;
                }
                else
                {
                    if (palpite > oculto)
                    {
                        maior = palpite;
                    }
                    else
                    {
                        menor = palpite;
                    }

                    if (jogador == 2)
                    {
                        jogador = 0;
                    }
                }


            }


        }
    }
}

