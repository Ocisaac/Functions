using System;
using System.Linq.Expressions;

namespace Functions
{
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
}
