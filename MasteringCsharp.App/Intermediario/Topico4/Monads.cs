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

    //internal static class Globalization
    //{
    //    [ThreadStatic]
    //    private static CultureInfo _cultureInfo;

    //    internal static CultureInfo CultureInfo
    //    {
    //        get
    //        {
    //            if (_cultureInfo == null)
    //                _cultureInfo = GetCulture();
    //            return _cultureInfo;
    //        }
    //    }

    //    private static CultureInfo GetCulture()
    //    {
    //        IHttpContextAccessor httpContext = Configuration.Provider.GetService<IHttpContextAccessor>();
    //        httpContext.HttpContext.Items.TryGetValue(Constants.ContextItems.CurrentCustomer, out object cookie);

    //        VCurrentCustomer currentCustomer = cookie as VCurrentCustomer;
    //        int lcid = (currentCustomer?.LanguageCodeId).GetValueOrDefault();
    //        // TODO: LTA - Erro quando lcid = 0

    //        return CultureInfo.GetCultureInfo(lcid);
    //    }
    //}

    ///// <summary>
    ///// Monad para conversão implicita de valores decimais para valores de moeda de acordo com a Localização
    ///// </summary>
    //public struct LocalizableCurrency<T> where T : struct, IConvertible
    //{
    //    public T RawValue { get; private set; }
    //    public string CurrencySymbol { get; private set; }

    //    private string _formattedValue;
    //    public string FormattedValue
    //    {
    //        get
    //        {
    //            if (String.IsNullOrWhiteSpace(_formattedValue))
    //                this._formattedValue = (string)this;

    //            return this._formattedValue;
    //        }
    //        private set { this._formattedValue = value; }
    //    }

    //    public LocalizableCurrency(T value)
    //    {
    //        this.RawValue = value;

    //        CultureInfo culture = Globalization.CultureInfo;// GetCulture();

    //        this._formattedValue = value.ToDecimal(culture).ToString("N", culture);
    //        this.CurrencySymbol = culture.NumberFormat.CurrencySymbol;
    //    }

    //    public static implicit operator LocalizableCurrency<T>(T value)
    //    {
    //        return new LocalizableCurrency<T>(value);
    //    }

    //    public static implicit operator string(LocalizableCurrency<T> value)
    //    {
    //        //string formattedValue;

    //        //CultureInfo culture = GetCulture();

    //        //// TODO: LTA - Verificar porque não dá erro!
    //        //formattedValue = value.rawValue.ToDecimal(culture).ToString("N", culture);
    //        //formattedValue = value.rawValue.ToDouble(culture).ToString("N", culture);
    //        //formattedValue = value.rawValue.ToInt32(culture).ToString("N", culture);
    //        //var teste = value.rawValue.ToBoolean(culture);

    //        return value.FormattedValue;
    //    }
    //}
}
