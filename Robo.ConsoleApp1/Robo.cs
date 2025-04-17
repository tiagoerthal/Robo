
namespace Robo.ConsoleApp1
{
   public class Robo
    {
        public int posicaoX = 0;
        public int posicaoY = 0;
        public char direcaoAtual = 'L';

        public void ExecutarInstrucoes(string instrucao)
        {
            for (int i = 0; i < instrucao.Length; i++)
            {
                char comando = instrucao[i];

                if (comando == 'D') VirarDireita();
                else if (comando == 'E') VirarEsquerda();
                else if (comando == 'M')
                {
                    int qtdMovimentos = 0;
                    int j = i;
                    while (j < instrucao.Length && instrucao[j] == 'M')
                    {
                        qtdMovimentos++;
                        j++;
                    }
                    i = j - 1;

                    bool valido = Mover(qtdMovimentos);
                    if (!valido)
                    {
                        ExibirLocalizacao(false);
                        return;
                    }
                }
                else Console.WriteLine("Comando inválido.");
            }
            ExibirLocalizacao(true);
        }
        public char VirarDireita()
        {
            if (direcaoAtual == 'N') direcaoAtual = 'L';
            else if (direcaoAtual == 'L') direcaoAtual = 'S';
            else if (direcaoAtual == 'S') direcaoAtual = 'O';
            else if (direcaoAtual == 'O') direcaoAtual = 'N';
            return direcaoAtual;
        }
        public char VirarEsquerda()
        {
            if (direcaoAtual == 'N') direcaoAtual = 'O';
            else if (direcaoAtual == 'O') direcaoAtual = 'S';
            else if (direcaoAtual == 'S') direcaoAtual = 'L';
            else if (direcaoAtual == 'L') direcaoAtual = 'N';
            return direcaoAtual;
        }
        public bool Mover(int qtdMovimentos)
        {
            if (direcaoAtual == 'N' && posicaoY + qtdMovimentos <= 10) posicaoY += qtdMovimentos;
            else if (direcaoAtual == 'S' && posicaoY - qtdMovimentos >= 0) posicaoY -= qtdMovimentos;
            else if (direcaoAtual == 'L' && posicaoX + qtdMovimentos <= 10) posicaoX += qtdMovimentos;
            else if (direcaoAtual == 'O' && posicaoX - qtdMovimentos >= 0) posicaoX -= qtdMovimentos;
            else return false;
            return true;
        }

        public void ExibirLocalizacao(bool movimentoValido)
        {
            if (movimentoValido)
            {
                string localizacao = $"{posicaoX},{posicaoY}";
                Console.WriteLine($"\nLocalização do robô:{localizacao},{direcaoAtual}");
                return;
            }
            else
            {
                ExibirMensagemErro();
                return;
            }
        }

        public void ExibirMensagemErro()
        { Console.WriteLine("\nMovimento inválido - O robô passou dos limites do grid."); }
    }
}
