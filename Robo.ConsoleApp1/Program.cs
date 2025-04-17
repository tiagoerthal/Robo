using System.Security.Cryptography.X509Certificates;

namespace Robo.ConsoleApp1
{
    internal class Program
    {    
        static void Main(string[] args)
        {
            {
                Robo robo1 = new Robo();
                Robo robo2 = new Robo();

                string instrucao1 = "MMDEEMDDM";
                string instrucao2 = "MMEEMMDDM";

                Console.WriteLine("Movimentos do Robô 1:");
                robo1.ExecutarInstrucoes(instrucao1.ToUpper());

                Console.WriteLine("\nMovimentos do Robô 2:");
                robo2.ExecutarInstrucoes(instrucao2.ToUpper());
                Console.ReadLine();
            }
        }
    }
}
