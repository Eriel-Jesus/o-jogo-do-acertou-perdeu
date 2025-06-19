using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_jogo_do_acertou_perdeu_4._0
{
    internal class quatropontozero
    {
        static void Main(string[] args)
        {

            int menor = 1;
            int maior = 100;
            int palpite, oculto;
            bool verifica;
            int numjogador;

            do
            {
                Console.Write("Insira a quantidade de jogadores da partida (min 2): ");
                verifica = int.TryParse(Console.ReadLine(), out numjogador);
            }
            while (verifica == false || numjogador < 2);

            Random aleatorio = new Random();
            oculto = aleatorio.Next(1, 101);

            for (int jogador = 1; jogador <= numjogador; jogador++)
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
                    jogador = numjogador + 1;
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

                    if (jogador == numjogador)
                    {
                        jogador = 0;
                    }
                }
            }
                       
        }
    }
}
