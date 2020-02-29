// ReSharper disable All
namespace System
{
    using ComponentModel;
    using Collections.Generic;
    using Data.SqlTypes;
    using Diagnostics;
    using Linq;
    using Reflection;
    using Runtime.CompilerServices;
    using Text;
    using Text.RegularExpressions;
    using Threading;
    using Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="CommonExtensions" />
    /// </summary>
    public static class CommonExtensions
    {
        /// <summary>
        /// Make Readable string Dirty
        /// </summary>
        /// <param name="humanized"> humanized string<see cref="string" /></param>
        /// <param name="delimiter"> delimiter <see cref="string" /></param>
        /// <returns>
        /// The <see cref="string" />
        /// </returns>
        [Description("Make Readable string Dirty")]
        public static string DeHumanize(this string humanized, string delimiter = "") => humanized.Replace(" ", delimiter);

        /// <summary>
        /// Provides a Distinct method that takes a key selector lambda as parameter.
        /// The .net framework only provides a Distinct method that takes an instance
        /// of an implementation of IEqualityComparer where the standard parameter less
        /// Distinct that uses the default equality comparer doesn't suffice.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <param name="this">IEnumerable.</param>
        /// <param name="keySelector"> key selector.</param>
        /// <returns></returns>
        [Description("Provides a Distinct method that takes a key selector lambda as parameter. The .net framework only provides a Distinct method that takes an instance of an implementation of IEqualityComparer where the standard parameter less Distinct that uses the default equality comparer doesn't suffice.")]
        public static IEnumerable<T> Distinct<T, TKey>(this IEnumerable<T> @this, Func<T, TKey> keySelector) => @this.GroupBy(keySelector).Select(rps => rps).Select(e => e.First());

        
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
/// <summary>
        /// An extension function to work like the extend method of javascript. It takes the object and merge with oder, but only if the property of the other object has value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target">The target</param>
        /// <param name="source">The source</param>
        /// <returns>
        /// The <see cref="T" />
        /// </returns>
        [Description("An extension function to work like the extend method of javascript. It takes the object and merge with oder, but only if the property of the other object has value.")]
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
        public static T Extend<T>(this T target, T source) where T : class
        {
            IEnumerable<PropertyInfo> properties =
                target.GetType().GetProperties().Where(pi => pi.CanRead && pi.CanWrite);

            foreach (PropertyInfo propertyInfo in properties)
            {
                object targetValue = propertyInfo.GetValue(target, null);
                object defaultValue = propertyInfo.PropertyType.GetDefault();

                if (targetValue != null && !targetValue.Equals(defaultValue))
                {
                    continue;
                }

                object sourceValue = propertyInfo.GetValue(source, null);
                propertyInfo.SetValue(target, sourceValue, null);
            }
            return target;
        }

        /// <summary>
        /// The ForAwait
        /// </summary>
        /// <param name="task">The task<see cref="ValueTask"/></param>
        /// <returns>The <see cref="ConfiguredValueTaskAwaitable"/></returns>
        [Description("The ForAwait")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ConfiguredValueTaskAwaitable ForAwait(this in ValueTask task) => task.ConfigureAwait(false);

        /// <summary>
        /// The ForAwait
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="task">The task<see cref="ValueTask{T}"/></param>
        /// <returns>The <see cref="ConfiguredValueTaskAwaitable{T}"/></returns>
        [Description("The ForAwait")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ConfiguredValueTaskAwaitable<T> ForAwait<T>(this in ValueTask<T> task) => task.ConfigureAwait(false);

        /// <summary>
        /// The ForAwait
        /// </summary>
        /// <param name="task">The task<see cref="Task"/></param>
        /// <returns>The <see cref="ConfiguredTaskAwaitable"/></returns>
        [Description("The ForAwait")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ConfiguredTaskAwaitable ForAwait(this Task task) => task.ConfigureAwait(false);

        /// <summary>
        /// The ForAwait
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="task">The task<see cref="Task{T}"/></param>
        /// <returns>The <see cref="ConfiguredTaskAwaitable{T}"/></returns>
        [Description("The ForAwait")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ConfiguredTaskAwaitable<T> ForAwait<T>(this Task<T> task) => task.ConfigureAwait(false);

        /// <summary>
        /// Replaces the format item in a specified System.String with the text equivalent
        ///  of the value of a specified System.Object instance.
        /// </summary>
        /// <param name="value">A composite format string</param>
        /// <param name="arg0">An System.Object to format</param>
        /// <returns>The <see cref="string"/></returns>
        [Description("Replaces the format item in a specified System.String with the text equivalent  of the value of a specified System.Object instance.")]
        public static string Format(this string value, object arg0)
        {
            return string.Format(value, arg0);
        }

        /// <summary>
        /// Replaces the format item in a specified System.String with the text equivalent
        ///  of the value of a specified System.Object instance.
        /// </summary>
        /// <param name="value">A composite format string</param>
        /// <param name="args">An System.Object array containing zero or more objects to format.</param>
        /// <returns>The <see cref="string"/></returns>
        [Description("Replaces the format item in a specified System.String with the text equivalent  of the value of a specified System.Object instance.")]
        public static string Format(this string value, params object[] args)
        {
            return string.Format(value, args);
        }

        /// <summary>
        ///  Get Default Value
        /// </summary>
        /// <param name="type">The type<see cref="Type"/></param>
        /// <returns>The <see cref="object"/></returns>
        [Description("Get Default Value")]
        private static object GetDefault(this Type type)
        {
            // If no Type was supplied, if the Type was a reference type, or if the Type was a System.Void, return null
            if (type == null || !type.IsValueType || type == typeof(void))
            {
                return null;
            }

            // If the supplied Type has generic parameters, its default value cannot be determined
            if (type.ContainsGenericParameters)
            {
                throw new ArgumentException(
                    "{" + MethodBase.GetCurrentMethod() + "} Error:\n\nThe supplied value type <" + type +
                    "> contains generic parameters, so the default value cannot be retrieved");
            }

            // If the Type is a primitive type, or if it is another publicly-visible value type (i.e. struct), return a 
            //  default instance of the value type
            if (type.IsPrimitive || !type.IsNotPublic)
            {
                try
                {
                    return Activator.CreateInstance(type);
                }
                catch (Exception e)
                {
                    throw new ArgumentException(
                        "{" + MethodBase.GetCurrentMethod() +
                        "} Error:\n\nThe Activator.CreateInstance method could not " +
                        "create a default instance of the supplied value type <" + type +
                        "> (Inner Exception message: \"" + e.Message + "\")", e);
                }
            }

            // Fail with exception
            throw new ArgumentException("{" + MethodBase.GetCurrentMethod() + "} Error:\n\nThe supplied value type <" +
                                        type +
                                        "> is not a publicly-visible type, so the default value cannot be retrieved");
        }

        /// <summary>
        /// Human Readable string
        /// </summary>
        /// <param name="value">The value<see cref="string"/></param>
        /// <returns>The <see cref="string"/></returns>
        [Description("Human Readable string")]
        public static string Humanize(this string value) => string.Join(" ", value.SplitCamelCase());

        /// <summary>
        /// allows an action to be taken on an object if it is cast able as the given type, with no return value.
        /// if the target does not match the type, does nothing
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target">The target<see cref="object"/></param>
        /// <param name="method">The method<see cref="Action{T}"/></param>
        [Description("allows an action to be taken on an object if it is castable as the given type, with no return value. if the target does not match the type, does nothing")]
        public static void IfIs<T>(this object target, Action<T> method)
            where T : class
        {
            if (target is T cast)
            {
                method(cast);
            }
        }

        
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
/// <summary>
        /// allows an action to be taken on an object if it is cast-able as the given type, with a return value.
        /// if the target does not match the type, returns default(T)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="target">The target<see cref="object"/></param>
        /// <param name="method">The method<see cref="Func{T, TResult}"/></param>
        /// <returns>The <see cref="TResult"/></returns>
        public static TResult IfIs<T, TResult>(this object target, Func<T, TResult> method)
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
            where T : class
        {
            switch (target)
            {
                case T cast:
                    return method(cast);
                default:
                    return default;
            }
        }

        
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
/// <summary>
        /// Returns a selected value when the source is not null; null otherwise.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TInner"></typeparam>
        /// <param name="source">The source<see cref="T"/></param>
        /// <param name="selector">The selector<see cref="Func{T, TInner}"/></param>
        /// <returns>The selected value when source is not null; null otherwise.</returns>
        public static TInner IfNotNull<T, TInner>(this T source, Func<T, TInner> selector) => source != null ? selector(source) : default;
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved

        /// <summary>
        /// Implements Interfaces
        /// Determines if a class object implements an interface type and returns a list of types it actually implements.
        /// If no matching type is found an empty list will be returned.
        /// </summary>
        /// <param name="obj">The obj<see cref="object"/></param>
        /// <param name="interfaces">The interfaces<see cref="List{Type}"/></param>
        /// <returns>The <see cref="List{Type}"/></returns>
        public static List<Type> ImplementsInterfaces(this object obj, List<Type> interfaces)
        {
            if (obj == null || interfaces == null)
            {
                return new List<Type>();
            }

            bool Filter(Type typeObj, object criteriaObj) => typeObj.ToString() == criteriaObj.ToString();

            Type Func(Type t) { return obj.GetType().FindInterfaces(Filter, t.FullName).Length > 0 ? t : null; }

            return (from i in interfaces select Func(i)).Where(t => t != null).ToList();
        }

        /// <summary>
        /// Checks string object's value to array of string values
        /// </summary>
        /// <param name="value">The value<see cref="string"/></param>
        /// <param name="stringValues">Array of string values to compare</param>
        /// <returns>Return true if any string value matches</returns>
        [Description("Checks string object's value to array of string values")]
        public static bool In(this string value, params string[] stringValues) => stringValues.Where(otherValue => string.CompareOrdinal(value, otherValue) == 0).Select(otherValue => new { }).Any();


#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
        /// <summary>
        /// Allows you to compare a value to a list of values analogous to the 'In' statement in sql.
        /// This makes for a very friendly syntax that is (IMHO) superior to a list of 'or' clauses. 
        /// Instead of : if (s=="John" || s=="Peter" or s=="Paul") one can write if (s.In("John","Paul","Peter"))
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source<see cref="T"/></param>
        /// <param name="list">The list<see>
        ///         <cref>T[]</cref>
        ///     </see>
        /// </param>
        /// <returns>The <see cref="bool"/></returns>
        public static bool In<T>(this T source, params T[] list) => list.ToList().Contains(source);

        /// <summary>
        /// Check string  IsDecimal
        /// </summary>
        /// <param name="input">The input<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public static bool IsDecimal(this string input) => input.IsSet() && decimal.TryParse(input, out _);

        /// <summary>
        /// Check string IsDouble
        /// </summary>
        /// <param name="input">The input<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        [Description("Check string IsDouble")]
        public static bool IsDouble(this string input) => input.IsSet() && double.TryParse(input, out _);

        /// <summary>
        /// Check string IsInt
        /// </summary>
        /// <param name="input">The input<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        [Description("Check string IsInt")]
        public static bool IsInt(this string input) => input.IsSet() && int.TryParse(input, out _);

        /// <summary>
        /// Check if Input string is not null or whitespace
        /// </summary>
        /// <param name="input">The input<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        [Description("Check if Input string is not null or whitespace")]
        public static bool IsNotNull(this string input) => !(string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input));

        
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
/// <summary>
        /// Check  IsNull
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="me">The me<see cref="T"/></param>
        /// <returns>The <see cref="bool"/></returns>
        [Description("Check  IsNull")]
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
        [DebuggerStepThrough]
        public static bool IsNull<T>(this T me)
        {
            Type type = typeof(T);
            return me is INullable nullable && nullable.IsNull || (type.IsValueType
                       ? !ReferenceEqualsEx(Nullable.GetUnderlyingType(type), null) && me.GetHashCode() == 0
                       : ReferenceEqualsEx(me, null) || Convert.IsDBNull(me));
        }

        
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
/// <summary>
        /// Check IsNull
        /// </summary>
        /// <typeparam name="T">Where T is struct</typeparam>
        /// <param name="me">Struct need to check is null<see cref="T"/></param>
        /// <returns>True or False <see cref="bool"/></returns>
        [Description("Check IsNull")]
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
        [DebuggerStepThrough]
        public static bool IsNull<T>(this T? me) where T : struct => !me.HasValue;

        /// <summary>
        /// Check if string is null or empty 
        /// </summary>
        /// <param name="input">The input<see cref="string"/></param>
        /// <returns>True or False <see cref="bool"/></returns>
        [Description("Check if string is null or empty")]
        public static bool IsSet(this string input) => !(string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input));

        /// <summary>
        /// Returns characters from left of specified length
        /// </summary>
        /// <param name="value">String value</param>
        /// <param name="length">Max number of characters to return</param>
        /// <returns>Returns string from left</returns>
        [Description("Returns characters from left of specified length")]
        public static string Left(this string value, int length) => value != null && value.Length > length ? value.Substring(0, length) : value;

        /// <summary>
        /// An C# extension method based on "LIKE" operator of T-SQL.
        /// </summary>
        /// <param name="value">The value<see cref="string"/></param>
        /// <param name="search">The search<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        [Description("An C# extension method based on LIKE operator of T-SQL.")]
        public static bool Like(this string value, string search) => value.Contains(search) || value.StartsWith(search) || value.EndsWith(search);

        /// <summary>
        /// This extension method represents shorthand version of ReferenceEqualsEx method.
        /// </summary>
        /// <param name="objA">The objA<see cref="object"/></param>
        /// <param name="objB">The objB<see cref="object"/></param>
        /// <returns>The <see cref="bool"/></returns>
        [Description("This extension method represents shorthand version of ReferenceEqualsEx method.")]
        private static bool ReferenceEqualsEx(this object objA, object objB) => ReferenceEquals(objA, objB);

        
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
/// <summary>
        /// Returns a value based on an provided value and evaluation function
        /// </summary>
        /// <typeparam name="TIn"></typeparam>
        /// <typeparam name="TOut"></typeparam>
        /// <param name="value">The value<see cref="TIn"/></param>
        /// <param name="evaluateFunc">The evaluateFunc<see cref="Func{TIn, TOut}"/></param>
        /// <returns>The <see cref="TOut"/></returns>
        [Description("Returns a value based on an provided value and evaluation function")]
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
        public static TOut Return<TIn, TOut>(this TIn value, Func<TIn, TOut> evaluateFunc) => evaluateFunc(value);

        /// <summary>
        /// Returns characters from right of specified length
        /// </summary>
        /// <param name="value">String value</param>
        /// <param name="length">Max number of characters to return</param>
        /// <returns>Returns string from right</returns>
        [Description("Returns characters from right of specified length")]
        public static string Right(this string value, int length) => value != null && value.Length > length ? value.Substring(value.Length - length) : value;

        
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
/// <summary>
        /// Spins up and executes the action within a thread. Basically fire and forget. 
        /// Real big question here. Does anybody see any issues with thread management? 
        /// I would like to update this with any code necessary to manage thread cleanup if necessary. 
        /// I realize that this has the ability to create unsafe thread referencing if not written such 
        /// that the contents of the action are exclusive to the scope of the action, but that is outside the purview of this extension
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="params">The params<see cref="T"/></param>
        /// <param name="action">The action<see cref="Action{T}"/></param>
        [Description("Spins up and executes the action within a thread. Basically fire and forget. Real big question here. Does anybody see any issues with thread management? I would like to update this with any code necessary to manage thread cleanup if necessary. I realize that this has the ability to create unsafe thread referencing if not written such that the contents of the action are exclusive to the scope of the action, but that is outside the purview of this extension")]
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
        public static void SpinThread<T>(this T @params, Action<T> action) => new Thread(p => action((T)p))
        {
            IsBackground = true
        }.Start(@params);

        
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
/// <summary>
        /// Throw's a given exception is a given predicate is True
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="val">The val<see cref="T"/></param>
        /// <param name="predicate">The predicate<see>
        ///         <cref>Func{T, bool}</cref>
        ///     </see>
        /// </param>
        /// <param name="exceptionFunc">The exceptionFunc<see cref="Func{Exception}"/></param>
        /// <returns>T object to throw exception <see cref="T"/></returns>
        public static T ThrowIf<T>(this T val, Func<T, bool> predicate, Func<Exception> exceptionFunc)
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
        {
            if (predicate(val))
            {
                throw exceptionFunc();
            }

            return val;
        }

        /// <summary>
        /// Converts string to  ToDecimal
        /// </summary>
        /// <param name="input">The input<see cref="string"/></param>
        /// <returns>The <see cref="decimal"/></returns>
        [Description("Converts string to  ToDecimal")]
        public static decimal ToDecimal(this string input) => input.IsDecimal() ? decimal.Parse(input) : 0;

        /// <summary>
        /// Converts string to  ToDouble
        /// </summary>
        /// <param name="input">The input<see cref="string"/></param>
        /// <returns>The <see cref="double"/></returns>
        [Description("Converts string to  ToDouble")]
        public static double ToDouble(this string input) => input.IsDecimal() ? double.Parse(input) : 0D;

        /// <summary>
        /// Converts string to enum object
        /// </summary>
        /// <typeparam name="T">Type of enum</typeparam>
        /// <param name="value">String value to convert</param>
        /// <returns>Returns enum object</returns>
        [Description("Converts string to enum object")]
        public static T ToEnum<T>(this string value)
            where T : struct =>
            (T)Enum.Parse(typeof(T), value, true);

        /// <summary>
        ///  Converts string to Int
        /// </summary>
        /// <param name="input">The input<see cref="string"/></param>
        /// <returns>The <see cref="int"/></returns>
        [Description("Converts string to Int")]
        public static int ToInt(this string input) => input.IsInt() ? int.Parse(input) : 0;

        /// <summary>
        /// <para>Creates a log-string from the Exception.</para>
        /// <para>The result includes the stacktrace, inner-exception et crater, separated by <seealso cref="Environment.NewLine"/>.</para>
        /// </summary>
        /// <param name="ex">The exception to create the string from.</param>
        /// <param name="additionalMessage">Additional message to place at the top of the string, maybe be empty or null.</param>
        /// <returns></returns>
        public static string ToLogString(this Exception ex, string additionalMessage)
        {
            var msg = new StringBuilder();

            if (additionalMessage.IsSet())
            {
                msg.Append(additionalMessage);
                msg.Append(Environment.NewLine);
            }

            if (ex.IsNull()) return msg.ToString();
            Exception orgEx = ex;

            msg.Append("Exception:");
            msg.Append(Environment.NewLine);
            while (!orgEx.IsNull())
            {
                msg.Append(orgEx?.Message);
                msg.Append(Environment.NewLine);
                orgEx = orgEx?.InnerException;
            }

            if (!ex.Data.IsNull())
            {
                foreach (var i in ex.Data)
                {
                    msg.Append("Data :");
                    msg.Append(i);
                    msg.Append(Environment.NewLine);
                }
            }

            if (!ex.StackTrace.IsNull())
            {
                msg.Append("StackTrace:");
                msg.Append(Environment.NewLine);
                msg.Append(ex.StackTrace);
                msg.Append(Environment.NewLine);
            }

            if (!ex.Source.IsNull())
            {
                msg.Append("Source:");
                msg.Append(Environment.NewLine);
                msg.Append(ex.Source);
                msg.Append(Environment.NewLine);
            }

            if (!ex.TargetSite.IsNull())
            {
                msg.Append("TargetSite:");
                msg.Append(Environment.NewLine);
                msg.Append(ex.TargetSite);
                msg.Append(Environment.NewLine);
            }

            Exception baseException = ex.GetBaseException();
            if (baseException.IsNull()) return msg.ToString();
            msg.Append("BaseException:");
            msg.Append(Environment.NewLine);
            msg.Append(ex.GetBaseException());
            return msg.ToString();
        }

        /// <summary>
        /// Make object Null
        /// </summary>
        /// <param name="_"> _<see cref="object"/></param>
        /// <returns>The <see cref="object"/></returns>
        public static object ToNull(this object _) => null;

        /// <summary>
        /// Make  Url Slug
        /// </summary>
        /// <param name="value">The value<see cref="string"/></param>
        /// <returns>The <see cref="string"/></returns>
        public static string ToUrlSlug(this string value)
        {

            //First to lower case 
            value = value.ToLowerInvariant();

            //Remove all accents
            byte[] bytes = Encoding.GetEncoding("Cyrillic").GetBytes(value);

            value = Encoding.ASCII.GetString(bytes);

            //Replace spaces 
            value = Regex.Replace(value, @"\s", "-", RegexOptions.Compiled);

            //Remove invalid chars 
            value = Regex.Replace(value, @"[^\w\s\p{Pd}]", "", RegexOptions.Compiled);

            //Trim dashes from end 
            value = value.Trim('-', '_');

            //Replace double occurrences of - or \_ 
            value = Regex.Replace(value, @"([-_]){2,}", "$1", RegexOptions.Compiled);

            return value;
        }

        /// <summary>
        /// Split Camel Case string to space delimited
        /// </summary>
        /// <param name="source">The source<see cref="string"/></param>
        /// <returns>spited string array</returns>
        [Description("Split Camel Case string to space delimited")]
        private static string[] SplitCamelCase(this string source) => Regex.Split(source, @"(?<!^)(?=[A-Z])");
    }
}
