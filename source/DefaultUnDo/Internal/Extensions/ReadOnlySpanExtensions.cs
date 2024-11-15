namespace System;

internal static class ReadOnlySpanExtensions
{
    public static bool Any<T>(this ReadOnlySpan<T> source, Predicate<T> predicate)
    {
        foreach (ref readonly T item in source)
        {
            if (predicate(item))
            {
                return true;
            }
        }

        return false;
    }
}
