namespace DefaultUnDo;

/// <summary>
/// Describes a value change operation done on a <see cref="UnDoField{T}"/>.
/// </summary>
/// <typeparam name="T">The type of the field.</typeparam>
/// <param name="OldValue">The field old value.</param>
/// <param name="NewValue">The field new value.</param>
public readonly record struct UnDoFieldChange<T>(
    T? OldValue,
    T? NewValue);
