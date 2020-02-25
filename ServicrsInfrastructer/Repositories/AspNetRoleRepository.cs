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
    internal class AspNetRoleRepository : Repository<AspNetRole>, IAspNetRoleRepository
    {
        internal AspNetRoleRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public AspNetRole FindByName(string roleName)
        {
            return Set.FirstOrDefault(x => x.Name == roleName);
        }

        public Task<AspNetRole> FindByNameAsync(string roleName)
        {
            return Set.FirstOrDefaultAsync(x => x.Name == roleName);
        }

        public Task<AspNetRole> FindByNameAsync(System.Threading.CancellationToken cancellationToken, string roleName)
        {
            return Set.FirstOrDefaultAsync(x => x.Name == roleName, cancellationToken);
        }
    }
}
