using Domain.Infrastructure;

namespace Domain.ValueObjects
{
    public sealed class LastName : ValueObject
    {
        private LastName(string value)
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
