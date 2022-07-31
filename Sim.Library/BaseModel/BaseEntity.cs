using Sim.Library.Connector;
using Sim.Library.Helper;

namespace Sim.Library.BaseModel
{
    public abstract class BaseEntity : BaseModel
    {
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

        public BaseEntity()
        {
            _mapServiceNew();
        }
        protected static T1 New<T1, T2>(T2 model)
        {
            _mapServiceNew();
            return _mapService.Map<T1, T2>(model);
        }
        static void _mapServiceNew()
        {
            if (_mapService == null)
                _mapService = ServiceProviderFactory.GetInstance<Sim.Library.Connector.IMapService>();
        }

        protected static IMapService _mapService;

    }
    public class BaseEntity<IDataCommands> : BaseEntity
    {
        protected BaseEntity() : base()
        {
            if (_commands == null)
                _commands = ServiceProviderFactory.GetInstance<IDataCommands>();
        }
        protected readonly IDataCommands _commands;
    }
}
