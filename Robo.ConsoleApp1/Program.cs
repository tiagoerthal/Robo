namespace Robo.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posicaoX = 0;
            int posicaoY = 0;

            string localizacaoRobo = $"{posicaoX},{posicaoY}";
            char direcaoRobo = 'L'; //Direção começa
            string instrucao = "eee".ToUpper();

            while (true)
            {
                for (int i = 0; i < instrucao.Length; i++)
                {
                    char comando = instrucao[i];

                    if (comando == 'D')
                    {
                        direcaoRobo = VirarDireita(direcaoRobo);
                    }
                    else if (comando == 'E')
                    {
                        direcaoRobo = VirarEsquerda(direcaoRobo);
                    }
                    else
                    {
                        Console.WriteLine($"Comando inválido: Utilize [D], para direita, [M], para mover, ou [E] para esquerda!");
                        //Console.ReadLine();
                        break;
                    }
                }
                Console.WriteLine($"\nLocalização do robô:{localizacaoRobo},{direcaoRobo}");
                Console.WriteLine("-----------------------------------------------------");
                Console.Write("Faça um movimento: ");
                Console.ReadLine();

                Console.Clear();
            }

            static char VirarDireita(char direcaoAtual)
            {
                if (direcaoAtual == 'N') return 'L';
                else if (direcaoAtual == 'L') return 'S';
                else if (direcaoAtual == 'S') return 'O';
                else if (direcaoAtual == 'O') return 'N';
                return direcaoAtual;
            }
            static char VirarEsquerda(char direcaoAtual)
            {
                if (direcaoAtual == 'N') return 'O';
                else if (direcaoAtual == 'O') return 'S';
                else if (direcaoAtual == 'S') return 'L';
                else if (direcaoAtual == 'L') return 'N';
                return direcaoAtual;
            }
           

        }
    }
}
