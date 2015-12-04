using System;
using System.Linq.Expressions;

namespace Functions
{
    #region Builders

    /// <summary>
    /// Creates a function that returns a null object.
    /// </summary>
    public static class ActionFunctionBuilder
    {
        public static Function<object> GetFunction
        (Action action) =>
            new Function<object>(() => { action(); return null; });

        public static Function<T1, object> GetFunction<T1>
        (Action<T1> action) =>
            new Function<T1, object>((arg1) => { action(arg1); return null; });

        public static Function<T1, T2, object> GetFunction<T1, T2>
        (Action<T1, T2> action) =>
            new Function<T1, T2, object>((agr1, arg2) => { action(agr1, arg2); return null; });

        public static Function<T1, T2, T3, object> GetFunction<T1, T2, T3>
        (Action<T1, T2, T3> action) =>
            new Function<T1, T2, T3, object>((agr1, agr2, arg3) => { action(agr1, agr2, arg3); return null; });

        public static Function<T1, T2, T3, T4, object> GetFunction<T1, T2, T3, T4>
        (Action<T1, T2, T3, T4> action) =>
            new Function<T1, T2, T3, T4, object>((agr1, agr2, agr3, arg4) => { action(agr1, agr2, agr3, arg4); return null; });

        public static Function<T1, T2, T3, T4, T5, object> GetFunction<T1, T2, T3, T4, T5>
        (Action<T1, T2, T3, T4, T5> action) =>
            new Function<T1, T2, T3, T4, T5, object>((agr1, agr2, agr3, agr4, arg5) => { action(agr1, agr2, agr3, agr4, arg5); return null; });

        public static Function<T1, T2, T3, T4, T5, T6, object> GetFunction<T1, T2, T3, T4, T5, T6>
        (Action<T1, T2, T3, T4, T5, T6> action) =>
            new Function<T1, T2, T3, T4, T5, T6, object>((agr1, agr2, agr3, agr4, agr5, arg6) => { action(agr1, agr2, agr3, agr4, agr5, arg6); return null; });

        public static Function<T1, T2, T3, T4, T5, T6, T7, object> GetFunction<T1, T2, T3, T4, T5, T6, T7>
        (Action<T1, T2, T3, T4, T5, T6, T7> action) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, object>((agr1, agr2, agr3, agr4, agr5, agr6, arg7) => { action(agr1, agr2, agr3, agr4, agr5, agr6, arg7); return null; });

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, object> GetFunction<T1, T2, T3, T4, T5, T6, T7, T8>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8> action) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, object>((agr1, agr2, agr3, agr4, agr5, agr6, agr7, arg8) => { action(agr1, agr2, agr3, agr4, agr5, agr6, agr7, arg8); return null; });

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, object> GetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, object>((agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, arg9) => { action(agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, arg9); return null; });

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, object> GetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, object>((agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, arg10) => { action(agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, arg10); return null; });

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, object> GetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, object>((agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, arg11) => { action(agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, arg11); return null; });

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, object> GetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, object>((agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, arg12) => { action(agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, arg12); return null; });

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, object> GetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, object>((agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, agr12, arg13) => { action(agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, agr12, arg13); return null; });

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, object> GetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, object>((agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, agr12, agr13, arg14) => { action(agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, agr12, agr13, arg14); return null; });

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, object> GetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, object>((agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, agr12, agr13, agr14, arg15) => { action(agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, agr12, agr13, agr14, arg15); return null; });

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, object> GetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, object>((agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, agr12, agr13, agr14, agr15, arg16) => { action(agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, agr12, agr13, agr14, agr15, arg16); return null; });


    }

    /// <summary>
    /// Creates Functions without the need to specify the generic types.
    /// </summary>
    public static class FunctionBuilder
    {
        public static Function<TResult> GetFunction<TResult>
        (Func<TResult> func) =>
            new Function<TResult>(func);

        public static Function<T1, TResult> GetFunction<T1, TResult>
        (Func<T1, TResult> func) =>
            new Function<T1, TResult>(func);

        public static Function<T1, T2, TResult> GetFunction<T1, T2, TResult>
        (Func<T1, T2, TResult> func) =>
            new Function<T1, T2, TResult>(func);

        public static Function<T1, T2, T3, TResult> GetFunction<T1, T2, T3, TResult>
        (Func<T1, T2, T3, TResult> func) =>
            new Function<T1, T2, T3, TResult>(func);

        public static Function<T1, T2, T3, T4, TResult> GetFunction<T1, T2, T3, T4, TResult>
        (Func<T1, T2, T3, T4, TResult> func) =>
            new Function<T1, T2, T3, T4, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, TResult> GetFunction<T1, T2, T3, T4, T5, TResult>
        (Func<T1, T2, T3, T4, T5, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, TResult> GetFunction<T1, T2, T3, T4, T5, T6, TResult>
        (Func<T1, T2, T3, T4, T5, T6, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, TResult> GetFunction<T1, T2, T3, T4, T5, T6, T7, TResult>
        (Func<T1, T2, T3, T4, T5, T6, T7, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult> GetFunction<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
        (Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> GetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
        (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> GetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
        (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> GetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>
        (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> GetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>
        (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> GetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>
        (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> GetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>
        (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> GetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>
        (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> GetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>
        (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(func);

    }

    #endregion

    #region functuions

    public class Function<TResult>
    {
        public Func<TResult> function { get; }

        #region Types        
        public Type TResultType
        {
            get
            {
                return typeof(TResult);
            }
        }
        public Type[] Parameters
        {
            get
            {
                return new Type[] { };
            }
        }
        #endregion

        public Function(Func<TResult> _func)
        {
            function = _func;
        }

        public Function<TResult> PartiallyApply() =>
            new Function<TResult>(() => function());


        public Func<TResult> PartiallyApplyAsFunc() =>
            new Func<TResult>(() => function()); public TResult Apply() =>
                function();

        public static implicit operator Func<TResult>(Function<TResult> function) =>
            function.function;

        public static implicit operator Function<TResult>(Func<TResult> func) =>
            new Function<TResult>(func);

        public static Function<TResult> operator +(Function<TResult> fun1, Function<TResult> fun2) =>
            new Function<TResult>(fun1.function + fun2.function);

        public static Function<TResult> operator -(Function<TResult> fun1, Function<TResult> fun2) =>
            fun1.function - fun2.function;

        public static bool operator ==(Function<TResult> fun1, Function<TResult> fun2) =>
            fun1.function == fun2.function;

        public static bool operator !=(Function<TResult> fun1, Function<TResult> fun2) =>
            fun1.function != fun2.function;

        public override bool Equals(object obj) =>
            function.Equals(obj);

        public static explicit operator Function<TResult>(Expression<Func<TResult>> funcExp) =>
            new Function<TResult>(funcExp.Compile());

        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }

    public class Function<T1, TResult>
    {
        public Func<T1, TResult> function { get; }

        #region Types
        public Type T1Type
        {
            get
            {
                return typeof(T1);
            }
        }
        public Type TResultType
        {
            get
            {
                return typeof(TResult);
            }
        }
        public Type[] Parameters
        {
            get
            {
                return new Type[] { typeof(T1) };
            }
        }
        #endregion

        public Function(Func<T1, TResult> _func)
        {
            function = _func;
        }

        public Function<T1, TResult> PartiallyApply() =>
            new Function<T1, TResult>((arg1) => function(arg1));

        public Function<TResult> PartiallyApply(T1 arg1) =>
            new Function<TResult>(() => function(arg1));

        public Func<T1, TResult> PartiallyApplyAsFunc() =>
            new Func<T1, TResult>((arg1) => function(arg1));

        public Func<TResult> PartiallyApplyAsFunc(T1 arg1) =>
            new Func<TResult>(() => function(arg1)); public TResult Apply(T1 arg1) =>
          function(arg1);

        public static implicit operator Func<T1, TResult>(Function<T1, TResult> function) =>
            function.function;

        public static implicit operator Function<T1, TResult>(Func<T1, TResult> func) =>
            new Function<T1, TResult>(func);

        public static Function<T1, TResult> operator +(Function<T1, TResult> fun1, Function<T1, TResult> fun2) =>
            new Function<T1, TResult>(fun1.function + fun2.function);

        public static Function<T1, TResult> operator -(Function<T1, TResult> fun1, Function<T1, TResult> fun2) =>
            fun1.function - fun2.function;

        public static bool operator ==(Function<T1, TResult> fun1, Function<T1, TResult> fun2) =>
            fun1.function == fun2.function;

        public static bool operator !=(Function<T1, TResult> fun1, Function<T1, TResult> fun2) =>
            fun1.function != fun2.function;

        public override bool Equals(object obj) =>
            function.Equals(obj);

        public static explicit operator Function<T1, TResult>(Expression<Func<T1, TResult>> funcExp) =>
            new Function<T1, TResult>(funcExp.Compile());

        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }

    public class Function<T1, T2, TResult>
    {
        public Func<T1, T2, TResult> function { get; }

        #region Types
        public Type T1Type
        {
            get
            {
                return typeof(T1);
            }
        }
        public Type T2Type
        {
            get
            {
                return typeof(T2);
            }
        }
        public Type TResultType
        {
            get
            {
                return typeof(TResult);
            }
        }
        public Type[] Parameters
        {
            get
            {
                return new Type[] { typeof(T1), typeof(T2) };
            }
        }
        #endregion

        public Function(Func<T1, T2, TResult> _func)
        {
            function = _func;
        }

        public Function<T1, T2, TResult> PartiallyApply() =>
            new Function<T1, T2, TResult>((arg1, arg2) => function(arg1, arg2));

        public Function<T2, TResult> PartiallyApply(T1 arg1) =>
            new Function<T2, TResult>((arg2) => function(arg1, arg2));

        public Function<TResult> PartiallyApply(T1 arg1, T2 arg2) =>
            new Function<TResult>(() => function(arg1, arg2));

        public Func<T1, T2, TResult> PartiallyApplyAsFunc() =>
            new Func<T1, T2, TResult>((arg1, arg2) => function(arg1, arg2));

        public Func<T2, TResult> PartiallyApplyAsFunc(T1 arg1) =>
            new Func<T2, TResult>((arg2) => function(arg1, arg2));

        public Func<TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2) =>
            new Func<TResult>(() => function(arg1, arg2)); public TResult Apply(T1 arg1, T2 arg2) =>
          function(arg1, arg2);

        public static implicit operator Func<T1, T2, TResult>(Function<T1, T2, TResult> function) =>
            function.function;

        public static implicit operator Function<T1, T2, TResult>(Func<T1, T2, TResult> func) =>
            new Function<T1, T2, TResult>(func);

        public static Function<T1, T2, TResult> operator +(Function<T1, T2, TResult> fun1, Function<T1, T2, TResult> fun2) =>
            new Function<T1, T2, TResult>(fun1.function + fun2.function);

        public static Function<T1, T2, TResult> operator -(Function<T1, T2, TResult> fun1, Function<T1, T2, TResult> fun2) =>
            fun1.function - fun2.function;

        public static bool operator ==(Function<T1, T2, TResult> fun1, Function<T1, T2, TResult> fun2) =>
            fun1.function == fun2.function;

        public static bool operator !=(Function<T1, T2, TResult> fun1, Function<T1, T2, TResult> fun2) =>
            fun1.function != fun2.function;

        public override bool Equals(object obj) =>
            function.Equals(obj);

        public static explicit operator Function<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> funcExp) =>
            new Function<T1, T2, TResult>(funcExp.Compile());

        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }

    public class Function<T1, T2, T3, TResult>
    {
        public Func<T1, T2, T3, TResult> function { get; }

        #region Types
        public Type T1Type
        {
            get
            {
                return typeof(T1);
            }
        }
        public Type T2Type
        {
            get
            {
                return typeof(T2);
            }
        }
        public Type T3Type
        {
            get
            {
                return typeof(T3);
            }
        }
        public Type TResultType
        {
            get
            {
                return typeof(TResult);
            }
        }
        public Type[] Parameters
        {
            get
            {
                return new Type[] { typeof(T1), typeof(T2), typeof(T3) };
            }
        }
        #endregion

        public Function(Func<T1, T2, T3, TResult> _func)
        {
            function = _func;
        }

        public Function<T1, T2, T3, TResult> PartiallyApply() =>
            new Function<T1, T2, T3, TResult>((arg1, arg2, arg3) => function(arg1, arg2, arg3));

        public Function<T2, T3, TResult> PartiallyApply(T1 arg1) =>
            new Function<T2, T3, TResult>((arg2, arg3) => function(arg1, arg2, arg3));

        public Function<T3, TResult> PartiallyApply(T1 arg1, T2 arg2) =>
            new Function<T3, TResult>((arg3) => function(arg1, arg2, arg3));

        public Function<TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3) =>
            new Function<TResult>(() => function(arg1, arg2, arg3));

        public Func<T1, T2, T3, TResult> PartiallyApplyAsFunc() =>
            new Func<T1, T2, T3, TResult>((arg1, arg2, arg3) => function(arg1, arg2, arg3));

        public Func<T2, T3, TResult> PartiallyApplyAsFunc(T1 arg1) =>
            new Func<T2, T3, TResult>((arg2, arg3) => function(arg1, arg2, arg3));

        public Func<T3, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2) =>
            new Func<T3, TResult>((arg3) => function(arg1, arg2, arg3));

        public Func<TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3) =>
            new Func<TResult>(() => function(arg1, arg2, arg3)); public TResult Apply(T1 arg1, T2 arg2, T3 arg3) =>
          function(arg1, arg2, arg3);

        public static implicit operator Func<T1, T2, T3, TResult>(Function<T1, T2, T3, TResult> function) =>
            function.function;

        public static implicit operator Function<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> func) =>
            new Function<T1, T2, T3, TResult>(func);

        public static Function<T1, T2, T3, TResult> operator +(Function<T1, T2, T3, TResult> fun1, Function<T1, T2, T3, TResult> fun2) =>
            new Function<T1, T2, T3, TResult>(fun1.function + fun2.function);

        public static Function<T1, T2, T3, TResult> operator -(Function<T1, T2, T3, TResult> fun1, Function<T1, T2, T3, TResult> fun2) =>
            fun1.function - fun2.function;

        public static bool operator ==(Function<T1, T2, T3, TResult> fun1, Function<T1, T2, T3, TResult> fun2) =>
            fun1.function == fun2.function;

        public static bool operator !=(Function<T1, T2, T3, TResult> fun1, Function<T1, T2, T3, TResult> fun2) =>
            fun1.function != fun2.function;

        public override bool Equals(object obj) =>
            function.Equals(obj);

        public static explicit operator Function<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> funcExp) =>
            new Function<T1, T2, T3, TResult>(funcExp.Compile());

        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }

    public class Function<T1, T2, T3, T4, TResult>
    {
        public Func<T1, T2, T3, T4, TResult> function { get; }

        #region Types
        public Type T1Type
        {
            get
            {
                return typeof(T1);
            }
        }
        public Type T2Type
        {
            get
            {
                return typeof(T2);
            }
        }
        public Type T3Type
        {
            get
            {
                return typeof(T3);
            }
        }
        public Type T4Type
        {
            get
            {
                return typeof(T4);
            }
        }
        public Type TResultType
        {
            get
            {
                return typeof(TResult);
            }
        }
        public Type[] Parameters
        {
            get
            {
                return new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) };
            }
        }
        #endregion

        public Function(Func<T1, T2, T3, T4, TResult> _func)
        {
            function = _func;
        }

        public Function<T1, T2, T3, T4, TResult> PartiallyApply() =>
            new Function<T1, T2, T3, T4, TResult>((arg1, arg2, arg3, arg4) => function(arg1, arg2, arg3, arg4));

        public Function<T2, T3, T4, TResult> PartiallyApply(T1 arg1) =>
            new Function<T2, T3, T4, TResult>((arg2, arg3, arg4) => function(arg1, arg2, arg3, arg4));

        public Function<T3, T4, TResult> PartiallyApply(T1 arg1, T2 arg2) =>
            new Function<T3, T4, TResult>((arg3, arg4) => function(arg1, arg2, arg3, arg4));

        public Function<T4, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3) =>
            new Function<T4, TResult>((arg4) => function(arg1, arg2, arg3, arg4));

        public Function<TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Function<TResult>(() => function(arg1, arg2, arg3, arg4));

        public Func<T1, T2, T3, T4, TResult> PartiallyApplyAsFunc() =>
            new Func<T1, T2, T3, T4, TResult>((arg1, arg2, arg3, arg4) => function(arg1, arg2, arg3, arg4));

        public Func<T2, T3, T4, TResult> PartiallyApplyAsFunc(T1 arg1) =>
            new Func<T2, T3, T4, TResult>((arg2, arg3, arg4) => function(arg1, arg2, arg3, arg4));

        public Func<T3, T4, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2) =>
            new Func<T3, T4, TResult>((arg3, arg4) => function(arg1, arg2, arg3, arg4));

        public Func<T4, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3) =>
            new Func<T4, TResult>((arg4) => function(arg1, arg2, arg3, arg4));

        public Func<TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Func<TResult>(() => function(arg1, arg2, arg3, arg4)); public TResult Apply(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
          function(arg1, arg2, arg3, arg4);

        public static implicit operator Func<T1, T2, T3, T4, TResult>(Function<T1, T2, T3, T4, TResult> function) =>
            function.function;

        public static implicit operator Function<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> func) =>
            new Function<T1, T2, T3, T4, TResult>(func);

        public static Function<T1, T2, T3, T4, TResult> operator +(Function<T1, T2, T3, T4, TResult> fun1, Function<T1, T2, T3, T4, TResult> fun2) =>
            new Function<T1, T2, T3, T4, TResult>(fun1.function + fun2.function);

        public static Function<T1, T2, T3, T4, TResult> operator -(Function<T1, T2, T3, T4, TResult> fun1, Function<T1, T2, T3, T4, TResult> fun2) =>
            fun1.function - fun2.function;

        public static bool operator ==(Function<T1, T2, T3, T4, TResult> fun1, Function<T1, T2, T3, T4, TResult> fun2) =>
            fun1.function == fun2.function;

        public static bool operator !=(Function<T1, T2, T3, T4, TResult> fun1, Function<T1, T2, T3, T4, TResult> fun2) =>
            fun1.function != fun2.function;

        public override bool Equals(object obj) =>
            function.Equals(obj);

        public static explicit operator Function<T1, T2, T3, T4, TResult>(Expression<Func<T1, T2, T3, T4, TResult>> funcExp) =>
            new Function<T1, T2, T3, T4, TResult>(funcExp.Compile());

        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }

    public class Function<T1, T2, T3, T4, T5, TResult>
    {
        public Func<T1, T2, T3, T4, T5, TResult> function { get; }

        #region Types
        public Type T1Type
        {
            get
            {
                return typeof(T1);
            }
        }
        public Type T2Type
        {
            get
            {
                return typeof(T2);
            }
        }
        public Type T3Type
        {
            get
            {
                return typeof(T3);
            }
        }
        public Type T4Type
        {
            get
            {
                return typeof(T4);
            }
        }
        public Type T5Type
        {
            get
            {
                return typeof(T5);
            }
        }
        public Type TResultType
        {
            get
            {
                return typeof(TResult);
            }
        }
        public Type[] Parameters
        {
            get
            {
                return new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) };
            }
        }
        #endregion

        public Function(Func<T1, T2, T3, T4, T5, TResult> _func)
        {
            function = _func;
        }

        public Function<T1, T2, T3, T4, T5, TResult> PartiallyApply() =>
            new Function<T1, T2, T3, T4, T5, TResult>((arg1, arg2, arg3, arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5));

        public Function<T2, T3, T4, T5, TResult> PartiallyApply(T1 arg1) =>
            new Function<T2, T3, T4, T5, TResult>((arg2, arg3, arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5));

        public Function<T3, T4, T5, TResult> PartiallyApply(T1 arg1, T2 arg2) =>
            new Function<T3, T4, T5, TResult>((arg3, arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5));

        public Function<T4, T5, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3) =>
            new Function<T4, T5, TResult>((arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5));

        public Function<T5, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Function<T5, TResult>((arg5) => function(arg1, arg2, arg3, arg4, arg5));

        public Function<TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Function<TResult>(() => function(arg1, arg2, arg3, arg4, arg5));

        public Func<T1, T2, T3, T4, T5, TResult> PartiallyApplyAsFunc() =>
            new Func<T1, T2, T3, T4, T5, TResult>((arg1, arg2, arg3, arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5));

        public Func<T2, T3, T4, T5, TResult> PartiallyApplyAsFunc(T1 arg1) =>
            new Func<T2, T3, T4, T5, TResult>((arg2, arg3, arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5));

        public Func<T3, T4, T5, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2) =>
            new Func<T3, T4, T5, TResult>((arg3, arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5));

        public Func<T4, T5, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3) =>
            new Func<T4, T5, TResult>((arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5));

        public Func<T5, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Func<T5, TResult>((arg5) => function(arg1, arg2, arg3, arg4, arg5));

        public Func<TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Func<TResult>(() => function(arg1, arg2, arg3, arg4, arg5)); public TResult Apply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
          function(arg1, arg2, arg3, arg4, arg5);

        public static implicit operator Func<T1, T2, T3, T4, T5, TResult>(Function<T1, T2, T3, T4, T5, TResult> function) =>
            function.function;

        public static implicit operator Function<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, TResult> operator +(Function<T1, T2, T3, T4, T5, TResult> fun1, Function<T1, T2, T3, T4, T5, TResult> fun2) =>
            new Function<T1, T2, T3, T4, T5, TResult>(fun1.function + fun2.function);

        public static Function<T1, T2, T3, T4, T5, TResult> operator -(Function<T1, T2, T3, T4, T5, TResult> fun1, Function<T1, T2, T3, T4, T5, TResult> fun2) =>
            fun1.function - fun2.function;

        public static bool operator ==(Function<T1, T2, T3, T4, T5, TResult> fun1, Function<T1, T2, T3, T4, T5, TResult> fun2) =>
            fun1.function == fun2.function;

        public static bool operator !=(Function<T1, T2, T3, T4, T5, TResult> fun1, Function<T1, T2, T3, T4, T5, TResult> fun2) =>
            fun1.function != fun2.function;

        public override bool Equals(object obj) =>
            function.Equals(obj);

        public static explicit operator Function<T1, T2, T3, T4, T5, TResult>(Expression<Func<T1, T2, T3, T4, T5, TResult>> funcExp) =>
            new Function<T1, T2, T3, T4, T5, TResult>(funcExp.Compile());

        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }

    public class Function<T1, T2, T3, T4, T5, T6, TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, TResult> function { get; }

        #region Types
        public Type T1Type
        {
            get
            {
                return typeof(T1);
            }
        }
        public Type T2Type
        {
            get
            {
                return typeof(T2);
            }
        }
        public Type T3Type
        {
            get
            {
                return typeof(T3);
            }
        }
        public Type T4Type
        {
            get
            {
                return typeof(T4);
            }
        }
        public Type T5Type
        {
            get
            {
                return typeof(T5);
            }
        }
        public Type T6Type
        {
            get
            {
                return typeof(T6);
            }
        }
        public Type TResultType
        {
            get
            {
                return typeof(TResult);
            }
        }
        public Type[] Parameters
        {
            get
            {
                return new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6) };
            }
        }
        #endregion

        public Function(Func<T1, T2, T3, T4, T5, T6, TResult> _func)
        {
            function = _func;
        }

        public Function<T1, T2, T3, T4, T5, T6, TResult> PartiallyApply() =>
            new Function<T1, T2, T3, T4, T5, T6, TResult>((arg1, arg2, arg3, arg4, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6));

        public Function<T2, T3, T4, T5, T6, TResult> PartiallyApply(T1 arg1) =>
            new Function<T2, T3, T4, T5, T6, TResult>((arg2, arg3, arg4, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6));

        public Function<T3, T4, T5, T6, TResult> PartiallyApply(T1 arg1, T2 arg2) =>
            new Function<T3, T4, T5, T6, TResult>((arg3, arg4, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6));

        public Function<T4, T5, T6, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3) =>
            new Function<T4, T5, T6, TResult>((arg4, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6));

        public Function<T5, T6, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Function<T5, T6, TResult>((arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6));

        public Function<T6, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Function<T6, TResult>((arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6));

        public Function<TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Function<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6));

        public Func<T1, T2, T3, T4, T5, T6, TResult> PartiallyApplyAsFunc() =>
            new Func<T1, T2, T3, T4, T5, T6, TResult>((arg1, arg2, arg3, arg4, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6));

        public Func<T2, T3, T4, T5, T6, TResult> PartiallyApplyAsFunc(T1 arg1) =>
            new Func<T2, T3, T4, T5, T6, TResult>((arg2, arg3, arg4, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6));

        public Func<T3, T4, T5, T6, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2) =>
            new Func<T3, T4, T5, T6, TResult>((arg3, arg4, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6));

        public Func<T4, T5, T6, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3) =>
            new Func<T4, T5, T6, TResult>((arg4, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6));

        public Func<T5, T6, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Func<T5, T6, TResult>((arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6));

        public Func<T6, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Func<T6, TResult>((arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6));

        public Func<TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Func<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6)); public TResult Apply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
          function(arg1, arg2, arg3, arg4, arg5, arg6);

        public static implicit operator Func<T1, T2, T3, T4, T5, T6, TResult>(Function<T1, T2, T3, T4, T5, T6, TResult> function) =>
            function.function;

        public static implicit operator Function<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, TResult> operator +(Function<T1, T2, T3, T4, T5, T6, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, TResult> fun2) =>
            new Function<T1, T2, T3, T4, T5, T6, TResult>(fun1.function + fun2.function);

        public static Function<T1, T2, T3, T4, T5, T6, TResult> operator -(Function<T1, T2, T3, T4, T5, T6, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, TResult> fun2) =>
            fun1.function - fun2.function;

        public static bool operator ==(Function<T1, T2, T3, T4, T5, T6, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, TResult> fun2) =>
            fun1.function == fun2.function;

        public static bool operator !=(Function<T1, T2, T3, T4, T5, T6, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, TResult> fun2) =>
            fun1.function != fun2.function;

        public override bool Equals(object obj) =>
            function.Equals(obj);

        public static explicit operator Function<T1, T2, T3, T4, T5, T6, TResult>(Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> funcExp) =>
            new Function<T1, T2, T3, T4, T5, T6, TResult>(funcExp.Compile());

        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }

    public class Function<T1, T2, T3, T4, T5, T6, T7, TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, TResult> function { get; }

        #region Types
        public Type T1Type
        {
            get
            {
                return typeof(T1);
            }
        }
        public Type T2Type
        {
            get
            {
                return typeof(T2);
            }
        }
        public Type T3Type
        {
            get
            {
                return typeof(T3);
            }
        }
        public Type T4Type
        {
            get
            {
                return typeof(T4);
            }
        }
        public Type T5Type
        {
            get
            {
                return typeof(T5);
            }
        }
        public Type T6Type
        {
            get
            {
                return typeof(T6);
            }
        }
        public Type T7Type
        {
            get
            {
                return typeof(T7);
            }
        }
        public Type TResultType
        {
            get
            {
                return typeof(TResult);
            }
        }
        public Type[] Parameters
        {
            get
            {
                return new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7) };
            }
        }
        #endregion

        public Function(Func<T1, T2, T3, T4, T5, T6, T7, TResult> _func)
        {
            function = _func;
        }

        public Function<T1, T2, T3, T4, T5, T6, T7, TResult> PartiallyApply() =>
            new Function<T1, T2, T3, T4, T5, T6, T7, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7));

        public Function<T2, T3, T4, T5, T6, T7, TResult> PartiallyApply(T1 arg1) =>
            new Function<T2, T3, T4, T5, T6, T7, TResult>((arg2, arg3, arg4, arg5, arg6, arg7) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7));

        public Function<T3, T4, T5, T6, T7, TResult> PartiallyApply(T1 arg1, T2 arg2) =>
            new Function<T3, T4, T5, T6, T7, TResult>((arg3, arg4, arg5, arg6, arg7) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7));

        public Function<T4, T5, T6, T7, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3) =>
            new Function<T4, T5, T6, T7, TResult>((arg4, arg5, arg6, arg7) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7));

        public Function<T5, T6, T7, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Function<T5, T6, T7, TResult>((arg5, arg6, arg7) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7));

        public Function<T6, T7, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Function<T6, T7, TResult>((arg6, arg7) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7));

        public Function<T7, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Function<T7, TResult>((arg7) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7));

        public Function<TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Function<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7));

        public Func<T1, T2, T3, T4, T5, T6, T7, TResult> PartiallyApplyAsFunc() =>
            new Func<T1, T2, T3, T4, T5, T6, T7, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7));

        public Func<T2, T3, T4, T5, T6, T7, TResult> PartiallyApplyAsFunc(T1 arg1) =>
            new Func<T2, T3, T4, T5, T6, T7, TResult>((arg2, arg3, arg4, arg5, arg6, arg7) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7));

        public Func<T3, T4, T5, T6, T7, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2) =>
            new Func<T3, T4, T5, T6, T7, TResult>((arg3, arg4, arg5, arg6, arg7) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7));

        public Func<T4, T5, T6, T7, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3) =>
            new Func<T4, T5, T6, T7, TResult>((arg4, arg5, arg6, arg7) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7));

        public Func<T5, T6, T7, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Func<T5, T6, T7, TResult>((arg5, arg6, arg7) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7));

        public Func<T6, T7, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Func<T6, T7, TResult>((arg6, arg7) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7));

        public Func<T7, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Func<T7, TResult>((arg7) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7));

        public Func<TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Func<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7)); public TResult Apply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
          function(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, TResult>(Function<T1, T2, T3, T4, T5, T6, T7, TResult> function) =>
            function.function;

        public static implicit operator Function<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, TResult> operator +(Function<T1, T2, T3, T4, T5, T6, T7, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, TResult> fun2) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, TResult>(fun1.function + fun2.function);

        public static Function<T1, T2, T3, T4, T5, T6, T7, TResult> operator -(Function<T1, T2, T3, T4, T5, T6, T7, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, TResult> fun2) =>
            fun1.function - fun2.function;

        public static bool operator ==(Function<T1, T2, T3, T4, T5, T6, T7, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, TResult> fun2) =>
            fun1.function == fun2.function;

        public static bool operator !=(Function<T1, T2, T3, T4, T5, T6, T7, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, TResult> fun2) =>
            fun1.function != fun2.function;

        public override bool Equals(object obj) =>
            function.Equals(obj);

        public static explicit operator Function<T1, T2, T3, T4, T5, T6, T7, TResult>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> funcExp) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, TResult>(funcExp.Compile());

        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }

    public class Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function { get; }

        #region Types
        public Type T1Type
        {
            get
            {
                return typeof(T1);
            }
        }
        public Type T2Type
        {
            get
            {
                return typeof(T2);
            }
        }
        public Type T3Type
        {
            get
            {
                return typeof(T3);
            }
        }
        public Type T4Type
        {
            get
            {
                return typeof(T4);
            }
        }

        public Type T5Type
        {
            get
            {
                return typeof(T5);
            }
        }

        public Type T6Type
        {
            get
            {
                return typeof(T6);
            }
        }

        public Type T7Type
        {
            get
            {
                return typeof(T7);
            }
        }

        public Type T8Type
        {
            get
            {
                return typeof(T8);
            }
        }



        public Type TResultType
        {
            get
            {
                return typeof(TResult);
            }
        }
        public Type[] Parameters
        {
            get
            {
                return new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8) };
            }
        }
        #endregion

        public Function(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> _func)
        {
            function = _func;
        }

        public Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult> PartiallyApply() =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));

        public Function<T2, T3, T4, T5, T6, T7, T8, TResult> PartiallyApply(T1 arg1) =>
            new Function<T2, T3, T4, T5, T6, T7, T8, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));

        public Function<T3, T4, T5, T6, T7, T8, TResult> PartiallyApply(T1 arg1, T2 arg2) =>
            new Function<T3, T4, T5, T6, T7, T8, TResult>((arg3, arg4, arg5, arg6, arg7, arg8) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));

        public Function<T4, T5, T6, T7, T8, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3) =>
            new Function<T4, T5, T6, T7, T8, TResult>((arg4, arg5, arg6, arg7, arg8) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));

        public Function<T5, T6, T7, T8, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Function<T5, T6, T7, T8, TResult>((arg5, arg6, arg7, arg8) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));

        public Function<T6, T7, T8, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Function<T6, T7, T8, TResult>((arg6, arg7, arg8) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));

        public Function<T7, T8, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Function<T7, T8, TResult>((arg7, arg8) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));

        public Function<T8, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Function<T8, TResult>((arg8) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));

        public Function<TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            new Function<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> PartiallyApplyAsFunc() =>
            new Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));


        public Func<T2, T3, T4, T5, T6, T7, T8, TResult> PartiallyApplyAsFunc(T1 arg1) =>
            new Func<T2, T3, T4, T5, T6, T7, T8, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));


        public Func<T3, T4, T5, T6, T7, T8, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2) =>
            new Func<T3, T4, T5, T6, T7, T8, TResult>((arg3, arg4, arg5, arg6, arg7, arg8) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));


        public Func<T4, T5, T6, T7, T8, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3) =>
            new Func<T4, T5, T6, T7, T8, TResult>((arg4, arg5, arg6, arg7, arg8) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));


        public Func<T5, T6, T7, T8, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Func<T5, T6, T7, T8, TResult>((arg5, arg6, arg7, arg8) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));


        public Func<T6, T7, T8, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Func<T6, T7, T8, TResult>((arg6, arg7, arg8) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));


        public Func<T7, T8, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Func<T7, T8, TResult>((arg7, arg8) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));


        public Func<T8, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Func<T8, TResult>((arg8) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));


        public Func<TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            new Func<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)); public TResult Apply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
          function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function) =>
            function.function;

        public static implicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult> operator +(Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult> fun2) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(fun1.function + fun2.function);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult> operator -(Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult> fun2) =>
            fun1.function - fun2.function;

        public static bool operator ==(Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult> fun2) =>
            fun1.function == fun2.function;

        public static bool operator !=(Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult> fun2) =>
            fun1.function != fun2.function;

        public override bool Equals(object obj) =>
            function.Equals(obj);

        public static explicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> funcExp) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(funcExp.Compile());

        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }

    public class Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function { get; }

        #region Types
        public Type T1Type
        {
            get
            {
                return typeof(T1);
            }
        }

        public Type T2Type
        {
            get
            {
                return typeof(T2);
            }
        }

        public Type T3Type
        {
            get
            {
                return typeof(T3);
            }
        }

        public Type T4Type
        {
            get
            {
                return typeof(T4);
            }
        }

        public Type T5Type
        {
            get
            {
                return typeof(T5);
            }
        }

        public Type T6Type
        {
            get
            {
                return typeof(T6);
            }
        }

        public Type T7Type
        {
            get
            {
                return typeof(T7);
            }
        }

        public Type T8Type
        {
            get
            {
                return typeof(T8);
            }
        }

        public Type T9Type
        {
            get
            {
                return typeof(T9);
            }
        }
        
        public Type TResultType
        {
            get
            {
                return typeof(TResult);
            }
        }
        public Type[] Parameters
        {
            get
            {
                return new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9) };
            }
        }
        #endregion

        public Function(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> _func)
        {
            function = _func;
        }
        
        public Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> PartiallyApply() =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Function<T2, T3, T4, T5, T6, T7, T8, T9, TResult> PartiallyApply(T1 arg1) =>
            new Function<T2, T3, T4, T5, T6, T7, T8, T9, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Function<T3, T4, T5, T6, T7, T8, T9, TResult> PartiallyApply(T1 arg1, T2 arg2) =>
            new Function<T3, T4, T5, T6, T7, T8, T9, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Function<T4, T5, T6, T7, T8, T9, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3) =>
            new Function<T4, T5, T6, T7, T8, T9, TResult>((arg4, arg5, arg6, arg7, arg8, arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Function<T5, T6, T7, T8, T9, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Function<T5, T6, T7, T8, T9, TResult>((arg5, arg6, arg7, arg8, arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Function<T6, T7, T8, T9, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Function<T6, T7, T8, T9, TResult>((arg6, arg7, arg8, arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Function<T7, T8, T9, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Function<T7, T8, T9, TResult>((arg7, arg8, arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Function<T8, T9, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Function<T8, T9, TResult>((arg8, arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Function<T9, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            new Function<T9, TResult>((arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Function<TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) =>
            new Function<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> PartiallyApplyAsFunc() =>
            new Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult> PartiallyApplyAsFunc(T1 arg1) =>
            new Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Func<T3, T4, T5, T6, T7, T8, T9, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2) =>
            new Func<T3, T4, T5, T6, T7, T8, T9, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Func<T4, T5, T6, T7, T8, T9, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3) =>
            new Func<T4, T5, T6, T7, T8, T9, TResult>((arg4, arg5, arg6, arg7, arg8, arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Func<T5, T6, T7, T8, T9, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Func<T5, T6, T7, T8, T9, TResult>((arg5, arg6, arg7, arg8, arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Func<T6, T7, T8, T9, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Func<T6, T7, T8, T9, TResult>((arg6, arg7, arg8, arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Func<T7, T8, T9, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Func<T7, T8, T9, TResult>((arg7, arg8, arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Func<T8, T9, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Func<T8, T9, TResult>((arg8, arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Func<T9, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            new Func<T9, TResult>((arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));


        public Func<TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) =>
            new Func<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));

        public TResult Apply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) =>
          function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function) =>
            function.function;

        public static implicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> operator +(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> fun2) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(fun1.function + fun2.function);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> operator -(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> fun2) =>
            fun1.function - fun2.function;

        public static bool operator ==(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> fun2) =>
            fun1.function == fun2.function;

        public static bool operator !=(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> fun2) =>
            fun1.function != fun2.function;

        public override bool Equals(object obj) =>
            function.Equals(obj);

        public static explicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> funcExp) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(funcExp.Compile());

        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }

    public class Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function { get; }

        #region Types
        public Type T1Type
        {
            get
            {
                return typeof(T1);
            }
        }

        public Type T2Type
        {
            get
            {
                return typeof(T2);
            }
        }

        public Type T3Type
        {
            get
            {
                return typeof(T3);
            }
        }

        public Type T4Type
        {
            get
            {
                return typeof(T4);
            }
        }

        public Type T5Type
        {
            get
            {
                return typeof(T5);
            }
        }

        public Type T6Type
        {
            get
            {
                return typeof(T6);
            }
        }

        public Type T7Type
        {
            get
            {
                return typeof(T7);
            }
        }

        public Type T8Type
        {
            get
            {
                return typeof(T8);
            }
        }

        public Type T9Type
        {
            get
            {
                return typeof(T9);
            }
        }

        public Type T10Type
        {
            get
            {
                return typeof(T10);
            }
        }

        public Type TResultType
        {
            get
            {
                return typeof(TResult);
            }
        }
        public Type[] Parameters
        {
            get
            {
                return new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10) };
            }
        }
        #endregion

        public Function(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> _func)
        {
            function = _func;
        }
        
        public Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> PartiallyApply() =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Function<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> PartiallyApply(T1 arg1) =>
            new Function<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Function<T3, T4, T5, T6, T7, T8, T9, T10, TResult> PartiallyApply(T1 arg1, T2 arg2) =>
            new Function<T3, T4, T5, T6, T7, T8, T9, T10, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Function<T4, T5, T6, T7, T8, T9, T10, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3) =>
            new Function<T4, T5, T6, T7, T8, T9, T10, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Function<T5, T6, T7, T8, T9, T10, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Function<T5, T6, T7, T8, T9, T10, TResult>((arg5, arg6, arg7, arg8, arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Function<T6, T7, T8, T9, T10, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Function<T6, T7, T8, T9, T10, TResult>((arg6, arg7, arg8, arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Function<T7, T8, T9, T10, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Function<T7, T8, T9, T10, TResult>((arg7, arg8, arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Function<T8, T9, T10, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Function<T8, T9, T10, TResult>((arg8, arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Function<T9, T10, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            new Function<T9, T10, TResult>((arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Function<T10, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) =>
            new Function<T10, TResult>((arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Function<TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) =>
            new Function<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> PartiallyApplyAsFunc() =>
            new Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> PartiallyApplyAsFunc(T1 arg1) =>
            new Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Func<T3, T4, T5, T6, T7, T8, T9, T10, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2) =>
            new Func<T3, T4, T5, T6, T7, T8, T9, T10, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Func<T4, T5, T6, T7, T8, T9, T10, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3) =>
            new Func<T4, T5, T6, T7, T8, T9, T10, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Func<T5, T6, T7, T8, T9, T10, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Func<T5, T6, T7, T8, T9, T10, TResult>((arg5, arg6, arg7, arg8, arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Func<T6, T7, T8, T9, T10, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Func<T6, T7, T8, T9, T10, TResult>((arg6, arg7, arg8, arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Func<T7, T8, T9, T10, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Func<T7, T8, T9, T10, TResult>((arg7, arg8, arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Func<T8, T9, T10, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Func<T8, T9, T10, TResult>((arg8, arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Func<T9, T10, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            new Func<T9, T10, TResult>((arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Func<T10, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) =>
            new Func<T10, TResult>((arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));


        public Func<TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) =>
            new Func<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)); public TResult Apply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) =>
          function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function) =>
            function.function;

        public static implicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> operator +(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> fun2) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(fun1.function + fun2.function);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> operator -(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> fun2) =>
            fun1.function - fun2.function;

        public static bool operator ==(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> fun2) =>
            fun1.function == fun2.function;

        public static bool operator !=(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> fun2) =>
            fun1.function != fun2.function;

        public override bool Equals(object obj) =>
            function.Equals(obj);

        public static explicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> funcExp) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(funcExp.Compile());

        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }

    public class Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function { get; }

        #region Types
        public Type T1Type
        {
            get
            {
                return typeof(T1);
            }
        }

        public Type T2Type
        {
            get
            {
                return typeof(T2);
            }
        }

        public Type T3Type
        {
            get
            {
                return typeof(T3);
            }
        }

        public Type T4Type
        {
            get
            {
                return typeof(T4);
            }
        }

        public Type T5Type
        {
            get
            {
                return typeof(T5);
            }
        }

        public Type T6Type
        {
            get
            {
                return typeof(T6);
            }
        }

        public Type T7Type
        {
            get
            {
                return typeof(T7);
            }
        }

        public Type T8Type
        {
            get
            {
                return typeof(T8);
            }
        }

        public Type T9Type
        {
            get
            {
                return typeof(T9);
            }
        }

        public Type T10Type
        {
            get
            {
                return typeof(T10);
            }
        }

        public Type T11Type
        {
            get
            {
                return typeof(T11);
            }
        }       

        public Type TResultType
        {
            get
            {
                return typeof(TResult);
            }
        }
        public Type[] Parameters
        {
            get
            {
                return new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11) };
            }
        }
        #endregion

        public Function(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> _func)
        {
            function = _func;
        }        

        public Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> PartiallyApply() =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Function<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> PartiallyApply(T1 arg1) =>
            new Function<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Function<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> PartiallyApply(T1 arg1, T2 arg2) =>
            new Function<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Function<T4, T5, T6, T7, T8, T9, T10, T11, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3) =>
            new Function<T4, T5, T6, T7, T8, T9, T10, T11, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Function<T5, T6, T7, T8, T9, T10, T11, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Function<T5, T6, T7, T8, T9, T10, T11, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Function<T6, T7, T8, T9, T10, T11, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Function<T6, T7, T8, T9, T10, T11, TResult>((arg6, arg7, arg8, arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Function<T7, T8, T9, T10, T11, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Function<T7, T8, T9, T10, T11, TResult>((arg7, arg8, arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Function<T8, T9, T10, T11, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Function<T8, T9, T10, T11, TResult>((arg8, arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Function<T9, T10, T11, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            new Function<T9, T10, T11, TResult>((arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Function<T10, T11, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) =>
            new Function<T10, T11, TResult>((arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Function<T11, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) =>
            new Function<T11, TResult>((arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Function<TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) =>
            new Function<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> PartiallyApplyAsFunc() =>
            new Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> PartiallyApplyAsFunc(T1 arg1) =>
            new Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2) =>
            new Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Func<T4, T5, T6, T7, T8, T9, T10, T11, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3) =>
            new Func<T4, T5, T6, T7, T8, T9, T10, T11, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Func<T5, T6, T7, T8, T9, T10, T11, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Func<T5, T6, T7, T8, T9, T10, T11, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Func<T6, T7, T8, T9, T10, T11, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Func<T6, T7, T8, T9, T10, T11, TResult>((arg6, arg7, arg8, arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Func<T7, T8, T9, T10, T11, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Func<T7, T8, T9, T10, T11, TResult>((arg7, arg8, arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Func<T8, T9, T10, T11, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Func<T8, T9, T10, T11, TResult>((arg8, arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Func<T9, T10, T11, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            new Func<T9, T10, T11, TResult>((arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Func<T10, T11, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) =>
            new Func<T10, T11, TResult>((arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Func<T11, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) =>
            new Func<T11, TResult>((arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));


        public Func<TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) =>
            new Func<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11)); public TResult Apply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) =>
          function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function) =>
            function.function;

        public static implicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> operator +(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> fun2) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(fun1.function + fun2.function);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> operator -(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> fun2) =>
            fun1.function - fun2.function;

        public static bool operator ==(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> fun2) =>
            fun1.function == fun2.function;

        public static bool operator !=(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> fun2) =>
            fun1.function != fun2.function;

        public override bool Equals(object obj) =>
            function.Equals(obj);

        public static explicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> funcExp) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(funcExp.Compile());

        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }

    public class Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function { get; }

        #region Types
        public Type T1Type
        {
            get
            {
                return typeof(T1);
            }
        }

        public Type T2Type
        {
            get
            {
                return typeof(T2);
            }
        }

        public Type T3Type
        {
            get
            {
                return typeof(T3);
            }
        }

        public Type T4Type
        {
            get
            {
                return typeof(T4);
            }
        }

        public Type T5Type
        {
            get
            {
                return typeof(T5);
            }
        }

        public Type T6Type
        {
            get
            {
                return typeof(T6);
            }
        }

        public Type T7Type
        {
            get
            {
                return typeof(T7);
            }
        }

        public Type T8Type
        {
            get
            {
                return typeof(T8);
            }
        }

        public Type T9Type
        {
            get
            {
                return typeof(T9);
            }
        }

        public Type T10Type
        {
            get
            {
                return typeof(T10);
            }
        }

        public Type T11Type
        {
            get
            {
                return typeof(T11);
            }
        }

        public Type T12Type
        {
            get
            {
                return typeof(T12);
            }
        }

        public Type TResultType
        {
            get
            {
                return typeof(TResult);
            }
        }
        public Type[] Parameters
        {
            get
            {
                return new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12) };
            }
        }
        #endregion

        public Function(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> _func)
        {
            function = _func;
        }        

        public Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> PartiallyApply() =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Function<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> PartiallyApply(T1 arg1) =>
            new Function<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Function<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> PartiallyApply(T1 arg1, T2 arg2) =>
            new Function<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Function<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3) =>
            new Function<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Function<T5, T6, T7, T8, T9, T10, T11, T12, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Function<T5, T6, T7, T8, T9, T10, T11, T12, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Function<T6, T7, T8, T9, T10, T11, T12, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Function<T6, T7, T8, T9, T10, T11, T12, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Function<T7, T8, T9, T10, T11, T12, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Function<T7, T8, T9, T10, T11, T12, TResult>((arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Function<T8, T9, T10, T11, T12, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Function<T8, T9, T10, T11, T12, TResult>((arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Function<T9, T10, T11, T12, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            new Function<T9, T10, T11, T12, TResult>((arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Function<T10, T11, T12, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) =>
            new Function<T10, T11, T12, TResult>((arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Function<T11, T12, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) =>
            new Function<T11, T12, TResult>((arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Function<T12, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) =>
            new Function<T12, TResult>((arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Function<TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) =>
            new Function<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> PartiallyApplyAsFunc() =>
            new Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> PartiallyApplyAsFunc(T1 arg1) =>
            new Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2) =>
            new Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3) =>
            new Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Func<T5, T6, T7, T8, T9, T10, T11, T12, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Func<T5, T6, T7, T8, T9, T10, T11, T12, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Func<T6, T7, T8, T9, T10, T11, T12, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Func<T6, T7, T8, T9, T10, T11, T12, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Func<T7, T8, T9, T10, T11, T12, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Func<T7, T8, T9, T10, T11, T12, TResult>((arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Func<T8, T9, T10, T11, T12, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Func<T8, T9, T10, T11, T12, TResult>((arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Func<T9, T10, T11, T12, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            new Func<T9, T10, T11, T12, TResult>((arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Func<T10, T11, T12, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) =>
            new Func<T10, T11, T12, TResult>((arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Func<T11, T12, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) =>
            new Func<T11, T12, TResult>((arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Func<T12, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) =>
            new Func<T12, TResult>((arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));


        public Func<TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) =>
            new Func<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)); public TResult Apply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) =>
          function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function) =>
            function.function;

        public static implicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> operator +(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> fun2) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(fun1.function + fun2.function);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> operator -(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> fun2) =>
            fun1.function - fun2.function;

        public static bool operator ==(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> fun2) =>
            fun1.function == fun2.function;

        public static bool operator !=(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> fun2) =>
            fun1.function != fun2.function;

        public override bool Equals(object obj) =>
            function.Equals(obj);

        public static explicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> funcExp) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(funcExp.Compile());

        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }

    public class Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function { get; }

        #region Types
        public Type T1Type
        {
            get
            {
                return typeof(T1);
            }
        }

        public Type T2Type
        {
            get
            {
                return typeof(T2);
            }
        }

        public Type T3Type
        {
            get
            {
                return typeof(T3);
            }
        }

        public Type T4Type
        {
            get
            {
                return typeof(T4);
            }
        }

        public Type T5Type
        {
            get
            {
                return typeof(T5);
            }
        }

        public Type T6Type
        {
            get
            {
                return typeof(T6);
            }
        }

        public Type T7Type
        {
            get
            {
                return typeof(T7);
            }
        }

        public Type T8Type
        {
            get
            {
                return typeof(T8);
            }
        }

        public Type T9Type
        {
            get
            {
                return typeof(T9);
            }
        }

        public Type T10Type
        {
            get
            {
                return typeof(T10);
            }
        }

        public Type T11Type
        {
            get
            {
                return typeof(T11);
            }
        }

        public Type T12Type
        {
            get
            {
                return typeof(T12);
            }
        }

        public Type T13Type
        {
            get
            {
                return typeof(T13);
            }
        }
        
        public Type TResultType
        {
            get
            {
                return typeof(TResult);
            }
        }
        public Type[] Parameters
        {
            get
            {
                return new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13) };
            }
        }
        #endregion

        public Function(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> _func)
        {
            function = _func;
        }
        public Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApply() =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Function<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApply(T1 arg1) =>
            new Function<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Function<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApply(T1 arg1, T2 arg2) =>
            new Function<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Function<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3) =>
            new Function<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Function<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Function<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Function<T6, T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Function<T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Function<T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Function<T7, T8, T9, T10, T11, T12, T13, TResult>((arg7, arg8, arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Function<T8, T9, T10, T11, T12, T13, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Function<T8, T9, T10, T11, T12, T13, TResult>((arg8, arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Function<T9, T10, T11, T12, T13, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            new Function<T9, T10, T11, T12, T13, TResult>((arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Function<T10, T11, T12, T13, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) =>
            new Function<T10, T11, T12, T13, TResult>((arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Function<T11, T12, T13, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) =>
            new Function<T11, T12, T13, TResult>((arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Function<T12, T13, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) =>
            new Function<T12, T13, TResult>((arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Function<T13, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) =>
            new Function<T13, TResult>((arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Function<TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) =>
            new Function<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApplyAsFunc() =>
            new Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApplyAsFunc(T1 arg1) =>
            new Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2) =>
            new Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3) =>
            new Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Func<T6, T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Func<T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Func<T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Func<T7, T8, T9, T10, T11, T12, T13, TResult>((arg7, arg8, arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Func<T8, T9, T10, T11, T12, T13, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Func<T8, T9, T10, T11, T12, T13, TResult>((arg8, arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Func<T9, T10, T11, T12, T13, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            new Func<T9, T10, T11, T12, T13, TResult>((arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Func<T10, T11, T12, T13, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) =>
            new Func<T10, T11, T12, T13, TResult>((arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Func<T11, T12, T13, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) =>
            new Func<T11, T12, T13, TResult>((arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Func<T12, T13, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) =>
            new Func<T12, T13, TResult>((arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Func<T13, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) =>
            new Func<T13, TResult>((arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));


        public Func<TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) =>
            new Func<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13)); public TResult Apply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) =>
          function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function) =>
            function.function;

        public static implicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> operator +(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> fun2) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(fun1.function + fun2.function);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> operator -(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> fun2) =>
            fun1.function - fun2.function;

        public static bool operator ==(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> fun2) =>
            fun1.function == fun2.function;

        public static bool operator !=(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> fun2) =>
            fun1.function != fun2.function;

        public override bool Equals(object obj) =>
            function.Equals(obj);

        public static explicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> funcExp) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(funcExp.Compile());


        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }

    public class Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function { get; }

        #region Types
        public Type T1Type
        {
            get
            {
                return typeof(T1);
            }
        }

        public Type T2Type
        {
            get
            {
                return typeof(T2);
            }
        }

        public Type T3Type
        {
            get
            {
                return typeof(T3);
            }
        }

        public Type T4Type
        {
            get
            {
                return typeof(T4);
            }
        }

        public Type T5Type
        {
            get
            {
                return typeof(T5);
            }
        }

        public Type T6Type
        {
            get
            {
                return typeof(T6);
            }
        }

        public Type T7Type
        {
            get
            {
                return typeof(T7);
            }
        }

        public Type T8Type
        {
            get
            {
                return typeof(T8);
            }
        }

        public Type T9Type
        {
            get
            {
                return typeof(T9);
            }
        }

        public Type T10Type
        {
            get
            {
                return typeof(T10);
            }
        }

        public Type T11Type
        {
            get
            {
                return typeof(T11);
            }
        }

        public Type T12Type
        {
            get
            {
                return typeof(T12);
            }
        }

        public Type T13Type
        {
            get
            {
                return typeof(T13);
            }
        }

        public Type T14Type
        {
            get
            {
                return typeof(T14);
            }
        }

        public Type TResultType
        {
            get
            {
                return typeof(TResult);
            }
        }
        public Type[] Parameters
        {
            get
            {
                return new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14) };
            }
        }
        #endregion

        public Function(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> _func)
        {
            function = _func;
        }

        public Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApply() =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Function<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApply(T1 arg1) =>
            new Function<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Function<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApply(T1 arg1, T2 arg2) =>
            new Function<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Function<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3) =>
            new Function<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Function<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Function<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Function<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Function<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Function<T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Function<T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Function<T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Function<T8, T9, T10, T11, T12, T13, T14, TResult>((arg8, arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Function<T9, T10, T11, T12, T13, T14, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            new Function<T9, T10, T11, T12, T13, T14, TResult>((arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Function<T10, T11, T12, T13, T14, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) =>
            new Function<T10, T11, T12, T13, T14, TResult>((arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Function<T11, T12, T13, T14, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) =>
            new Function<T11, T12, T13, T14, TResult>((arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Function<T12, T13, T14, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) =>
            new Function<T12, T13, T14, TResult>((arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Function<T13, T14, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) =>
            new Function<T13, T14, TResult>((arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Function<T14, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) =>
            new Function<T14, TResult>((arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Function<TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) =>
            new Function<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApplyAsFunc() =>
            new Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApplyAsFunc(T1 arg1) =>
            new Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2) =>
            new Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3) =>
            new Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Func<T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Func<T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Func<T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Func<T8, T9, T10, T11, T12, T13, T14, TResult>((arg8, arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Func<T9, T10, T11, T12, T13, T14, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            new Func<T9, T10, T11, T12, T13, T14, TResult>((arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Func<T10, T11, T12, T13, T14, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) =>
            new Func<T10, T11, T12, T13, T14, TResult>((arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Func<T11, T12, T13, T14, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) =>
            new Func<T11, T12, T13, T14, TResult>((arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Func<T12, T13, T14, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) =>
            new Func<T12, T13, T14, TResult>((arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Func<T13, T14, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) =>
            new Func<T13, T14, TResult>((arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Func<T14, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) =>
            new Func<T14, TResult>((arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));


        public Func<TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) =>
            new Func<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14)); public TResult Apply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) =>
          function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function) =>
            function.function;

        public static implicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> operator +(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> fun2) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(fun1.function + fun2.function);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> operator -(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> fun2) =>
            fun1.function - fun2.function;

        public static bool operator ==(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> fun2) =>
            fun1.function == fun2.function;

        public static bool operator !=(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> fun2) =>
            fun1.function != fun2.function;

        public override bool Equals(object obj) =>
            function.Equals(obj);

        public static explicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> funcExp) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(funcExp.Compile());


        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }

    public class Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function { get; }

        #region Types
        public Type T1Type
        {
            get
            {
                return typeof(T1);
            }
        }

        public Type T2Type
        {
            get
            {
                return typeof(T2);
            }
        }

        public Type T3Type
        {
            get
            {
                return typeof(T3);
            }
        }

        public Type T4Type
        {
            get
            {
                return typeof(T4);
            }
        }

        public Type T5Type
        {
            get
            {
                return typeof(T5);
            }
        }

        public Type T6Type
        {
            get
            {
                return typeof(T6);
            }
        }

        public Type T7Type
        {
            get
            {
                return typeof(T7);
            }
        }

        public Type T8Type
        {
            get
            {
                return typeof(T8);
            }
        }

        public Type T9Type
        {
            get
            {
                return typeof(T9);
            }
        }

        public Type T10Type
        {
            get
            {
                return typeof(T10);
            }
        }

        public Type T11Type
        {
            get
            {
                return typeof(T11);
            }
        }

        public Type T12Type
        {
            get
            {
                return typeof(T12);
            }
        }

        public Type T13Type
        {
            get
            {
                return typeof(T13);
            }
        }

        public Type T14Type
        {
            get
            {
                return typeof(T14);
            }
        }

        public Type T15Type
        {
            get
            {
                return typeof(T15);
            }
        }
        
        public Type TResultType
        {
            get
            {
                return typeof(TResult);
            }
        }
        public Type[] Parameters
        {
            get
            {
                return new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15) };
            }
        }
        #endregion

        public Function(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> _func)
        {
            function = _func;
        }
   
        public Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApply() =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Function<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApply(T1 arg1) =>
            new Function<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Function<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApply(T1 arg1, T2 arg2) =>
            new Function<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Function<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3) =>
            new Function<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Function<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Function<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Function<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Function<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Function<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Function<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Function<T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Function<T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Function<T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            new Function<T9, T10, T11, T12, T13, T14, T15, TResult>((arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Function<T10, T11, T12, T13, T14, T15, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) =>
            new Function<T10, T11, T12, T13, T14, T15, TResult>((arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Function<T11, T12, T13, T14, T15, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) =>
            new Function<T11, T12, T13, T14, T15, TResult>((arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Function<T12, T13, T14, T15, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) =>
            new Function<T12, T13, T14, T15, TResult>((arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Function<T13, T14, T15, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) =>
            new Function<T13, T14, T15, TResult>((arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Function<T14, T15, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) =>
            new Function<T14, T15, TResult>((arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Function<T15, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) =>
            new Function<T15, TResult>((arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Function<TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) =>
            new Function<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApplyAsFunc() =>
            new Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApplyAsFunc(T1 arg1) =>
            new Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2) =>
            new Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3) =>
            new Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Func<T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            new Func<T9, T10, T11, T12, T13, T14, T15, TResult>((arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Func<T10, T11, T12, T13, T14, T15, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) =>
            new Func<T10, T11, T12, T13, T14, T15, TResult>((arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Func<T11, T12, T13, T14, T15, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) =>
            new Func<T11, T12, T13, T14, T15, TResult>((arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Func<T12, T13, T14, T15, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) =>
            new Func<T12, T13, T14, T15, TResult>((arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Func<T13, T14, T15, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) =>
            new Func<T13, T14, T15, TResult>((arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Func<T14, T15, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) =>
            new Func<T14, T15, TResult>((arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Func<T15, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) =>
            new Func<T15, TResult>((arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));


        public Func<TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) =>
            new Func<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));

        public TResult Apply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) =>
          function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function) =>
            function.function;

        public static implicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> operator +(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> fun2) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(fun1.function + fun2.function);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> operator -(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> fun2) =>
            fun1.function - fun2.function;

        public static bool operator ==(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> fun2) =>
            fun1.function == fun2.function;

        public static bool operator !=(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> fun2) =>
            fun1.function != fun2.function;

        public override bool Equals(object obj) =>
            function.Equals(obj);

        public static explicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> funcExp) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(funcExp.Compile());


        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }

    public class Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function { get; }

        #region Types
        public Type T1Type
        {
            get
            {
                return typeof(T1);
            }
        }

        public Type T2Type
        {
            get
            {
                return typeof(T2);
            }
        }

        public Type T3Type
        {
            get
            {
                return typeof(T3);
            }
        }

        public Type T4Type
        {
            get
            {
                return typeof(T4);
            }
        }

        public Type T5Type
        {
            get
            {
                return typeof(T5);
            }
        }

        public Type T6Type
        {
            get
            {
                return typeof(T6);
            }
        }

        public Type T7Type
        {
            get
            {
                return typeof(T7);
            }
        }

        public Type T8Type
        {
            get
            {
                return typeof(T8);
            }
        }

        public Type T9Type
        {
            get
            {
                return typeof(T9);
            }
        }

        public Type T10Type
        {
            get
            {
                return typeof(T10);
            }
        }

        public Type T11Type
        {
            get
            {
                return typeof(T11);
            }
        }

        public Type T12Type
        {
            get
            {
                return typeof(T12);
            }
        }

        public Type T13Type
        {
            get
            {
                return typeof(T13);
            }
        }

        public Type T14Type
        {
            get
            {
                return typeof(T14);
            }
        }

        public Type T15Type
        {
            get
            {
                return typeof(T15);
            }
        }

        public Type T16Type
        {
            get
            {
                return typeof(T16);
            }
        }
        
        public Type TResultType
        {
            get
            {
                return typeof(TResult);
            }
        }
        public Type[] Parameters
        {
            get
            {
                return new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16) };
            }
        }
        #endregion

        public Function(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> _func)
        {
            function = _func;
        }
        
        public Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply() =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Function<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply(T1 arg1) =>
            new Function<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Function<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply(T1 arg1, T2 arg2) =>
            new Function<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Function<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3) =>
            new Function<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Function<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Function<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Function<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Function<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Function<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Function<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Function<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Function<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Function<T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            new Function<T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Function<T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) =>
            new Function<T10, T11, T12, T13, T14, T15, T16, TResult>((arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Function<T11, T12, T13, T14, T15, T16, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) =>
            new Function<T11, T12, T13, T14, T15, T16, TResult>((arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Function<T12, T13, T14, T15, T16, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) =>
            new Function<T12, T13, T14, T15, T16, TResult>((arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Function<T13, T14, T15, T16, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) =>
            new Function<T13, T14, T15, T16, TResult>((arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Function<T14, T15, T16, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) =>
            new Function<T14, T15, T16, TResult>((arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Function<T15, T16, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) =>
            new Function<T15, T16, TResult>((arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Function<T16, TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) =>
            new Function<T16, TResult>((arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Function<TResult> PartiallyApply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) =>
            new Function<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApplyAsFunc() =>
            new Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApplyAsFunc(T1 arg1) =>
            new Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2) =>
            new Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3) =>
            new Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            new Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            new Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            new Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Func<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            new Func<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Func<T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            new Func<T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Func<T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) =>
            new Func<T10, T11, T12, T13, T14, T15, T16, TResult>((arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Func<T11, T12, T13, T14, T15, T16, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) =>
            new Func<T11, T12, T13, T14, T15, T16, TResult>((arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Func<T12, T13, T14, T15, T16, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) =>
            new Func<T12, T13, T14, T15, T16, TResult>((arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Func<T13, T14, T15, T16, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) =>
            new Func<T13, T14, T15, T16, TResult>((arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Func<T14, T15, T16, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) =>
            new Func<T14, T15, T16, TResult>((arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Func<T15, T16, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) =>
            new Func<T15, T16, TResult>((arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Func<T16, TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) =>
            new Func<T16, TResult>((arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));


        public Func<TResult> PartiallyApplyAsFunc(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) =>
            new Func<TResult>(() => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));

        public TResult Apply(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) =>
          function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function) =>
            function.function;

        public static implicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(func);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> operator +(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> fun2) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(fun1.function + fun2.function);

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> operator -(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> fun2) =>
            fun1.function - fun2.function;

        public static bool operator ==(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> fun2) =>
            fun1.function == fun2.function;

        public static bool operator !=(Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> fun1, Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> fun2) =>
            fun1.function != fun2.function;

        public override bool Equals(object obj) =>
            function.Equals(obj);

        public static explicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> funcExp) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(funcExp.Compile());

        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }

    #endregion 

    /// <summary>
    /// Chains a function's output with a functions input. 
    /// Returns result as a new function.
    /// </summary>
    public static class Chainer
    {
        public static Function<TResult> ChainWith<TLink, TResult>
        (this Function<TLink> headFunction,
        Function<TLink, TResult> tailFunction) =>
           new Function<TResult>(
                () => tailFunction.Apply(headFunction.Apply())
                );

        public static Function<T1, TResult> ChainWith<T1, TLink, TResult>
        (this Function<T1, TLink> headFunction,
        Function<TLink, TResult> tailFunction) =>
           new Function<T1, TResult>(
                (arg1) => tailFunction.Apply(headFunction.Apply(arg1))
                );

        public static Function<T1, T2, TResult> ChainWith<T1, T2, TLink, TResult>
        (this Function<T1, T2, TLink> headFunction,
        Function<TLink, TResult> tailFunction) =>
           new Function<T1, T2, TResult>(
                (agr1, arg2) => tailFunction.Apply(headFunction.Apply(agr1, arg2))
                );

        public static Function<T1, T2, T3, TResult> ChainWith<T1, T2, T3, TLink, TResult>
        (this Function<T1, T2, T3, TLink> headFunction,
        Function<TLink, TResult> tailFunction) =>
           new Function<T1, T2, T3, TResult>(
                (agr1, agr2, arg3) => tailFunction.Apply(headFunction.Apply(agr1, agr2, arg3))
                );

        public static Function<T1, T2, T3, T4, TResult> ChainWith<T1, T2, T3, T4, TLink, TResult>
        (this Function<T1, T2, T3, T4, TLink> headFunction,
        Function<TLink, TResult> tailFunction) =>
           new Function<T1, T2, T3, T4, TResult>(
                (agr1, agr2, agr3, arg4) => tailFunction.Apply(headFunction.Apply(agr1, agr2, agr3, arg4))
                );

        public static Function<T1, T2, T3, T4, T5, TResult> ChainWith<T1, T2, T3, T4, T5, TLink, TResult>
        (this Function<T1, T2, T3, T4, T5, TLink> headFunction,
        Function<TLink, TResult> tailFunction) =>
           new Function<T1, T2, T3, T4, T5, TResult>(
                (agr1, agr2, agr3, agr4, arg5) => tailFunction.Apply(headFunction.Apply(agr1, agr2, agr3, agr4, arg5))
                );

        public static Function<T1, T2, T3, T4, T5, T6, TResult> ChainWith<T1, T2, T3, T4, T5, T6, TLink, TResult>
        (this Function<T1, T2, T3, T4, T5, T6, TLink> headFunction,
        Function<TLink, TResult> tailFunction) =>
           new Function<T1, T2, T3, T4, T5, T6, TResult>(
                (agr1, agr2, agr3, agr4, agr5, arg6) => tailFunction.Apply(headFunction.Apply(agr1, agr2, agr3, agr4, agr5, arg6))
                );

        public static Function<T1, T2, T3, T4, T5, T6, T7, TResult> ChainWith<T1, T2, T3, T4, T5, T6, T7, TLink, TResult>
        (this Function<T1, T2, T3, T4, T5, T6, T7, TLink> headFunction,
        Function<TLink, TResult> tailFunction) =>
           new Function<T1, T2, T3, T4, T5, T6, T7, TResult>(
                (agr1, agr2, agr3, agr4, agr5, agr6, arg7) => tailFunction.Apply(headFunction.Apply(agr1, agr2, agr3, agr4, agr5, agr6, arg7))
                );

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult> ChainWith<T1, T2, T3, T4, T5, T6, T7, T8, TLink, TResult>
        (this Function<T1, T2, T3, T4, T5, T6, T7, T8, TLink> headFunction,
        Function<TLink, TResult> tailFunction) =>
           new Function<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
                (agr1, agr2, agr3, agr4, agr5, agr6, agr7, arg8) => tailFunction.Apply(headFunction.Apply(agr1, agr2, agr3, agr4, agr5, agr6, agr7, arg8))
                );

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> ChainWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLink, TResult>
        (this Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLink> headFunction,
        Function<TLink, TResult> tailFunction) =>
           new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
                (agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, arg9) => tailFunction.Apply(headFunction.Apply(agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, arg9))
                );

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> ChainWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLink, TResult>
        (this Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLink> headFunction,
        Function<TLink, TResult> tailFunction) =>
           new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
                (agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, arg10) => tailFunction.Apply(headFunction.Apply(agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, arg10))
                );

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> ChainWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLink, TResult>
        (this Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLink> headFunction,
        Function<TLink, TResult> tailFunction) =>
           new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
                (agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, arg11) => tailFunction.Apply(headFunction.Apply(agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, arg11))
                );

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> ChainWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLink, TResult>
        (this Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLink> headFunction,
        Function<TLink, TResult> tailFunction) =>
           new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
                (agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, arg12) => tailFunction.Apply(headFunction.Apply(agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, arg12))
                );

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> ChainWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLink, TResult>
        (this Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLink> headFunction,
        Function<TLink, TResult> tailFunction) =>
           new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
                (agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, agr12, arg13) => tailFunction.Apply(headFunction.Apply(agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, agr12, arg13))
                );

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> ChainWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLink, TResult>
        (this Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLink> headFunction,
        Function<TLink, TResult> tailFunction) =>
           new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
                (agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, agr12, agr13, arg14) => tailFunction.Apply(headFunction.Apply(agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, agr12, agr13, arg14))
                );

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> ChainWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLink, TResult>
        (this Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLink> headFunction,
        Function<TLink, TResult> tailFunction) =>
           new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
                (agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, agr12, agr13, agr14, arg15) => tailFunction.Apply(headFunction.Apply(agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, agr12, agr13, agr14, arg15))
                );

        public static Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> ChainWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TLink, TResult>
        (this Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TLink> headFunction,
        Function<TLink, TResult> tailFunction) =>
           new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
                (agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, agr12, agr13, agr14, agr15, arg16) => tailFunction.Apply(headFunction.Apply(agr1, agr2, agr3, agr4, agr5, agr6, agr7, agr8, agr9, agr10, agr11, agr12, agr13, agr14, agr15, arg16))
                );
    }
}

