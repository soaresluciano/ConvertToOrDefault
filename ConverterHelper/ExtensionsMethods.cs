using System;

namespace ConverterHelper
{
    public static class ExtensionsMethods
    {
        /// <summary>
        /// Try to convert to the type specified in <typeparamref name="T"/>.
        /// If <typeparamref name="T"/> is <see cref="IConvertible"/>, the <see cref="Convert.ChangeType(Object, Type)">Convert.ChangeType(System.Object, System.Type)</see> method is used, else
        /// if <typeparamref name="T"/> is <see cref="Enum"/>, <see cref="Enum.Parse(Type, String)">Enum.Parse(System.Type, System.String)</see> method is used, 
        /// else a simple cast is performed.
        /// If an error occurs, the <c>default(<typeparamref name="T"/>)</c> is returned.
        /// <para>
        /// <see cref="Nullable"/> types are supported.
        /// </para>
        /// </summary>
        /// <typeparam name="T">Type to be converted and returned.</typeparam>
        /// <param name="predicate">Object to be converted.</param>
        /// <returns>The <paramref name="predicate"/> converted to the type defined by <typeparamref name="T"/>, or the default value of <typeparamref name="T"/>.</returns>
        /// <example>
        /// <code>
        /// class TestClass 
        /// {
        ///     public bool GetValueFromSession()
        ///     {
        ///         // Try to convert the variable 'MyVar' into the session to a bool value. 
        ///         // In case of an error occurs, returns true
        ///         return System.Web.HttpContext.Current.Session["MyVar"].ConvertToOrDefault&lt;bool&gt;(true);
        ///     }
        /// }
        /// </code>
        /// </example>
        public static T ConvertToOrDefault<T>(this object predicate)
        {
            return ConvertToOrDefault(predicate, default(T));
        }

        /// <summary>
        /// Try to convert to the type specified in <typeparamref name="T"/>.
        /// If <typeparamref name="T"/> is <see cref="IConvertible"/>, the <see cref="Convert.ChangeType(Object, Type)">Convert.ChangeType(System.Object, System.Type)</see> method is used, else
        /// if <typeparamref name="T"/> is <see cref="Enum"/>, <see cref="Enum.Parse(Type, String)">Enum.Parse(System.Type, System.String)</see> method is used, 
        /// else a simple cast is performed.
        /// If an error occurs, the <c>default(<typeparamref name="T"/>)</c> is returned.
        /// <para>
        /// <see cref="Nullable"/> types are supported.
        /// </para>
        /// </summary>
        /// <typeparam name="T">Type to be converted and returned.</typeparam>
        /// <param name="predicate">Object to be converted.</param>
        /// <param name="formatProvider">
        /// <see cref="IFormatProvider"/> that control the formatting.
        /// <para>
        /// This parameter is used only for conversions where the target type inherits from <see cref="IConvertible"/>.
        /// </para>
        /// </param>
        /// <returns>The <paramref name="predicate"/> converted to the type defined by <typeparamref name="T"/>, or the default value of <typeparamref name="T"/>.</returns>
        /// <example>
        /// <code>
        /// class TestClass 
        /// {
        ///     public bool GetValueFromSession()
        ///     {
        ///         // Try to convert the variable 'MyVar' into the session to a bool value. 
        ///         // In case of an error occurs, returns true
        ///         return System.Web.HttpContext.Current.Session["MyVar"].ConvertToOrDefault&lt;bool&gt;(true);
        ///     }
        /// }
        /// </code>
        /// </example>
        public static T ConvertToOrDefault<T>(this object predicate, IFormatProvider formatProvider)
        {
            return ConvertToOrDefault(predicate, default(T), formatProvider);
        }

        /// <summary>
        /// Try to convert to the type specified in <typeparamref name="T"/>.
        /// If <typeparamref name="T"/> is <see cref="IConvertible"/>, the <see cref="Convert.ChangeType(Object, Type)">Convert.ChangeType(System.Object, System.Type)</see> method is used, else
        /// if <typeparamref name="T"/> is <see cref="Enum"/>, <see cref="Enum.Parse(Type, String)">Enum.Parse(System.Type, System.String)</see> method is used, 
        /// else a simple cast is performed.
        /// Case a error happen, the <paramref name="defaultValue"/> is returned.
        /// <para>
        /// <see cref="Nullable"/> types are supported.
        /// </para>
        /// </summary>
        /// <typeparam name="T">Type to be converted and returned.</typeparam>
        /// <param name="predicate">Object to be converted.</param>
        /// <param name="defaultValue">Value to be returned in case of an error happen.</param>
        /// <returns>The <paramref name="predicate"/> converted to the type defined by <typeparamref name="T"/>, or the value specified in <paramref name="defaultValue"/>.</returns>
        /// <example>
        /// <code>
        /// class TestClass 
        ///{
        ///     public bool GetValueFromSession()
        ///     {
        ///         // Try to convert the variable 'MyVar' into the session to a bool value. 
        ///         // In case of an error occurs, returns true
        ///         return System.Web.HttpContext.Current.Session["MyVar"].ConvertToOrDefault&lt;bool&gt;(true);
        ///     }
        ///}
        /// </code>
        /// </example>
        public static T ConvertToOrDefault<T>(this object predicate, T defaultValue)
        {
            return ConvertToOrDefault(predicate, defaultValue, null);
        }

        /// <summary>
        /// Try to convert to the type specified in <typeparamref name="T"/>.
        /// If <typeparamref name="T"/> is <see cref="IConvertible"/>, the <see cref="Convert.ChangeType(Object, Type)">Convert.ChangeType(System.Object, System.Type)</see> method is used, else
        /// if <typeparamref name="T"/> is <see cref="Enum"/>, <see cref="Enum.Parse(Type, String)">Enum.Parse(System.Type, System.String)</see> method is used, 
        /// else a simple cast is performed.
        /// Case a error happen, the <paramref name="defaultValue"/> is returned.
        /// <para>
        /// <see cref="Nullable"/> types are supported.
        /// </para>
        /// </summary>
        /// <typeparam name="T">Type to be converted and returned.</typeparam>
        /// <param name="predicate">Object to be converted.</param>
        /// <param name="defaultValue">Value to be returned in case of an error happen.</param>
        /// <param name="formatProvider">
        /// <see cref="IFormatProvider"/> that control the formatting.
        /// <para>
        /// This parameter is only used for conversions where the target type inherits from <see cref="IConvertible"/>.
        /// </para>
        /// </param>
        /// <returns>The <paramref name="predicate"/> converted to the type defined by <typeparamref name="T"/>, or the value specified in <paramref name="defaultValue"/>.</returns>
        /// <example>
        /// <code>
        /// class TestClass 
        ///{
        ///     public bool GetValueFromSession()
        ///     {
        ///         // Try to convert the variable 'MyVar' into the session to a bool value. 
        ///         // In case of an error occurs, returns true
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
                        // if the array has the Flags attribute,the binary sum of two or more
                        // elements of this enum might generate a value which the method Enum.IsDefined is not able to evaluated.
                        object[] flagsAttributes = type.GetCustomAttributes(typeof(FlagsAttribute), false);
                        if (flagsAttributes.Length > 0)
                        {
                            return (T)Enum.Parse(type, predicate.ToString());
                        }
                        else
                        {
                            // If the enum does not have the Flags attribute, the defined value is evaluated.
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

        /// <summary>
        /// Check if the <see cref="Type"/> is System.Nullable.
        /// </summary>
        /// <returns>True if the object is System.Nullable.</returns>
        public static bool IsNullable(this Type type)
        {
            return (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>));
        }

        /// <summary>
        /// Check if <see cref="Type"/> implements the interface <see cref="IConvertible"/>.
        /// </summary>
        /// <param name="type">Type to be checked.</param>
        /// <returns>True if it is an implementation of <see cref="IConvertible"/>.</returns>
        public static bool IsConvertible(this Type type)
        {
            return type.GetInterface(nameof(IConvertible)) != null;
        }
    }
}
