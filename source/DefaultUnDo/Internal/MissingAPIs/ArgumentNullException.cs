#if !NET5_0_OR_GREATER

global using ArgumentNullException = DefaultUnDo.ArgumentNullException;

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace DefaultUnDo;
#pragma warning restore IDE0130 // Namespace does not match folder structure

internal static class ArgumentNullException
{
    [SuppressMessage("Roslynator", "RCS1256:Invalid argument null check", Justification = "it is")]
    public static void ThrowIfNull([NotNull] object? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
    {
        if (argument is null)
        {
            throw new System.ArgumentNullException(paramName);
        }
    }
}

#endif
