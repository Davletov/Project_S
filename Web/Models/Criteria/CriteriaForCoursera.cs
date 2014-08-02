using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Models.Criteria
{
    /// <summary>
    /// Таблица сопоставления основных критериев с категориями Coursera
    /// </summary>
    public class CriteriaForCoursera
    {
        /// <summary>
        /// private Id for database identity
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CriteriaForCourseraId { get; set; }

        /// <summary>
        /// CourseraCategoryId
        /// </summary>
        public int CourseraCategoryId { get; set; }

        /// <summary>
        /// FirstLevelCriteriaId
        /// </summary>
        public int FirstLevelCriteriaId { get; set; }

        /// <summary>
        /// SecondLevelCriteriaId
        /// </summary>
        public int SecondLevelCriteriaId { get; set; }

        /// <summary>
        /// ThirdLevelCriteriaId
        /// </summary>
        public int ThirdLevelCriteriaId { get; set; }
    }
}