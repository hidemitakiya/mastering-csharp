using System;
using System.Collections.Generic;
using System.Text;

namespace MasteringCsharp.App.Intermediario.Topico4
{
    /// <summary>
    /// Intermediario - 2.4. Implementação de novos Operadores (Operators, Monads)
    /// </summary>
    public class Operadores
    {
    }

    #region [ Classes para exemplificar ]
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
    #endregion [ Classes para exemplificar ]
}
