namespace Web.Models.CourseraEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Newtonsoft.Json;    
    using Web.Models.Criteria;

    public class Category
    {
        /// <summary>
        /// private Id for database identity
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        /// <summary>
        /// Category Id (public Id for identity with Category Id from Coursera API
        /// </summary>
        [JsonProperty("id")]
        public int CategoryIdFromApi { get; set; }

        /// <summary>
        /// The category’s name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The short name associated with the category
        /// </summary>
        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        /// <summary>
        /// The category’s description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Связка многие ко многим (Категория <-> Курсы)
        /// Каждая категория (Пр.: математика) может иметь несколько курсов
        /// Каждый курс (Пр.: Математические методы в экономике) может относится к нескольких категориям 
        /// </summary>
        [JsonProperty("courses")]
        public ICollection<Course> Courses { get; set; }
    }
}