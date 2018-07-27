using System;
using System.Collections.Generic;
using System.Text;

namespace Gtf.TestePratico.Dll.Utils
{
    public static class Utils
    {
        public static string[] OrdenarPedido(string[] pedido, string refeicoes, string periodo)
        {
            string[] pratos = new string[4];

            string prato = "", duplicado = "";
            int pratoDuplicado = 0, j = 0, refeicaoDuplicada = 0;

            var nomesPratos = refeicoes.Split(';');

            prato = pedido[0];

            for (int i = 0; i < pedido.Length; i++)
            {
                if (prato != pedido[i])
                {
                    //se for manha = 1 café = 3 ou noite <> 1 batata = 2
                    refeicaoDuplicada = (periodo == "1" ? 3 : 2);

                    if ((Convert.ToInt32(prato) != refeicaoDuplicada && pratoDuplicado > 1) || Convert.ToInt32(prato) > refeicaoDuplicada)
                    {
                        //Regra: 6
                        pratos[j++] = "erro";
                        prato = pedido[i];
                        pratoDuplicado = 0;
                    }
                    else
                    {
                        //Regra: 7 e 8
                        duplicado = pratoDuplicado > 1 ? $" (x{pratoDuplicado})" : "";
                        pratos[j++] = $"{nomesPratos.GetValue(Convert.ToInt32(prato) - 1).ToString()}{duplicado}";
                        prato = pedido[i];
                        pratoDuplicado = 1;
                    }
                }
                else
                {
                    //Regra: 7 e 8
                    pratoDuplicado++;
                }
            }

            duplicado = pratoDuplicado > 1 ? $" (x{pratoDuplicado})" : "";
            if (Convert.ToInt32(prato) > 3)
            {
                pratos[j] = "erro";
            }
            else
            {
                pratos[j] = $"{nomesPratos.GetValue(Convert.ToInt32(prato) - 1).ToString()}{duplicado}";
            }

            return pratos;
        }
    }
}
