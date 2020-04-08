namespace Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AspNetRole
    {


        private ICollection<AspNetUser> _users;

        #region Scalar Properties
        public Guid RoleId { get; set; }
        public string Name { get; set; }
        #endregion

        #region Navigation Properties
        public ICollection<AspNetUser> Users
        {
            get { return _users ?? (_users = new List<AspNetUser>()); }
            set { _users = value; }
        }
        #endregion
    }
}
