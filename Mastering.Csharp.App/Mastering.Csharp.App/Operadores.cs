using System;
using System.Collections.Generic;
using System.Text;

namespace Mastering.Csharp.App
{
    public class Produto
    {
        public int Codigo { get; set; }

        public int Preco { get; set; }

    }

    public class ProdutoRelatorio
    {
        public int Preco { get; set; }

        public static implicit operator ProdutoRelatorio(Produto item)
        {
            return new ProdutoRelatorio() { Preco = item.Preco };
        }

        public static ProdutoRelatorio operator +(ProdutoRelatorio item1, ProdutoRelatorio item2)
        {
            return new ProdutoRelatorio() { Preco = item1.Preco + item2.Preco };
        }
    }
}
