using AES.EF;
using AES.Entities;
using AES.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.Repositories.Impl
{
    class UsersRepository : BaseRepository<Users>, IUsersRepository

    {
        internal UsersRepository(UsersContext context)
 : base(context)
        {
        }

    }
}
