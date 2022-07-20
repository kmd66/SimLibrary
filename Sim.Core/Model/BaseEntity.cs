using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim.Core.Model
{
    public class Entity
    {
        public Guid UnicId { get; set; }

        public bool Equals(Entity? other)
        => this == other;
        public override bool Equals(object? obj)
        {
            return obj is Entity otherObject && UnicId == otherObject.UnicId;
        }
        public override int GetHashCode()
        {
            return UnicId.GetHashCode();
        }
        public static bool operator ==(Entity left, Entity right)
        {
            if (left is null && right is null)
                return true;

            if (left is null || right is null)
                return false;

            return left.Equals(right);
        }

        public static bool operator !=(Entity left, Entity right)
            => !(right == left);


    }
}
