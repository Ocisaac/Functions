using System;
using System.Linq.Expressions;

namespace Functions
{
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
}
