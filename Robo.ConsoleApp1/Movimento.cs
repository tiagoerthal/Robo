
namespace Robo.ConsoleApp1
{
   public class Movimento
    {
        public static int posicaoX = 0;
        public static int posicaoY = 0;
        public static char direcaoAtualRobo = 'L';
        public static char VirarDireita()
        {
            if (direcaoAtualRobo == 'N') direcaoAtualRobo = 'L';
            else if (direcaoAtualRobo == 'L') direcaoAtualRobo = 'S';
            else if (direcaoAtualRobo == 'S') direcaoAtualRobo = 'O';
            else if (direcaoAtualRobo == 'O') direcaoAtualRobo = 'N';
            return direcaoAtualRobo;
        }
        public static char VirarEsquerda()
        {
            if (direcaoAtualRobo == 'N') direcaoAtualRobo = 'O';
            else if (direcaoAtualRobo == 'O') direcaoAtualRobo = 'S';
            else if (direcaoAtualRobo == 'S') direcaoAtualRobo = 'L';
            else if (direcaoAtualRobo == 'L') direcaoAtualRobo = 'N';
            return direcaoAtualRobo;
        }
        public static (int, int)? MoverRobo(int qtdMovimentos)
        {
            if (direcaoAtualRobo == 'N' && posicaoY + qtdMovimentos <= 10) posicaoY += qtdMovimentos;
            else if (direcaoAtualRobo == 'S' && posicaoY - qtdMovimentos >= 0) posicaoY -= qtdMovimentos;
            else if (direcaoAtualRobo == 'L' && posicaoX + qtdMovimentos <= 10) posicaoX += qtdMovimentos;
            else if (direcaoAtualRobo == 'O' && posicaoX - qtdMovimentos >= 0) posicaoX -= qtdMovimentos;
            else return null;

            return (posicaoX, posicaoY);
        }

        public static void ExibirLocalizacao(bool movimentoValido)
        {
            if (movimentoValido)
            {
                string localizacaoRobo = $"{Movimento.posicaoX},{Movimento.posicaoY}";
                Console.WriteLine($"\nLocalização do robô:{localizacaoRobo},{Movimento.direcaoAtualRobo}");
                return;
            }
            else
            {
                ExibirMensagemErro();
                return;
            }
        }

        public static void ExibirMensagemErro()
        {
            Console.WriteLine("\nMovimento inválido - O robô passou dos limites do grid.");
        }
    }
}
