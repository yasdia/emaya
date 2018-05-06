using System;
using Yasm.Dao.Model;
using System.Collections.Generic;
using System.Linq;
using Yasm.Dao.Repos.Generic;

namespace Yasm.Dao.Repos
{
    public class UserRepository: GenericRepository<MyDbContext, User>
    {
        public User FindById(int id)
        {
            return Context.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
