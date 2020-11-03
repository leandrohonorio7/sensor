using domain.entities;
using domain.interfaces;
using infra.context;

namespace infra.repository
{
    public class SensorRepository : RepositoryBase<Sensor>, ISensorRepository
    {
        public SensorRepository(RepositoryContext Context) : base(Context)
        {
        }
    }
}