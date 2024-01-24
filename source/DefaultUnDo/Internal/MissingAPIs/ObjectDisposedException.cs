#if !NET5_0_OR_GREATER

global using ObjectDisposedException = DefaultUnDo.ObjectDisposedException;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DefaultUnDo
{
    internal static class ObjectDisposedException
    {
        [StackTraceHidden]
        public static void ThrowIf([DoesNotReturnIf(true)] bool condition, object instance)
        {
            if (condition)
            {
                throw new System.ObjectDisposedException(instance?.GetType().FullName);
            }
        }

        [StackTraceHidden]
        public static void ThrowIf([DoesNotReturnIf(true)] bool condition, Type type)
        {
            if (condition)
            {
                throw new System.ObjectDisposedException(type?.FullName);
            }
        }
    }
}

#endif
