using System;
using System.Collections.Generic;
using System.Text;

namespace Gtf.TestePratico.Dll.Interfaces
{
    public interface IPedido
    {
        void Montar(string lista, string periodo);

        string ToString();
    }
}
