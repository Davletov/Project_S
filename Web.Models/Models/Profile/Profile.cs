using Web.Enum;

namespace Web.Models.Profile
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.AspNet.Identity.EntityFramework;    

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

        public int Country { get; set; } 

        public int City { get; set; }

        public UserSocialStatus UserSocialStatus { get; set; }

        public virtual ICollection<ProfileCriteria> ProfileCriteria { get; set; }        
    }
}
