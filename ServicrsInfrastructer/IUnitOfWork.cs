using ServicrsInfrastructer.Interface;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServicrsInfrastructer
{
    public interface IUnitOfWork : IDisposable // التخاطب مع الداتابيس 
    {
        #region Properties
        IAspNetUserLoginRepository AspNetUserLoginRepository { get; }
        IAspNetRoleRepository AspNetRoleRepository { get; }
        IAspNetUserRepository AspNetUserRepository { get; }




        #endregion

        #region Methods
        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        #endregion
    }
}