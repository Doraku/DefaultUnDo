using System;
using System.Diagnostics.CodeAnalysis;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides a simple wrapper for a field to automatically generate <see cref="IUnDo"/> operations.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class UnDoField<T>
        where T : notnull
    {
        private readonly IUnDoManager _manager;
        private readonly Func<UnDoFieldChange<T>, object?>? _descriptionFactory;

        [AllowNull]
        private T _value;

        /// <summary>
        /// Gets or sets the value of the field, generating a <see cref="IUnDo"/> operation on set.
        /// </summary>
        [AllowNull]
        public T Value
        {
            get => _value;
            set => _manager.Do(Set, value, _value, _descriptionFactory?.Invoke(new UnDoFieldChange<T>(_value, value)));
        }

        /// <summary>
        /// Creates a new instance of <see cref="UnDoField{T}"/>.
        /// </summary>
        /// <param name="manager">The <see cref="IUnDoManager"/> used to register the <see cref="IUnDo"/> operations.</param>
        /// <param name="value">The starting value of the <see cref="UnDoField{T}"/></param>
        /// <param name="descriptionFactory">Factory used to create the description of the generated <see cref="IUnDo"/>.</param>
        /// <exception cref="ArgumentNullException"><paramref name="manager"/> is null.</exception>
        public UnDoField(IUnDoManager manager, [AllowNull] T value, Func<UnDoFieldChange<T>, object?>? descriptionFactory = null)
        {
            _manager = manager ?? throw new ArgumentNullException(nameof(manager));
            _descriptionFactory = descriptionFactory;

            _value = value;
        }

        /// <summary>
        /// Creates a new instance of <see cref="UnDoField{T}"/>.
        /// </summary>
        /// <param name="manager">The <see cref="IUnDoManager"/> used to register the <see cref="IUnDo"/> operations.</param>
        /// <param name="descriptionFactory">Factory used to create the description of the generated <see cref="IUnDo"/>.</param>
        /// <exception cref="ArgumentNullException"><paramref name="manager"/> is null.</exception>
        public UnDoField(IUnDoManager manager, Func<UnDoFieldChange<T>, object?>? descriptionFactory = null)
            : this(manager, default, descriptionFactory)
        { }

        private void Set([AllowNull] T value)
        {
            PreSet(value);

            T oldValue = _value;
            _value = value;

            PostSet(oldValue);
        }

        /// <summary>
        /// Performs a pre set treatment, included in the <see cref="IUnDo"/> operation.
        /// </summary>
        /// <param name="newValue">The new value.</param>
        protected virtual void PreSet([AllowNull] T newValue)
        { }

        /// <summary>
        /// performs a post set treatment, included in the <see cref="IUnDo"/> operation.
        /// </summary>
        /// <param name="oldValue">The old value.</param>
        protected virtual void PostSet([AllowNull] T oldValue)
        { }

        /// <summary>
        ///Defines an implicit conversion of a <see cref="UnDoField{T}"/> to a <typeparamref name="T"/>.
        /// </summary>
        /// <param name="field"></param>
        [return: MaybeNull]
        public static implicit operator T(UnDoField<T> field) => field is null ? default : field.ToT();

        /// <summary>
        /// Returns the underlying <typeparamref name="T"/>.
        /// </summary>
        /// <returns>The underlying <typeparamref name="T"/>.</returns>
        [return: MaybeNull]
        public T ToT() => Value;
    }
}
