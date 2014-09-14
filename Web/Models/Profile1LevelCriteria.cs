using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Models.Criteria;

namespace Web.Models
{
    public class Profile1LevelCriteria
    {
        public long Id { get; set; }
        public virtual FirstLevelCriteria Criteria { get; set; }
        public Guid CriteriaId { get; set; }
        public virtual Profile Profile { get; set; }
        public long ProfileId { get; set; }
    }
}