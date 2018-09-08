using System;
using System.Collections.Generic;
using System.Text;

namespace MasteringCsharp.App.Intermediario.Topico4
{
    /// <summary>
    /// Intermediario - 2.4. Implementação de novos Operadores (Operators, Monads)
    /// </summary>
    public class Monads
    {
    }

    #region [ Classes Exemplo ]
    public struct MeuNullable<T> where T : struct
    {
        private T internalValue;
        public bool HasValue;

        public MeuNullable(T item)
        {
            this.internalValue = item;
            this.HasValue = true;
        }

        public void Adiciona(T valor)
        {
            internalValue = ((T)(object)((int)(object)valor + (int)(object)this.internalValue));
        }

        public static implicit operator MeuNullable<T>(T valor)
        {
            return new MeuNullable<T>(valor);
        }

        public static implicit operator T(MeuNullable<T> value)
        {
            return value.internalValue;
        }

        public override string ToString()
        {
            return internalValue.ToString();
        }
    }

    [Serializable]
    public struct NullableTeste<T> where T : class
    {
    }
    #endregion [ Classes Exemplo ]
}
