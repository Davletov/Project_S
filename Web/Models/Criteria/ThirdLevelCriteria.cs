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
    public class ThirdLevelCriteria
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

        public virtual SecondLevelCriteria SecondLevelCriteria { get; set; }

        public ThirdLevelCriteria()
        {
            Id = Guid.NewGuid();
        }

        public ICollection<Category> Categories { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}