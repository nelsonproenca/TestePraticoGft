using Gtf.TestePratico.Dll.Interfaces;
using System;


namespace Gtf.TestePratico.Dll
{
    public class PedidoManha : IPedido
    {
        public string[] Pedido { get; set; }

        //Regra: 4
        const string REFEICOES_MANHA = "Ovos;Torrada;Café";

        public void Montar(string lista, string periodo)
        {
            string[] pratos = lista.Split(',');

            //Regra: 3
            //Ordena o array
            Array.Sort(pratos);

            string[] pedido = Utils.Utils.OrdenarPedido(pratos, REFEICOES_MANHA, periodo);

            this.Pedido = pedido;
        }

        public override string ToString()
        {
            string retorno = "";

            foreach (var item in this.Pedido)
            {
                if (item == null) break;

                retorno = String.Concat(retorno, $",{item}");
            }

            return retorno;
        }
    }
}
