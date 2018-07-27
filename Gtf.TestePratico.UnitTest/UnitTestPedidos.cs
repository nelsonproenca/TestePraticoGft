using Gtf.TestePratico.Dll;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gtf.TestePratico.UnitTest
{
    [TestClass]
    public class UnitTestPedidos
    {
        [TestMethod]
        public void TestMethodPedidoManhaSemErro()
        {
            PedidoManha pedido = new PedidoManha();

            string listaPratos = "1,2,3";
            pedido.Montar(listaPratos);

            Assert.Equals("Ovos,Torrada,Café", pedido.ToString());
        }

        [TestMethod]
        public void TestMethodPedidoManhaComErro()
        {
            PedidoManha pedido = new PedidoManha();

            string listaPratos = "1,2,3,4";
            pedido.Montar(listaPratos);

            Assert.Equals("Ovos,Torrada,Café,erro", pedido.ToString());
        }

        [TestMethod]
        public void TestMethodPedidoManhaComCafe3xFalha()
        {
            PedidoManha pedido = new PedidoManha();

            string listaPratos = "1,2,3,3,3";
            pedido.Montar(listaPratos);

            Assert.Equals("Ovos,Torrada,Café", pedido.ToString());
        }

        [TestMethod]
        public void TestMethodPedidoNoiteSemmErro()
        {
            PedidoManha pedido = new PedidoManha();

            string listaPratos = "1,2,3,4";
            pedido.Montar(listaPratos);

            Assert.Equals("Carne,Batata,Vinho,Bolo", pedido.ToString());
        }

        [TestMethod]
        public void TestMethodPedidoManhaCommErro()
        {
            PedidoManha pedido = new PedidoManha();

            string listaPratos = "1,2,3,4,5";
            pedido.Montar(listaPratos);

            Assert.Equals("Carne,Batata,Vinho,Bolo,erro", pedido.ToString());
        }

        [TestMethod]
        public void TestMethodPedidoManhaComBatata3xFalha()
        {
            PedidoManha pedido = new PedidoManha();

            string listaPratos = "1,2,2,3,4";
            pedido.Montar(listaPratos);

            Assert.Equals("Carne,Batata,Vinho,Bolo", pedido.ToString());
        }
    }
}
