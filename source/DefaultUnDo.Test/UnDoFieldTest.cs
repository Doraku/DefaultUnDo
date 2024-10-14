using System;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo;

public sealed class UnDoFieldTest
{
    [Fact]
    public void UnDoField_Should_throw_ArgumentNullException_When_manager_is_null()
    {
        Check
            .ThatCode(() => new UnDoField<object>(null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "manager");
    }

    [Fact]
    public void Value_Should_set_value()
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
    public void Value_Should_generate_description()
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

    [Fact]
    public void Implicit_Should_return_value()
    {
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        const int value = 42;
        int currentValue = new UnDoField<int>(manager, value);

        Check.That(currentValue).IsEqualTo(value);
    }

    [Fact]
    public void Implicit_Should_return_default_When_null()
    {
        Check.That<int>(default).IsEqualTo((int)default(UnDoField<int>));
    }
}
