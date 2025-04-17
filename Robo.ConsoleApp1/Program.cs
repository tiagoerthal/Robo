using System.Security.Cryptography.X509Certificates;

namespace Robo.ConsoleApp1
{
    internal class Program
    {
        public static string instrucao = "MMDDEEMM".ToUpper();
        static void Main(string[] args)
        {
            bool movimentoValido = true;

            for (int i = 0; i < instrucao.Length; i++)
            {
                char comando = instrucao[i];

                if (comando == 'D') Movimento.VirarDireita();
                else if (comando == 'E') Movimento.VirarEsquerda();
                else if (comando == 'M')
                {
                    int qtdMovimentos = 0;

                    while (i < instrucao.Length && instrucao[i] == 'M')
                    {
                        qtdMovimentos++;
                        i++;
                    }
                    i--;

                    var resultadoMovimento = Movimento.MoverRobo(qtdMovimentos);
                    if (resultadoMovimento == null)
                    {
                        movimentoValido = false;
                        break;
                    }
                }
                else Console.WriteLine($"Comando inválido: Use [D], para direita, [M], para mover, ou [E] para esquerda");
            }
            Movimento.ExibirLocalizacao(movimentoValido);
            Console.ReadLine();

        }
    }
}
