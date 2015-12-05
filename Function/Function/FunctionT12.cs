using System;
using System.Linq.Expressions;

namespace Functions
{
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
            function.Equals((obj as Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>).function);

        public static explicit operator Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> funcExp) =>
            new Function<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(funcExp.Compile());

        public override string ToString() =>
            function.ToString();

        public override int GetHashCode() =>
            function.GetHashCode();
    }
}
