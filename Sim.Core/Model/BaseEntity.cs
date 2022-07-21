using Sim.Core.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim.Core.Model
{
    public class BaseEntity
    {

        public Guid UnicId { get; set; }
        public int Id { get; set; }

        public bool Equals(BaseEntity? other)
        => this == other;
        public override bool Equals(object? obj)
        {
            return obj is BaseEntity otherObject && UnicId == otherObject.UnicId;
        }
        public override int GetHashCode()
        {
            return UnicId.GetHashCode();
        }
        public static bool operator ==(BaseEntity left, BaseEntity right)
        {
            if (left is null && right is null)
                return true;

            if (left is null || right is null)
                return false;

            return left.Equals(right);
        }

        public static bool operator !=(BaseEntity left, BaseEntity right)
            => !(right == left);


    }
}
