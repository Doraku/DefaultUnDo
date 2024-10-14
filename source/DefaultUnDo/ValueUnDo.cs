using System;
using System.Diagnostics.CodeAnalysis;

namespace DefaultUnDo;

/// <summary>
/// Provides a global <see cref="TimeSpan"/> to use as default merge interval for all <see cref="ValueUnDo{T}"/>.
/// </summary>
public static class ValueUnDo
{
    /// <summary>
    /// Represents a method that will be called when merging two <see cref="ValueUnDo{T}"/> instances to get the resulting description.
    /// </summary>
    /// <param name="oldDescription">The description of the previous <see cref="ValueUnDo{T}"/> merged.</param>
    /// <param name="newDescription">The description of the new <see cref="ValueUnDo{T}"/> merged.</param>
    public delegate object? MergeDescriptionHandler(object? oldDescription, object? newDescription);

    /// <summary>
    /// The <see cref="TimeSpan"/> interval equivalent <see cref="ValueUnDo{T}"/> instances should respect to be mergeable.
    /// Default value is 500ms.
    /// </summary>
    public static TimeSpan MergeInterval { get; set; } = TimeSpan.FromMilliseconds(500);

    /// <summary>
    /// The <see cref="MergeDescriptionHandler"/> used to merge description between two <see cref="ValueUnDo{T}"/> instance.
    /// </summary>
    public static MergeDescriptionHandler? MergeDescriptionAction { get; set; }
}

/// <summary>
/// Provides an implementation of the <see cref="IUnDo"/> interface for setting value.
/// </summary>
/// <typeparam name="T">The type of value.</typeparam>
public sealed class ValueUnDo<T> : IMergeableUnDo
{
    /// <summary>
    /// Represents a method that will be called when merging two <see cref="ValueUnDo{T}"/> instances to get the resulting description.
    /// </summary>
    /// <param name="oldDescription">The description of the previous <see cref="ValueUnDo{T}"/> merged.</param>
    /// <param name="oldValue">The old value used when undoing the resulting merged <see cref="ValueUnDo{T}"/>.</param>
    /// <param name="newDescription">The description of the new <see cref="ValueUnDo{T}"/> merged.</param>
    /// <param name="newValue">The new value used when redoing the resulting merged <see cref="ValueUnDo{T}"/>.</param>
    /// <returns>The new description that will be using for the resulting merged <see cref="ValueUnDo{T}"/>.</returns>
    public delegate object MergeDescriptionHandler(object? oldDescription, T oldValue, object? newDescription, T newValue);

    private readonly DateTime _timeStamp;
    private readonly object? _description;
    private readonly Action<T> _setter;
    [AllowNull]
    private readonly T _newValue;
    [AllowNull]
    private readonly T _oldValue;

    /// <summary>
    /// The <see cref="TimeSpan"/> interval equivalent <see cref="ValueUnDo{T}"/> instances should respect to be mergeable.
    /// If not set, <see cref="ValueUnDo.MergeInterval"/> will be used.
    /// </summary>
    public static TimeSpan? MergeInterval { get; set; }

    /// <summary>
    /// The <see cref="MergeDescriptionHandler"/> used to merge description between two <see cref="ValueUnDo{T}"/> instance.
    /// </summary>
    public static MergeDescriptionHandler? MergeDescriptionAction { get; set; }

    /// <summary>
    /// Initialises an instance of <see cref="ValueUnDo{T}"/>.
    /// </summary>
    /// <param name="description">The description of this <see cref="IUnDo"/></param>
    /// <param name="setter">The action called to set the value.</param>
    /// <param name="newValue">The new value.</param>
    /// <param name="oldValue">The old value.</param>
    /// <exception cref="ArgumentNullException"><paramref name="setter"/> is null.</exception>
    public ValueUnDo(object? description, Action<T> setter, [AllowNull] T newValue, [AllowNull] T oldValue)
    {
        ArgumentNullException.ThrowIfNull(setter);

        _timeStamp = DateTime.Now;
        _description = description;
        _setter = setter;
        _newValue = newValue;
        _oldValue = oldValue;
    }

    /// <summary>
    /// Initialises an instance of <see cref="ValueUnDo{T}"/>.
    /// </summary>
    /// <param name="setter">The action called to set the value.</param>
    /// <param name="newValue">The new value.</param>
    /// <param name="oldValue">The old value.</param>
    /// <exception cref="ArgumentNullException"><paramref name="setter"/> is null.</exception>
    public ValueUnDo(Action<T> setter, T newValue, T oldValue)
        : this(null, setter, newValue, oldValue)
    { }

    #region IMergeableUnDo

    /// <inheritdoc />
    bool IMergeableUnDo.TryMerge(IUnDo other, [NotNullWhen(true)] out IUnDo? mergedCommand)
    {
        mergedCommand =
            (other is ValueUnDo<T> value || (other is GroupUnDo group && group.TryGetSingle(out value)))
                && _setter == value._setter
                && Equals(_newValue, value._oldValue)
                && (value._timeStamp - _timeStamp) < (MergeInterval ?? ValueUnDo.MergeInterval)
            ? new ValueUnDo<T>(
                MergeDescriptionAction?.Invoke(_description, _oldValue, value._description, value._newValue)
                    ?? ValueUnDo.MergeDescriptionAction?.Invoke(_description, value._description)
                    ?? value._description,
                _setter,
                value._newValue,
                _oldValue)
            : null;

        return mergedCommand != null;
    }

    #endregion

    #region IUnDo

    /// <inheritdoc />
    object? IUnDo.Description => _description;

    /// <inheritdoc />
    void IUnDo.Do() => _setter.Invoke(_newValue);

    /// <inheritdoc />
    void IUnDo.Undo() => _setter.Invoke(_oldValue);

    #endregion
}
