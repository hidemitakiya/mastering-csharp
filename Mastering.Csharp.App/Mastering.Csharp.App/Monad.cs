using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Mastering.Csharp.App
{
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
        private bool hasValue;
        internal T value;

        public NullableTeste(T value)
        {
            this.value = value;
            this.hasValue = true;
        }

        public bool HasValue
        {
            get
            {
                return hasValue;
            }
        }

        public T Value
        {
            get
            {
                if (!hasValue)
                {
                    new Exception("erro");
                }
                return value;
            }
        }

        public T GetValueOrDefault()
        {
            return value;
        }

        public T GetValueOrDefault(T defaultValue)
        {
            return hasValue ? value : defaultValue;
        }

        public override bool Equals(object other)
        {
            if (!hasValue) return other == null;
            if (other == null) return false;
            return value.Equals(other);
        }

        public override int GetHashCode()
        {
            return hasValue ? value.GetHashCode() : 0;
        }

        public override string ToString()
        {
            return hasValue ? value.ToString() : "";
        }

        public static implicit operator NullableTeste<T>(T value)
        {
            return new NullableTeste<T>(value);
        }

        
        public static explicit operator T(NullableTeste<T> value)
        {
            return value.Value;
        }

        // The following already obsoleted methods were removed:
        //   public int CompareTo(object other)
        //   public int CompareTo(NullableTeste<T> other)
        //   public bool Equals(NullableTeste<T> other)
        //   public static NullableTeste<T> FromObject(object value)
        //   public object ToObject()
        //   public string ToString(string format)
        //   public string ToString(IFormatProvider provider)
        //   public string ToString(string format, IFormatProvider provider)

        // The following newly obsoleted methods were removed:
        //   string IFormattable.ToString(string format, IFormatProvider provider)
        //   int IComparable.CompareTo(object other)
        //   int IComparable<NullableTeste<T>>.CompareTo(NullableTeste<T> other)
        //   bool IEquatable<NullableTeste<T>>.Equals(NullableTeste<T> other)
    }

   
}
