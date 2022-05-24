using System;
namespace OphelliasOasis.Entity
{
    public class BaseEntity<ET> : IDisposable
    {
        public ET DeepCopy() => (ET)MemberwiseClone();

        public void Dispose() => GC.SuppressFinalize(this);
    }
}
