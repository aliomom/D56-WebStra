using AutoMapper;
using Domain;
using Service.Dto;
using Service.Interface;
using ServicrsInfrastructer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Guid Add(UserDto dto)
        {
            var model = Mapper.Map<UserDto, AspNetUser>(dto);
            _unitOfWork.AspNetUserRepository.Add(model);
            _unitOfWork.SaveChanges();
            return model.Id;
        }
        public void editForAdm(Guid id, string fullname, string userName)
        {
            var user = _unitOfWork.AspNetUserRepository.FindById(id);
            user.UserName = userName;
            user.FullName = fullname;
            _unitOfWork.AspNetUserRepository.Update(user);
            _unitOfWork.SaveChanges();
        }
        public bool Edit(UserDto dto)
        {
            AspNetUser user = Mapper.Map<UserDto, AspNetUser>(dto);
            if (user == null)
                return false;
            _unitOfWork.AspNetUserRepository.Update(user);
            _unitOfWork.SaveChanges();
            return true;
        }

        public bool Delete(Guid id)
        {
            AspNetUser user = _unitOfWork.AspNetUserRepository.FindById(id);
            if (user == null)
                return false;
            _unitOfWork.AspNetUserRepository.Remove(user);
            _unitOfWork.SaveChanges();
            return true;
        }

        public UserDto GetById(Guid id)
        {
            var model = _unitOfWork.AspNetUserRepository.FindById(id);
            return Mapper.Map<AspNetUser, UserDto>(model);
        }

        public List<UserDto> GetAll()
        {
            return Mapper.Map<List<AspNetUser>, List<UserDto>>(_unitOfWork.AspNetUserRepository.GetAll());
        }
        public bool HasRole(Guid id, String role)
        {
            return GetById(id).Role == role;
        }
        public bool Exists(Guid id)
        {
            return GetById(id) == null ? false : true;
        }


        public List<UserDto> GetUsersByRole(string role)
        {
            return GetAll().AsEnumerable().Where(u => HasRole(u.UserId, role)).ToList();
        }

        public bool IsEmailUnique(string email)
        {
            return _unitOfWork.AspNetUserRepository.FindByEmail(email.ToLower()) == null;
        }
    }
}
