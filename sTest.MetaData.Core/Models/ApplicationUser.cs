using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace sTest.MetaData.Core.Models
{
    [Table("Users", Schema = "app_security")]
    public class ApplicationUser : IdentityUser<string>
    {
        public ApplicationUser() : base()
        {
            IsEnabled = true;
            CreatedDateTime = DateTime.Now;
            CreatedBy = "adminusr";
            IsDeleted = false;
        }

        public virtual ICollection<ApplicationUserClaim> Claims { get; set; }

        public virtual ICollection<ApplicationUserLogin> Logins { get; set; }

        public virtual ICollection<ApplicationUserToken> Tokens { get; set; }

        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? CreatedDateTime { get; set; }

        public DateTime? UpdatedDateTime { get; set; }

        public string UpdatedBy { get; set; }

        public bool IsEnabled { get; set; }

        public bool IsDeleted { get; set; }

        public string ProfilePhoto { get; set; }
    }
}
