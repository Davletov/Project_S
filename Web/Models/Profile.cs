using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI.WebControls;

namespace Web.Models
{
    public class Profile
    {
        public long ProfileId { get; set; }

        public string UserId { get; set; }

        public List<UserCriteria> UserCriterias { get; set; } 
    }

    public class UserCriteria
    {
        public int CriteriaId { get; set; }

        public string Name { get; set; }
    }
}