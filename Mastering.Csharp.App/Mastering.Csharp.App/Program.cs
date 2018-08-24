using System;

namespace Mastering.Csharp.App
{
    public static class Ext
    {
        public static int FormataX(this string valor)
        {
            return 10;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //TesteOperador();
            // NullableTeste<int> y = null;
            //Console.WriteLine(y.HasValue);


            MeuNullable<int> x = new MeuNullable<int>();
            x.Adiciona(10);
            x.Adiciona(10);
            x += 10;
            int b = x;
            Console.WriteLine(b);
            Console.WriteLine(x.HasValue);
            Console.WriteLine(x);

            x = 10;
            
            
            Console.WriteLine(x.HasValue);
            Console.WriteLine(x);

            Console.WriteLine("----------------------");
            Console.ReadKey();
        }

        public static void TesteOperador()
        {
            Produto p = new Produto()
            {
                Codigo = 1,
                Preco = 20
            };

            ProdutoRelatorio pRel1 = p;
            Console.WriteLine(pRel1.Preco);

            ProdutoRelatorio pRel2 = new ProdutoRelatorio() { Preco = 30 };
            ProdutoRelatorio pRel3 = pRel1 + pRel2 + p;

            Console.WriteLine(pRel3.Preco);
            
        }
    }
}
