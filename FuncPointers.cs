using System.Reflection;

namespace FunctionPointers
{
    public unsafe readonly struct FuncPointer<TResult>
    {
        private readonly delegate*<TResult> _ptr;
        public FuncPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<TResult>)methodInfo.MethodHandle.GetFunctionPointer();
        public TResult Invoke() => _ptr();
    }

    public unsafe readonly struct FuncPointer<T, TResult>
    {
        private readonly delegate*<T, TResult> _ptr;
        public FuncPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T, TResult>)methodInfo.MethodHandle.GetFunctionPointer();
        public TResult Invoke(T obj) => _ptr(obj);
    }

    public unsafe readonly struct FuncPointer<T1, T2, TResult>
    {
        private readonly delegate*<T1, T2, TResult> _ptr;
        public FuncPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T1, T2, TResult>)methodInfo.MethodHandle.GetFunctionPointer();
        public TResult Invoke(T1 arg1, T2 arg2) => _ptr(arg1, arg2);
    }

    public unsafe readonly struct FuncPointer<T1, T2, T3, TResult>
    {
        private readonly delegate*<T1, T2, T3, TResult> _ptr;
        public FuncPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T1, T2, T3, TResult>)methodInfo.MethodHandle.GetFunctionPointer();
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3) => _ptr(arg1, arg2, arg3);
    }

    public unsafe readonly struct FuncPointer<T1, T2, T3, T4, TResult>
    {
        private readonly delegate*<T1, T2, T3, T4, TResult> _ptr;
        public FuncPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T1, T2, T3, T4, TResult>)methodInfo.MethodHandle.GetFunctionPointer();
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) => _ptr(arg1, arg2, arg3, arg4);
    }

    public unsafe readonly struct FuncPointer<T1, T2, T3, T4, T5, TResult>
    {
        private readonly delegate*<T1, T2, T3, T4, T5, TResult> _ptr;
        public FuncPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T1, T2, T3, T4, T5, TResult>)methodInfo.MethodHandle.GetFunctionPointer();
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => _ptr(arg1, arg2, arg3, arg4, arg5);
    }

    public unsafe readonly struct FuncPointer<T1, T2, T3, T4, T5, T6, TResult>
    {
        private readonly delegate*<T1, T2, T3, T4, T5, T6, TResult> _ptr;
        public FuncPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T1, T2, T3, T4, T5, T6, TResult>)methodInfo.MethodHandle.GetFunctionPointer();
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => _ptr(arg1, arg2, arg3, arg4, arg5, arg6);
    }

    public unsafe readonly struct FuncPointer<T1, T2, T3, T4, T5, T6, T7, TResult>
    {
        private readonly delegate*<T1, T2, T3, T4, T5, T6, T7, TResult> _ptr;
        public FuncPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T1, T2, T3, T4, T5, T6, T7, TResult>)methodInfo.MethodHandle.GetFunctionPointer();
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) => _ptr(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    public unsafe readonly struct FuncPointer<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
    {
        private readonly delegate*<T1, T2, T3, T4, T5, T6, T7, T8, TResult> _ptr;
        public FuncPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T1, T2, T3, T4, T5, T6, T7, T8, TResult>)methodInfo.MethodHandle.GetFunctionPointer();
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) => _ptr(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    public unsafe readonly struct FuncPointer<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
    {
        private readonly delegate*<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> _ptr;
        public FuncPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>)methodInfo.MethodHandle.GetFunctionPointer();
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) => _ptr(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    public unsafe readonly struct FuncPointer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
    {
        private readonly delegate*<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> _ptr;
        public FuncPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>)methodInfo.MethodHandle.GetFunctionPointer();
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) => _ptr(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
    }
}
