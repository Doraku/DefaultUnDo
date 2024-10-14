#if !NET5_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Collections.Generic;

internal static class IEnumerableExtensions
{
    public static IEnumerable<T> Order<T>(this IEnumerable<T> source) => source.OrderBy(item => item);
}

#endif