using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServicrsInfrastructer.Interface
{
    public interface IAspNetRoleRepository : IRepository<AspNetRole>
    {
        AspNetRole FindByName(string roleName);
        Task<AspNetRole> FindByNameAsync(string roleName);
        Task<AspNetRole> FindByNameAsync(CancellationToken cancellationToken, string roleName);
    }
}
