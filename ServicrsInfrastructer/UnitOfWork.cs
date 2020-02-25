using Domain;
using ServicrsInfrastructer.Interface;
using ServicrsInfrastructer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ServicrsInfrastructer
{
    
    public class UnitOfWork : IUnitOfWork
    {
        #region Fields
        private readonly ApplicationDbContext _context;
        private IAspNetUserLoginRepository _AspNetUserLoginRepository;
        private IAspNetRoleRepository _AspNetroleRepository;
        private IAspNetUserRepository _AspNetUserRepository;



        #endregion

        #region Constructors
       
        public UnitOfWork(string nameOrConnectionString)
        {

            _context= ApplicationDbContext.ctor(nameOrConnectionString);

        }
        #endregion

        #region IUnitOfWork Members
        public IAspNetUserLoginRepository AspNetUserLoginRepository
        {
            get { return _AspNetUserLoginRepository ?? (_AspNetUserLoginRepository = new AspNetUserLoginRepository(_context)); }
        }

        public IAspNetRoleRepository AspNetRoleRepository
        {
            get { return _AspNetroleRepository ?? (_AspNetroleRepository = new AspNetRoleRepository(_context)); }
        }

        public IAspNetUserRepository AspNetUserRepository
        {
            get { return _AspNetUserRepository ?? (_AspNetUserRepository = new AspNetUserRepository(_context)); }
        }

      
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
        #endregion

        #region IDisposable Members
        public void Dispose()
        {
            _AspNetUserLoginRepository = null;
            _AspNetroleRepository = null;
            _AspNetUserRepository = null;
            _context.Dispose();
        }
        #endregion
    }
}
