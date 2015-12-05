using System;
using System.Linq.Expressions;

namespace Functions
{
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
            function.Equals((obj as Function<T1, T2, TResult>).function);

        public static explicit operator Function<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> funcExp) =>
            new Function<T1, T2, TResult>(funcExp.Compile());

        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }
}
