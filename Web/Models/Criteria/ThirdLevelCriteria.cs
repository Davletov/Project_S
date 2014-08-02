using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Models.Criteria
{
    /// <summary>
    /// 3 уровень критерив (пока последний и самый детализированный уровень критериев)
    /// </summary>
    public class ThirdLevelCriteria
    {
        /// <summary>
        /// private Id for database identity
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ThirdLevelCriteriaId { get; set; }

        /// <summary>
        /// Name of Criteria
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Tags of this criteria
        /// </summary>
        public string Tags { get; set; }

        public virtual ICollection<FirstLevelCriteria> FirstLevelCriterias { get; set; }

        public ThirdLevelCriteria()
        {
            FirstLevelCriterias = new List<FirstLevelCriteria>();
        }
    }
}