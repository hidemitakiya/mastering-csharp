using System;
using System.Collections.Generic;
using System.Linq;

namespace MasteringCsharp.App.Intermediario.Topico2
{
    /// <summary>
    /// Intermediario - 2.2. Utilização de Delegates e Eventos
    /// Referências:
    ///     https://weblogs.asp.net/dixin/functional-csharp-function-composition-and-method-chaining
    ///     https://medium.com/@naveenrtr/introduction-to-functional-programming-with-c-b167f15221e1
    /// </summary>
    public static class Delegates
    {
        public static Func<T, TResult2> Then<T, TResult1, TResult2>
       (
           this Func<T, TResult1> function1, Func<TResult1, TResult2> function2
       )
        {
            return value => function2(function1(value));
        }

        internal static Func<IEnumerable<TSource>, IEnumerable<TSource>> Where<TSource>(
Func<TSource, bool> predicate) => source => Enumerable.Where(source, predicate);

        // int -> IEnumerable<TSource> -> IEnumerable<TSource>
        internal static Func<IEnumerable<TSource>, IEnumerable<TSource>> Skip<TSource>(
        int count) => source => Enumerable.Skip(source, count);

        // int -> IEnumerable<TSource> -> IEnumerable<TSource>
        internal static Func<IEnumerable<TSource>, IEnumerable<TSource>> Take<TSource>(
        int count) => source => Enumerable.Take(source, count);

        public static void Bla()
        {
            Func<string, int> parse = (x) => Convert.ToInt32(x);
            Func<int, int> soma = (x) => x + 2;
            Func<int, int> mult = (x) => x * 2;

            var combinada = parse.Then(soma).Then(mult);

            combinada("10");
        }
    }
}
