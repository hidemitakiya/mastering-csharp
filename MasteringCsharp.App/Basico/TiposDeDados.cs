using System;
using System.Collections.Generic;
using System.Text;

namespace MasteringCsharp.App.Basico
{
    /// <summary>
    /// Basico - 1.2. Tipos de dados e aliases (Int32, int, String, string, Enum, etc)
    /// </summary>
    public static class TiposDeDados
    {
        /// <summary>
        /// Todos os aliases do C# com seus tipos do .NET
        /// </summary>
        public static void ImprimirTipos()
        {
            Console.WriteLine(String.Format("bool => {0}", typeof(bool)));
            Console.WriteLine(String.Format("byte => {0}", typeof(byte)));
            Console.WriteLine(String.Format("sbyte => {0}", typeof(sbyte)));
            Console.WriteLine(String.Format("char => {0}", typeof(char)));
            Console.WriteLine(String.Format("decimal => {0}", typeof(decimal)));
            Console.WriteLine(String.Format("double => {0}", typeof(double)));
            Console.WriteLine(String.Format("float => {0}", typeof(float)));
            Console.WriteLine(String.Format("int => {0}", typeof(int)));
            Console.WriteLine(String.Format("uint => {0}", typeof(uint)));
            Console.WriteLine(String.Format("long => {0}", typeof(long)));
            Console.WriteLine(String.Format("ulong => {0}", typeof(ulong)));
            Console.WriteLine(String.Format("object => {0}", typeof(object)));
            Console.WriteLine(String.Format("short => {0}", typeof(short)));
            Console.WriteLine(String.Format("ushort => {0}", typeof(ushort)));
            Console.WriteLine(String.Format("string => {0}", typeof(string)));
        }

        /// <summary>
        /// Exemplos para comprovar a herança dos tipos.
        /// 
        /// Todos os tipos de dados herdam de object
        ///     Os tipos por valor herdam de ValueType, que herdam de Object
        ///     Os tipos por referência herdam de Object diretamente
        /// </summary>
        public static void ImprimirHerancas()
        {
            Console.WriteLine(String.Format("bool => {0}", typeof(bool).BaseType.Name));
            Console.WriteLine(String.Format("ValueType => {0}", typeof(ValueType).BaseType.Name));
            Console.WriteLine(String.Format("string => {0}", typeof(string).BaseType.Name));
        }
    }
}
