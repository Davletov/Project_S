namespace Web.Models.Criteria
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Web.Models.CourseraEntity;

    /// <summary>
    /// Таблица сопоставления основных критериев с категориями Coursera
    /// </summary>
    public class CriteriaWithCourseraCategory
    {
        /// <summary>
        /// GlobalCriteriaId
        /// </summary>
        [Key]
        public Guid GlobalCriteriaId { get; set; }

        public string GlobalCriteriaName { get; set; }

        public string CourseraCategoryName { get; set; }

        /// <summary>
        /// CourseraCategory
        /// </summary>
        public virtual ICollection<Category> Category { get; set; }

    }
}