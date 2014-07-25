namespace Web.Models.CourseraEntity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Newtonsoft.Json;
    using Web.Helpful;

    public class Instructor
    {
        /// <summary>
        /// private Id for database identity
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InstructorId { get; set; }

        /// <summary>
        /// Instructor Id (public Id for identity with Instructor Id from Coursera API
        /// </summary>
        [JsonProperty("id")]
        public int InstructorIdFromApi { get; set; }

        /// <summary>
        /// photo URL
        /// </summary>
        [JsonProperty("photo")]
        public string Photo { get; set; }

        /// <summary>
        /// photo URL 150x150px
        /// </summary>
        [JsonProperty("photo150")]
        public string Photo150 { get; set; }

        /// <summary>
        /// Instructor Biogrophy
        /// </summary>
        [JsonProperty("bio")]
        public string Bio { get; set; }

        /// <summary>
        /// Prefix for the instructor’s name
        /// </summary>
        [JsonProperty("prefixName")]
        public string PrefixName { get; set; }

        /// <summary>
        /// Instructor first name
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Instructor middle name
        /// </summary>
        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Instructor last name
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Suffix for the instructor name
        /// </summary>
        [JsonProperty("suffixName")]
        public string SuffixName { get; set; }

        /// <summary>
        /// Instructor full name
        /// </summary>
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// Instructor title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Instructor department
        /// </summary>
        [JsonProperty("department")]
        public string Department { get; set; }
        /// <summary>
        /// Instructor’s personal website
        /// </summary>
        [JsonProperty("website")]
        public string Website { get; set; }

        /// <summary>
        /// Instructor’s twitter handle.
        /// </summary>
        [JsonProperty("websiteTwitter")]
        public string WebsiteTwitter { get; set; }

        /// <summary>
        /// Instructor’s facebook page.
        /// </summary>
        [JsonProperty("websiteFacebook")]
        public string WebsiteFacebook { get; set; }

        /// <summary>
        /// Instructor’s LinkedIn profile.
        /// </summary>
        [JsonProperty("websiteLinkedin")]
        public string WebsiteLinkedin { get; set; }

        /// <summary>
        /// Instructor’s Google+ Website.
        /// </summary>
        [JsonProperty("websiteGplus")]
        public string WebsiteGplus { get; set; }

        /// <summary>
        /// Instructor’s short name.
        /// </summary>
        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        /// <summary>
        /// Связка многие ко многим (Инструкторы <-> Курсы)
        /// </summary>
        [JsonProperty("courses")]
        [JsonConverter(typeof(ConvertToCourse))]
        public ICollection<Course> Courses { get; set; }

    }
}