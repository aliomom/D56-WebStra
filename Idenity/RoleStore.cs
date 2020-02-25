using Domain;
using Idenity;
using Microsoft.AspNet.Identity;
using ServicrsInfrastructer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity
{
    public class RoleStore : IRoleStore<IdentityRole, Guid>, IQueryableRoleStore<IdentityRole, Guid>, IDisposable
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoleStore(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region IRoleStore<IdentityRole, Guid> Members
        public System.Threading.Tasks.Task CreateAsync(IdentityRole role)
        {
            if (role == null)
                throw new ArgumentNullException("role");

            var r = getRole(role);

            _unitOfWork.AspNetRoleRepository.Add(r);
            return _unitOfWork.SaveChangesAsync();
        }

        public System.Threading.Tasks.Task DeleteAsync(IdentityRole role)
        {
            if (role == null)
                throw new ArgumentNullException("role");

            var r = getRole(role);

            _unitOfWork.AspNetRoleRepository.Remove(r);
            return _unitOfWork.SaveChangesAsync();
        }

        public System.Threading.Tasks.Task<IdentityRole> FindByIdAsync(Guid roleId)
        {
            var role = _unitOfWork.AspNetRoleRepository.FindById(roleId);
            return Task.FromResult<IdentityRole>(getIdentityRole(role));
        }

        public System.Threading.Tasks.Task<IdentityRole> FindByNameAsync(string roleName)
        {
            var role = _unitOfWork.AspNetRoleRepository.FindByName(roleName);
            return Task.FromResult<IdentityRole>(getIdentityRole(role));
        }

        public System.Threading.Tasks.Task UpdateAsync(IdentityRole role)
        {
            if (role == null)
                throw new ArgumentNullException("role");
            var r = getRole(role);
            _unitOfWork.AspNetRoleRepository.Update(r);
            return _unitOfWork.SaveChangesAsync();
        }
        #endregion

        #region IDisposable Members
        public void Dispose()
        {
            // Dispose does nothing since we want Unity to manage the lifecycle of our Unit of Work
        }
        #endregion

        #region IQueryableRoleStore<IdentityRole, Guid> Members
        public IQueryable<IdentityRole> Roles
        {
            get
            {
                return _unitOfWork.AspNetRoleRepository
                    .GetAll()
                    .Select(x => getIdentityRole(x))
                    .AsQueryable();
            }
        }
        #endregion

        #region Private Methods
        private AspNetRole getRole(IdentityRole identityRole)
        {
            if (identityRole == null)
                return null;
            return new AspNetRole
            {
                Id = identityRole.Id,
                Name = identityRole.Name
            };
        }

        private IdentityRole getIdentityRole(AspNetRole role)
        {
            if (role == null)
                return null;
            return new IdentityRole
            {
                Id = role.Id,
                Name = role.Name
            };
        }
        #endregion
    }
}
