using System;
using System.Linq.Expressions;

namespace Functions
{
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
            function.Equals((obj as Function<T1, TResult>).function);

        public static explicit operator Function<T1, TResult>(Expression<Func<T1, TResult>> funcExp) =>
            new Function<T1, TResult>(funcExp.Compile());

        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }
}
