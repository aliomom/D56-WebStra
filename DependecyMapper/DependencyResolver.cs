using FluentValidation;
using Idenity;
using Identity;
using Microsoft.AspNet.Identity;
using Service.Dto;
using Service.Interface;
using Service.Service;
using Service.Validator;
using ServicrsInfrastructer;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyMapper
{
    [Export(typeof(IComponent))]
    public class DependencyResolver : IComponent
    {
        public void SetUp(IRegisterComponent registerComponent)
        {
            registerComponent.RegisterTypeWithInjectedConstructor<IUnitOfWork, UnitOfWork>("D56-WebStra");
            registerComponent.RegisterTypeWithTransientLifetimeManager<IUserStore<IdentityUser, Guid>, UserStore>();
            registerComponent.RegisterTypeWithTransientLifetimeManager<IRoleStore<IdentityRole, Guid>, RoleStore>();

            // Services

            registerComponent.RegisterType<IUserService, UserService>();



            registerComponent.RegisterType<IValidator<ChangePasswordDto>, ChangePasswordValidator>();

        }
    }
}
