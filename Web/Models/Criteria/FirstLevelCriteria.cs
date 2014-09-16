namespace Web.Models.Criteria
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// 1 уровень критериев (основные направления наук: 
    /// Humanities sciences, Social sciences, Natural Sciences, Natural Sciences, Formal Sciences, Applied Sciences
    /// </summary>
    public class FirstLevelCriteria
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

        public virtual ICollection<SecondLevelCriteria> SecondLevelCriteria { get; set; }

        public FirstLevelCriteria()
        {
            Id = Guid.NewGuid();
        }
    }
}