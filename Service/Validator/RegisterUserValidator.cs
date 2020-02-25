
using FluentValidation;
using Service.Dto;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validator
{
    public class RegisterUserValidator : AbstractValidator<ChangePasswordDto>
    {
        public readonly IUserService _userService;
        public RegisterUserValidator(IUserService userService)
        {
            _userService = userService;
            RuleSet("Register", () =>
            {
                CommonRules();
            });

            RuleSet("Edit", () =>
            {
                CommonRulesEdit();
            });
        
        }
        private void CommonRules()
        {
            RuleFor(m => m.fullname).NotEmpty().WithMessage("يرجى ادخال الاسم الكامل");
            RuleFor(m => m.UserName).NotEmpty().WithMessage("يرجى ادخال اسم المستخدم").Matches("^[a-zA-Z0-9_.-]*$").WithMessage("يرجى ادخال ارقام واحرف باللغه الانكليزيه فقط");
            RuleFor(m => m.oldPassword).NotEmpty().WithMessage("يرجى ادخال كلمة المرور السابقة");
            RuleFor(m => m.confirmNewPassword).NotEmpty().WithMessage("يرجى تاكيد كلمة المرور").Equal(x => x.newPassword).WithMessage("    الكلمتان غير متطابقتان");

          //  RuleFor(m => m.Email).SetValidator(new IsEmailUniquePropertyValidator(_userService));
        }
        private void CommonRulesEdit()
        {
            //RuleFor(m => m.FullName).NotEmpty().WithMessage("يرجى ادخال الاسم الكامل");
            //RuleFor(m => m.UserName).NotEmpty().WithMessage("يرجى ادخال اسم المستخدم").Matches("^[a-zA-Z0-9_.-]*$").WithMessage("يرجى ادخال ارقام واحرف باللغه الانكليزيه فقط");
            //RuleFor(m => m.Password).NotEmpty().WithMessage("يرجى ادخال كلمة المرور");
            //RuleFor(m => m.ConfirmPassword).NotEmpty().WithMessage("يرجى تاكيد كلمة المرور").Equal(x => x.Password).WithMessage("الكلمتان غير متطابقتان");
            //RuleFor(m => m.stateId).NotEmpty().WithMessage("يرجى ادخال الاسم المحافظة");
            //RuleFor(m => m.regionId).NotEmpty().WithMessage("يرجى ادخال الاسم المنطقه");
            //// RuleFor(m => m.Email).SetValidator(new IsEmailUniquePropertyValidator(_userService));
        }
    }
}
