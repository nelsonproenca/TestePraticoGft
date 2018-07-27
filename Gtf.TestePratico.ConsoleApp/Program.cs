using Gtf.TestePratico.Dll;
using System;

namespace Gtf.TestePratico.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MontarCardapio();

            //Regras: 1 
            Console.WriteLine("Entre com o período: (1-manhã | 2-noite) ");
            string periodo = Console.ReadLine().ToLower();

            Console.WriteLine("Entre com o pedido:");
            string pedido = Console.ReadLine().ToLower();

            //Regras: 2 
            if (pedido.Contains(",") && !pedido.StartsWith("") && !pedido.StartsWith(",") && pedido.Length > 2 && !pedido.EndsWith(","))
            {
                Console.WriteLine("Erro na entrada do pedido. Pedido inválido. Ex: 1,2,3");
                return;
            }

            if (periodo.Equals("1"))
            {                
                PedidoManha pedidoManha = new PedidoManha();

                pedidoManha.Montar(pedido, periodo);

                Console.WriteLine($"Seu pedido foi: {pedidoManha.ToString()}");
            }
            else
            {
                PedidoNoite pedidoNoite = new PedidoNoite();

                pedidoNoite.Montar(pedido, periodo);

                Console.WriteLine($"Seu pedido foi: {pedidoNoite.ToString()}");
            }

            Console.Read();
        }

        private static void MontarCardapio()
        {
            Console.WriteLine("=================================================================");
            Console.WriteLine("Tipo do Prato \t\t\t Manhã \t\t\t Noite");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("1(Entrada) \t\t\t Ovos \t\t\t Carne");
            Console.WriteLine("2(Acompanhamento) \t\t Torrada \t\t Batata");
            Console.WriteLine("3(Bebida) \t\t\t Café \t\t\t Vinho");
            Console.WriteLine("4(Sobremesa) \t\t\t N/A \t\t\t Bolo");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("=================================================================");
        }
    }
}
