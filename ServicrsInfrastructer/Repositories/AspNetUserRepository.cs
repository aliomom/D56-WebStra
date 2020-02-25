using Domain;
using ServicrsInfrastructer.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicrsInfrastructer.Repositories
{
    internal class AspNetUserRepository : Repository<AspNetUser>, IAspNetUserRepository
    {
        internal AspNetUserRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public AspNetUser FindByUserName(string username)
        {
            return Set.FirstOrDefault(x => x.UserName == username);
        }

        public Task<AspNetUser> FindByUserNameAsync(string username)
        {
            return Set.FirstOrDefaultAsync(x => x.UserName == username);
        }

        public AspNetUser FindByEmail(string email)
        {
            return Set.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
        }

        public Task<AspNetUser> FindByEmailAsync(string email)
        {
            return Set.FirstOrDefaultAsync(x => x.Email.ToLower() == email.ToLower());
        }

        public Task<AspNetUser> FindByUserNameAsync(System.Threading.CancellationToken cancellationToken, string username)
        {
            return Set.FirstOrDefaultAsync(x => x.UserName == username, cancellationToken);
        }


        public Task<AspNetUser> FindByEmailAsync(System.Threading.CancellationToken cancellationToken, string email)
        {
            return Set.FirstOrDefaultAsync(x => x.Email.ToLower() == email.ToLower(), cancellationToken);
        }
    }
}
