using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Demo.eShop.Domain.SeedWork
{
    public abstract class ValueObject
    {
        public static bool operator == (ValueObject left, ValueObject right)
        {
            if (ReferenceEquals(left, null) ^ ReferenceEquals(right, null))
            {
                return false;
            }

            return ReferenceEquals(left, null) || left.Equals(right);
        }

        public static bool operator != (ValueObject left, ValueObject right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj == null && obj.GetType() != GetType())
            {
                return false;
            }

            var other = (ValueObject)obj;

            return EqualsCore().SequenceEqual(other.EqualsCore());
        }

        public abstract IEnumerable<object> EqualsCore();

        public override int GetHashCode()
        {
            return GetHashCodeCore();
        }

        public abstract int GetHashCodeCore();
    }
}
