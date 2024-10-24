using DefaultUnDo;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.UnDoFieldTests;

public sealed class ValueShould
{
    [Fact]
    public void SetValue()
    {
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        object value = new();
        object newValue = new();
        UnDoField<object> field = new(manager, value);

        Check.That(field.Value).IsEqualTo(value);

        field.Value = newValue;

        Check.That(field.Value).IsEqualTo(newValue);
    }

    [Fact]
    public void GenerateDescription()
    {
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        UnDoFieldChange<object>? description = null;

        object value = new();
        UnDoField<object> field = new(manager, d => description = d)
        {
            Value = value
        };

        Check.That(description.HasValue).IsTrue();
        Check.That(description.Value.OldValue).IsNull();
        Check.That(description.Value.NewValue).IsEqualTo(value);
    }
}
