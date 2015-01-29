using System;

namespace ConverterHelper
{
    public static class ExtensionsMethods
    {
        #region ConvertToOrDefault

        /// <summary>
        /// Try convert to type specified in <typeparamref name="T"/>.
        /// If <typeparamref name="T"/> is <see cref="System.IConvertible"/>, the <see cref="System.Convert.ChangeType(System.Object, System.Type)">Convert.ChangeType(System.Object, System.Type)</see> method is used, else
        /// if <typeparamref name="T"/> is <see cref="System.Enum"/>, <see cref="Enum.Parse(System.Type, System.String)">Enum.Parse(System.Type, System.String)</see> method is used, 
        /// else a simple cast is performed.
        /// Case a error happen, the <c>default(<typeparamref name="T"/>)</c> is returned.
        /// <para>
        /// <see cref="System.Nullable"/> types are supported.
        /// </para>
        /// </summary>
        /// <typeparam name="T">Type to convert and return.</typeparam>
        /// <param name="predicate">Obejct to convert.</param>
        /// <returns><paramref name="predicate"/> converted to type defined by <typeparamref name="T"/> or a value specified in <paramref name="defualtValue"/>.</returns>
        /// <example>
        /// <code>
        /// class TestClass 
        /// {
        ///     public bool GetValueFromSession()
        ///     {
        ///         // Try convert the variable 'MyVar' in the session to a bool value. 
        ///         // Case a error occur return true
        ///         return System.Web.HttpContext.Current.Session["MyVar"].ConvertToOrDefault&lt;bool&gt;(true);
        ///     }
        /// }
        /// </code>
        /// </example>
        public static T ConvertToOrDefault<T>(this object predicate)
        {
            return ExtensionsMethods.ConvertToOrDefault<T>(predicate, default(T));
        }

        /// <summary>
        /// Try convert to type specified in <typeparamref name="T"/>.
        /// If <typeparamref name="T"/> is <see cref="System.IConvertible"/>, the <see cref="System.Convert.ChangeType(System.Object, System.Type)">Convert.ChangeType(System.Object, System.Type)</see> method is used, else
        /// if <typeparamref name="T"/> is <see cref="System.Enum"/>, <see cref="Enum.Parse(System.Type, System.String)">Enum.Parse(System.Type, System.String)</see> method is used, 
        /// else a simple cast is performed.
        /// Case a error happen, the <c>default(<typeparamref name="T"/>)</c> is returned.
        /// <para>
        /// <see cref="System.Nullable"/> types are supported.
        /// </para>
        /// </summary>
        /// <typeparam name="T">Type to convert and return.</typeparam>
        /// <param name="predicate">Obejct to convert.</param>
        /// <see cref="System.IFormatProvider"/> that control the formatting.
        /// <para>
        /// This parameter is used only for conversions where target type is a type that inherit from <see cref="System.IConvertible"/>.
        /// </para>
        /// </param>
        /// <returns><paramref name="predicate"/> converted to type defined by <typeparamref name="T"/> or a value specified in <paramref name="defualtValue"/>.</returns>
        /// <example>
        /// <code>
        /// class TestClass 
        /// {
        ///     public bool GetValueFromSession()
        ///     {
        ///         // Try convert the variable 'MyVar' in the session to a bool value. 
        ///         // Case a error occur return true
        ///         return System.Web.HttpContext.Current.Session["MyVar"].ConvertToOrDefault&lt;bool&gt;(true);
        ///     }
        /// }
        /// </code>
        /// </example>
        public static T ConvertToOrDefault<T>(this object predicate, IFormatProvider formatProvider)
        {
            return ExtensionsMethods.ConvertToOrDefault<T>(predicate, default(T), formatProvider);
        }

        /// <summary>
        /// Try convert to type specified in <typeparamref name="T"/>.
        /// If <typeparamref name="T"/> is <see cref="System.IConvertible"/>, the <see cref="System.Convert.ChangeType(System.Object, System.Type)">Convert.ChangeType(System.Object, System.Type)</see> method is used, else
        /// if <typeparamref name="T"/> is <see cref="System.Enum"/>, <see cref="Enum.Parse(System.Type, System.String)">Enum.Parse(System.Type, System.String)</see> method is used, 
        /// else a simple cast is performed.
        /// Case a error happen, the <paramref name="defualtValue"/> is returned.
        /// <para>
        /// <see cref="System.Nullable"/> types are supported.
        /// </para>
        /// </summary>
        /// <typeparam name="T">Type to convert and return.</typeparam>
        /// <param name="predicate">Obejct to convert.</param>
        /// <param name="defaultValue">Value to return case a error happen.</param>
        /// <returns><paramref name="predicate"/> converted to type defined by <typeparamref name="T"/> or a value specified in <paramref name="defualtValue"/>.</returns>
        /// <example>
        /// <code>
        /// class TestClass 
        ///{
        ///     public bool GetValueFromSession()
        ///     {
        ///         // Try convert the variable 'MyVar' in the session to a bool value. 
        ///         // Case a error occur return true
        ///         return System.Web.HttpContext.Current.Session["MyVar"].ConvertToOrDefault&lt;bool&gt;(true);
        ///     }
        ///}
        /// </code>
        /// </example>
        public static T ConvertToOrDefault<T>(this object predicate, T defaultValue)
        {
            return ExtensionsMethods.ConvertToOrDefault<T>(predicate, defaultValue, null);
        }

        /// <summary>
        /// Try convert to type specified in <typeparamref name="T"/>.
        /// If <typeparamref name="T"/> is <see cref="System.IConvertible"/>, the <see cref="System.Convert.ChangeType(System.Object, System.Type)">Convert.ChangeType(System.Object, System.Type)</see> method is used, else
        /// if <typeparamref name="T"/> is <see cref="System.Enum"/>, <see cref="Enum.Parse(System.Type, System.String)">Enum.Parse(System.Type, System.String)</see> method is used, 
        /// else a simple cast is performed.
        /// Case a error happen, the <paramref name="defualtValue"/> is returned.
        /// <para>
        /// <see cref="System.Nullable"/> types are supported.
        /// </para>
        /// </summary>
        /// <typeparam name="T">Type to convert and return.</typeparam>
        /// <param name="predicate">Obejct to convert.</param>
        /// <param name="defaultValue">Value to return case a error happen.</param>
        /// <param name="formatProvider">
        /// <see cref="System.IFormatProvider"/> that control the formatting.
        /// <para>
        /// This parameter is used only for conversions where target type is a type that inherit from <see cref="System.IConvertible"/>.
        /// </para>
        /// </param>
        /// <returns><paramref name="predicate"/> converted to type defined by <typeparamref name="T"/> or a value specified in <paramref name="defualtValue"/>.</returns>
        /// <example>
        /// <code>
        /// class TestClass 
        ///{
        ///     public bool GetValueFromSession()
        ///     {
        ///         // Try convert the variable 'MyVar' in the session to a bool value. 
        ///         // Case a error occur return true
        ///         return System.Web.HttpContext.Current.Session["MyVar"].ConvertToOrDefault&lt;bool&gt;(true);
        ///     }
        ///}
        /// </code>
        /// </example>
        public static T ConvertToOrDefault<T>(this object predicate, T defaultValue, IFormatProvider formatProvider)
        {
            if (predicate == null || predicate == DBNull.Value)
            {
                return defaultValue;
            }
            else
            {
                try
                {
                    Type type = typeof(T);
                    if (type.IsNullable())
                    {
                        type = type.GetGenericArguments()[0];
                    }

                    if (type.IsEnum)
                    {
                        // Caso o array possua o atributo Flags, então a soma binária de dois ou mais
                        // elementos desse enum pode gerar um valor que o método Enum.IsDefined não identificaria.
                        object[] flagsAttributes = type.GetCustomAttributes(typeof(FlagsAttribute), false);
                        if (flagsAttributes.Length > 0)
                        {
                            return (T)Enum.Parse(type, predicate.ToString());
                        }
                        else
                        {
                            // Caso o enum não possua o atributo Flags, então verifica se o valor está definido.
                            if (Enum.IsDefined(type, predicate))
                            {
                                return (T)Enum.Parse(type, predicate.ToString());
                            }
                            else
                            {
                                return defaultValue;
                            }
                        }
                    }
                    else if (type.IsConvertible())
                    {
                        return (T)Convert.ChangeType(predicate, type, formatProvider);
                    }
                    else
                    {
                        return (T)predicate;
                    }
                }
                catch
                {
                    return defaultValue;
                }
            }
        }

        #endregion

        #region IsNullable

        /// <summary>
        /// Verifica se um <see cref="System.Type"/> é um System.Nullable
        /// </summary>
        /// <returns>True se o objeto for System.Nullable.</returns>
        /// <remarks>
        /// Andrew B. Signori   25/03/2008
        /// </remarks>
        public static bool IsNullable(this Type type)
        {
            return (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>));
        }

        #endregion

        #region IsConvertible

        /// <summary>
        /// Indica se um <see cref="System.Type"/> implementa a interface <see cref="System.IConvertible"/>.
        /// </summary>
        /// <param name="type">Tipo a ser verificado.</param>
        /// <returns>True se implementa.</returns>
        public static bool IsConvertible(this Type type)
        {
            return type.GetInterface("IConvertible") != null;
        }
        #endregion
    }
}
