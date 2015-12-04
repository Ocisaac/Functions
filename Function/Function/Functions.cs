using System;

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

