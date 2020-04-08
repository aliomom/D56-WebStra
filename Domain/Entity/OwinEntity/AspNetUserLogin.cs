namespace Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AspNetUserLogin
    {

        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }

     
        public Guid UserId { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
    }
}
