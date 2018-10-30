using MasteringCsharp.App.Basico;
using MasteringCsharp.App.Intermediario.Topico4;
using Newtonsoft.Json;
using System;
using System.Globalization;

namespace MasteringCsharp.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = CultureInfo.GetCultureInfo(1046).Name;
            Console.WriteLine(a);
            Console.ReadKey();

            //System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            //System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("pt-BR");

            //DateTime data;
            //Console.WriteLine(DateTime.TryParse("22/01/2018", out data));

            //Console.ReadKey();

            //Console.WriteLine(CultureInfo.GetCultureInfo(1046).NumberFormat.CurrencySymbol);
            //double mo1 = 12331.80;
            //Console.WriteLine(mo1.ToString("n3"));

            //System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(13322);

            //Console.WriteLine(mo2.ToString("n3"));
            //Console.WriteLine(mo2.ToString("N3"));
            //Console.WriteLine(CultureInfo.GetCultureInfo(13322).NumberFormat.CurrencySymbol);
            //Console.WriteLine(CultureInfo.GetCultureInfo(13322).NumberFormat.CurrencyDecimalSeparator);

            //System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(13322);
            //double mo2 = 12331.80;
            //Console.WriteLine(mo2.ToString("n3"));

            //var str = "[ 1, 2, 3 ]";
            //var arr = str.Split(",");

            //var objeto = JsonConvert.DeserializeObject<string[]>(str);

            //Console.WriteLine(CultureInfo.GetCultureInfo(1046).NativeName);
            //Console.WriteLine(CultureInfo.GetCultureInfo(1046).TextInfo.ToTitleCase(CultureInfo.GetCultureInfo(13322).NativeName));


            //TiposDados.ImprimirTipos();
            //TiposDeDados.ImprimirHerancas();

            //Console.ReadKey();

            //TesteOperador();
            // NullableTeste<int> y = null;
            //Console.WriteLine(y.HasValue);

            //MeuNullable<int> x = new MeuNullable<int>();
            //x.Adiciona(10);
            //x.Adiciona(10);
            //x += 10;
            //int b = x;
            //Console.WriteLine(b);
            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(x);

            //x = 10;


            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(x);

            //Console.WriteLine("----------------------");
            //Console.ReadKey();
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

    public static class Ext
    {
        public static int FormataX(this string valor)
        {
            return 10;
        }
    }
}
