using System.Diagnostics.CodeAnalysis;

namespace DefaultUnDo
{
    /// <summary>
    /// Describes a value change operation done on a <see cref="UnDoField{T}"/>.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public readonly struct UnDoFieldChange<T>
    {
        /// <summary>
        /// Gets the field old value.
        /// </summary>
        [AllowNull]
        public T OldValue { get; }

        /// <summary>
        /// Gets the field new value.
        /// </summary>
        [AllowNull]
        public T NewValue { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnDoFieldChange{T}"/> struct.
        /// </summary>
        /// <param name="oldValue">The old value of the field.</param>
        /// <param name="newValue">The new value of the field.</param>
        public UnDoFieldChange([AllowNull] T oldValue, [AllowNull] T newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}
