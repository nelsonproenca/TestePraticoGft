using Gtf.TestePratico.Dll.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gtf.TestePratico.Dll
{
    public class PedidoNoite : IPedido
    {
        public string[] Pedido { get; set; }

        const string REFEICOES_NOITE = "Carne;Batata;Vinho;Bolo";

        public void Montar(string lista, string periodo)
        {
            string[] pratos = lista.Split(',');

            //Ordena o array
            Array.Sort(pratos);

            string[] pedido = Utils.Utils.OrdenarPedido(pratos, REFEICOES_NOITE, periodo);

            this.Pedido = pedido;
        }

        public override string ToString()
        {
            string retorno = "";

            foreach (var item in this.Pedido)
            {
                if (item == null) break;

                retorno = String.Concat(retorno, $",{item}");
                retorno = retorno.EndsWith(",") ? retorno.Substring(0, retorno.Length - 1) : retorno;
            }

            return retorno;
        }
    }
}
