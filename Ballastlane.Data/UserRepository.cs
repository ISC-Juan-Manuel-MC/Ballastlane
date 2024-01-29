using Ballastlane.Models;

namespace Ballastlane.Data
{
    public class UserRepository : IAdd<User>, IUpdate<User>, IDeactivate<string>, IGet<User, string>
    {
        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Deactivate(string Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
