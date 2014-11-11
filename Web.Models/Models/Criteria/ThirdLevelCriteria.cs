using Web.Models.CourseraEntity;

namespace Web.Models.Criteria
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// 3 уровень критерив (пока последний и самый детализированный уровень критериев)
    /// </summary>
    public class Third1LevelCriteria
    {
        /// <summary>
        /// private Id for database identity
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        /// <summary>
        /// Name of Criteria
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Tags of this criteria
        /// </summary>
        public string Tags { get; set; }

        public virtual Criteria SecondLevelCriteria { get; set; }

        public Third1LevelCriteria()
        {
            Id = Guid.NewGuid();
        }

        public virtual ICollection<Course> Courses { get; set; }
    }
}