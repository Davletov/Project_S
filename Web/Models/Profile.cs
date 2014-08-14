using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;
using Web.Enum;
// You can add profile data for the user by adding more properties to your Profile class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
using Web.Models.Criteria;

namespace Web.Models
{
    [Table("Profile")]
    public class Profile : IdentityUser
    {
        public long ProfileId { get; set; }

        public string UserId { get; set; }

        public DateTime? CreateDate { get; set; }

        public string LoginName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public int BirthDay { get; set; }

        public int BirthMonth { get; set; }

        public int BirthYear { get; set; }

        public virtual Country Country { get; set; } 

        public virtual City City { get; set; }

        public UserSocialStatus UserSocialStatus { get; set; }

        public virtual ICollection<FirstLevelCriteria> FirstLevelCriteria { get; set; }

        public virtual ICollection<SecondLevelCriteria> SecondLevelCriteria { get; set; }

        public virtual ICollection<ThirdLevelCriteria> ThirdLevelCriteria { get; set; }
    }
}
