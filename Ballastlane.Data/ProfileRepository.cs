using Ballastlane.Models;

namespace Ballastlane.Data
{
    public class ProfileRepository : IAdd<Profile>, IUpdate<Profile>, IDelete<Guid>, IGet<Profile, Guid>
    {
        public void Add(Profile entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Profile> GetAll()
        {
            throw new NotImplementedException();
        }

        public Profile GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Profile GetByEmail(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Profile entity)
        {
            throw new NotImplementedException();
        }
    }
}
