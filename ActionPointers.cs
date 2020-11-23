using System.Reflection;

namespace FunctionPointers
{
    public unsafe readonly struct ActionPointer
    {
        private readonly delegate*<void> _ptr;
        public ActionPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<void>)methodInfo.MethodHandle.GetFunctionPointer();
        public void Invoke() => _ptr();
    }

    public unsafe readonly struct ActionPointer<T>
    {
        private readonly delegate*<T, void> _ptr;
        public ActionPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T, void>)methodInfo.MethodHandle.GetFunctionPointer();
        public void Invoke(T obj) => _ptr(obj);
    }

    public unsafe readonly struct ActionPointer<T1, T2>
    {
        private readonly delegate*<T1, T2, void> _ptr;
        public ActionPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T1, T2, void>)methodInfo.MethodHandle.GetFunctionPointer();
        public void Invoke(T1 arg1, T2 arg2) => _ptr(arg1, arg2);
    }

    public unsafe readonly struct ActionPointer<T1, T2, T3>
    {
        private readonly delegate*<T1, T2, T3, void> _ptr;
        public ActionPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T1, T2, T3, void>)methodInfo.MethodHandle.GetFunctionPointer();
        public void Invoke(T1 arg1, T2 arg2, T3 arg3) => _ptr(arg1, arg2, arg3);
    }

    public unsafe readonly struct ActionPointer<T1, T2, T3, T4>
    {
        private readonly delegate*<T1, T2, T3, T4, void> _ptr;
        public ActionPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T1, T2, T3, T4, void>)methodInfo.MethodHandle.GetFunctionPointer();
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) => _ptr(arg1, arg2, arg3, arg4);
    }

    public unsafe readonly struct ActionPointer<T1, T2, T3, T4, T5>
    {
        private readonly delegate*<T1, T2, T3, T4, T5, void> _ptr;
        public ActionPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T1, T2, T3, T4, T5, void>)methodInfo.MethodHandle.GetFunctionPointer();
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => _ptr(arg1, arg2, arg3, arg4, arg5);
    }

    public unsafe readonly struct ActionPointer<T1, T2, T3, T4, T5, T6>
    {
        private readonly delegate*<T1, T2, T3, T4, T5, T6, void> _ptr;
        public ActionPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T1, T2, T3, T4, T5, T6, void>)methodInfo.MethodHandle.GetFunctionPointer();
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => _ptr(arg1, arg2, arg3, arg4, arg5, arg6);
    }

    public unsafe readonly struct ActionPointer<T1, T2, T3, T4, T5, T6, T7>
    {
        private readonly delegate*<T1, T2, T3, T4, T5, T6, T7, void> _ptr;
        public ActionPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T1, T2, T3, T4, T5, T6, T7, void>)methodInfo.MethodHandle.GetFunctionPointer();
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) => _ptr(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    public unsafe readonly struct ActionPointer<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        private readonly delegate*<T1, T2, T3, T4, T5, T6, T7, T8, void> _ptr;
        public ActionPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T1, T2, T3, T4, T5, T6, T7, T8, void>)methodInfo.MethodHandle.GetFunctionPointer();
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) => _ptr(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    public unsafe readonly struct ActionPointer<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        private readonly delegate*<T1, T2, T3, T4, T5, T6, T7, T8, T9, void> _ptr;
        public ActionPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T1, T2, T3, T4, T5, T6, T7, T8, T9, void>)methodInfo.MethodHandle.GetFunctionPointer();
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) => _ptr(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    public unsafe readonly struct ActionPointer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        private readonly delegate*<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void> _ptr;
        public ActionPointer(MethodInfo methodInfo)
            => _ptr = (delegate*<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>)methodInfo.MethodHandle.GetFunctionPointer();
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) => _ptr(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
    }
}
