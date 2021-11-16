using System.Diagnostics.CodeAnalysis;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides a method to try to merge two <see cref="IUnDo"/> instances into a single one.
    /// </summary>
    public interface IMergeableUnDo : IUnDo
    {
        /// <summary>
        /// Merges the current instance with the specified <see cref="IUnDo"/>.
        /// </summary>
        /// <param name="other">The other <see cref="IUnDo"/> instance the current one should try to merge with.</param>
        /// <param name="mergedCommand">The resulting merged <see cref="IUnDo"/> instance if the operation was successful.</param>
        /// <returns>true if the merge was successful; otherwise false.</returns>
        bool TryMerge(IUnDo other, [NotNullWhen(true)] out IUnDo? mergedCommand);
    }
}
