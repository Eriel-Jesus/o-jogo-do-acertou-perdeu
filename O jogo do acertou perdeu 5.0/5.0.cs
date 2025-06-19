using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_jogo_do_acertou_perdeu_5._0
{
    internal class cincopontozero
    {
        static void Main(string[] args)
        {

            int menor = 1;
            int maior = 100;
            int palpite, oculto;
            bool verifica;
            int numjogador;
            string[] nomesjogador;

            do
            {
                Console.Write("Insira a quantidade de jogadores da partida (min 2, max 5): ");
                verifica = int.TryParse(Console.ReadLine(), out numjogador);
            }
            while (verifica == false || numjogador < 2 || numjogador > 5);

            nomesjogador = new string[numjogador + 1];

            for (int i = 1; i < (numjogador + 1); i++)
            {
                Console.Write("Insira o nome do {0}° jogador: ", i);
                nomesjogador[i] = Console.ReadLine();
            }

            Random aleatorio = new Random();
            oculto = aleatorio.Next(1, 101);

            for (int jogadoratual = 1; jogadoratual <= numjogador; jogadoratual++)
            {
                do
                {
                    Console.Write("{0}, insira o seu palpite (entre {1} e {2}): ", nomesjogador[jogadoratual], menor, maior);
                    verifica = int.TryParse(Console.ReadLine(), out palpite);
                }
                while ((palpite <= menor || palpite >= maior) || verifica == false);

                if (palpite == oculto)
                {
                    Console.WriteLine("Parabéns {0}, você perdeu!!!", nomesjogador[jogadoratual]);
                    jogadoratual = numjogador + 1;
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

                    if (jogadoratual == numjogador)
                    {
                        jogadoratual = 0;
                    }

                }

            }
        }
    }
}
