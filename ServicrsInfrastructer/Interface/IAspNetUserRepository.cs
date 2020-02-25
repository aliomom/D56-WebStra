using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServicrsInfrastructer.Interface
{
    public interface IAspNetUserRepository : IRepository<AspNetUser>
    {
        AspNetUser FindByUserName(string username);
        Task<AspNetUser> FindByUserNameAsync(string username);
        Task<AspNetUser> FindByUserNameAsync(CancellationToken cancellationToken, string username);
        AspNetUser FindByEmail(string email);
        Task<AspNetUser> FindByEmailAsync(string email);
        Task<AspNetUser> FindByEmailAsync(CancellationToken cancellationToken, string email);
    }
}
