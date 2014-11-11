using Web.Models.CourseraEntity;

namespace Web.Models.Criteria
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// 2 уровень критериев: основные предметы каждого из разделов 1-го уровня:
    /// 1 уровень (Humanities sciences) - 2 уровень (History, Linguistics, Literature etc)
    /// </summary>
    public class Second1LevelCriteria
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

        public virtual Criteria FirstLevelCriteria { get; set; }

        public virtual ICollection<Criteria> ThirdLevelCriteria { get; set; }

        public Second1LevelCriteria()
        {
            Id = Guid.NewGuid();
        }

        public virtual ICollection<Course> Courses { get; set; }
    }
}