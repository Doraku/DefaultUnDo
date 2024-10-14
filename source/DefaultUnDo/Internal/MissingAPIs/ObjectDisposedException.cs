#if !NET5_0_OR_GREATER

global using ObjectDisposedException = DefaultUnDo.ObjectDisposedException;

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace DefaultUnDo;
#pragma warning restore IDE0130 // Namespace does not match folder structure

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

#endif
