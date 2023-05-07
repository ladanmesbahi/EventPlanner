using Domain.Infrastructure;

namespace Domain.ValueObjects
{
    public sealed class Email : ValueObject
    {
        public Email(string value)
        {
            Value = value;
        }
        public string Value { get; }

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
