namespace Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AspNetUser
    {


        public Guid Id { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public virtual string PasswordHash { get; set; }

        public virtual string SecurityStamp { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        [Required]
        [StringLength(256)]
        public string UserName { get; set; }
        public string FullName { get; set; }
        private ICollection<AspNetUserClaim> _claims;
        private ICollection<AspNetUserLogin> _externalLogins;
        private ICollection<AspNetRole> _roles;

        public virtual ICollection<AspNetUserClaim> Claims
        {
            get { return _claims ?? (_claims = new List<AspNetUserClaim>()); }
            set { _claims = value; }
        }

        public virtual ICollection<AspNetUserLogin> Logins
        {
            get
            {
                return _externalLogins ??
                    (_externalLogins = new List<AspNetUserLogin>());
            }
            set { _externalLogins = value; }
        }

        public virtual ICollection<AspNetRole> Roles
        {
            get { return _roles ?? (_roles = new List<AspNetRole>()); }
            set { _roles = value; }
        }

    }

 
}
