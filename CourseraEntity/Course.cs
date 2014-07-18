namespace Testing.CourseraEntity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Testing.Helpful;
    using Newtonsoft.Json;

    public class Course
    {
        /// <summary>
        /// private Id for database identity
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }

        /// <summary>
        /// Course Id (public Id for identity with Course Id from Coursera API
        /// </summary>
        [JsonProperty("id")]
        public int CourseIdFromApi { get; set; }

        /// <summary>
        /// The short name associated with the course
        /// </summary>
        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        /// <summary>
        /// The course name or title
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The language code for the course. (e.g. `en` means English.)
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// A large image to represent the course.
        /// </summary>
        [JsonProperty("largeIcon")]
        public string LargeIcon { get; set; }

        /// <summary>
        /// A course photo.
        /// </summary>
        [JsonProperty("photo")]
        public string Photo { get; set; }

        /// <summary>
        /// If the course has enabled preview, this is the preview URL.
        /// </summary>
        [JsonProperty("previewLink")]
        public string PreviewLink { get; set; }

        /// <summary>
        /// A short description of the course.
        /// </summary>
        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// A small icon.
        /// </summary>
        [JsonProperty("smallIcon")]
        public string SmallIcon { get; set; }

        /// <summary>
        /// Hovered icon.
        /// </summary>
        [JsonProperty("smallIconHover")]
        public string SmallIconHover { get; set; }

        /// <summary>
        /// Translated languages.
        /// </summary>
        [JsonProperty("subtitleLanguagesCsv")]
        public string SubtitleLanguagesCsv { get; set; }

        /// <summary>
        /// Whether the course is translated.
        /// </summary>
        [JsonProperty("isTranslate")]
        public bool IsTranslate { get; set; }

        /// <summary>
        /// If there is a special university logo.
        /// </summary>
        [JsonProperty("universityLogo")]
        public string UniversityLogo { get; set; }

        /// <summary>
        /// Signature track university logo.
        /// </summary>
        [JsonProperty("universityLogoSt")]
        public string UniversityLogoSt { get; set; }

        /// <summary>
        /// The YouTube video code. e.g. https://www.youtube.com/watch?v=CCmTQW7OebM
        /// </summary>
        [JsonProperty("video")]
        public string Video { get; set; }

        /// <summary>
        /// Synonym for video
        /// </summary>
        [JsonProperty("videoId")]
        public string VideoId { get; set; }

        /// <summary>
        /// HTML snippet describing the course.
        /// </summary>
        [JsonProperty("aboutTheCourse")]
        public string AboutTheCourse { get; set; }

        /// <summary>
        /// Description of the intended course audience. 
        /// The target audiences are: 0 - Basic undergraduates, 
        /// 1 - Advanced undergraduates or beginning graduates, 2 - Advanced graduates, and 3 - Other
        /// </summary>
        [JsonProperty("targetAudience")]
        public int TargetAudience { get; set; }

        /// <summary>
        /// HTML snippet answering frequently asked questions.
        /// </summary>
        [JsonProperty("faq")]
        public string Faq { get; set; }

        /// <summary>
        /// HTML snippet containing the course syllabus.
        /// </summary>
        [JsonProperty("courseSyllabus")]
        public string CourseSyllabus { get; set; }

        /// <summary>
        /// Format description.
        /// </summary>
        [JsonProperty("courseFormat")]
        public string CourseFormat { get; set; }

        /// <summary>
        /// HTML snippet containing suggested readings.
        /// </summary>
        [JsonProperty("suggestedReadings")]
        public string SuggestedReadings { get; set; }

        /// <summary>
        /// Instructor name(s) and title(s).
        /// </summary>
        [JsonProperty("instructor")]
        public string Instructor { get; set; }

        /// <summary>
        /// Description of the estimated workload for the course.
        /// </summary>
        [JsonProperty("estimatedClassWorkload")]
        public string EstimatedClassWorkload { get; set; }

        /// <summary>
        /// HTML snippet about the instructor.
        /// </summary>
        [JsonProperty("aboutTheInstructor")]
        public string AboutTheInstructor { get; set; }

        /// <summary>
        /// HTML snippet describing recommended background.
        /// </summary>
        [JsonProperty("recommendedBackground")]
        public string RecommendedBackground { get; set; }

        /// <summary>
        /// Связка многие ко многим (Категория <-> Курсы)
        /// Каждая категория (Пр.: математика) может иметь несколько курсов
        /// Каждый курс (Пр.: Математические методы в экономике) может относится к нескольких категориям 
        /// </summary>
        [JsonProperty("categories")]
        [JsonConverter(typeof(ConvertToCategory))]
        public ICollection<Category> Categories { get; set; }

        /// <summary>
        /// Связка многие ко многим (Сессия <-> Курсы)
        /// </summary>
        [JsonProperty("sessions")]
        [JsonConverter(typeof(ConvertToSession))]
        public ICollection<Session> Sessions { get; set; }

        /// <summary>
        /// Связка многие ко многим (Инструкторы <-> Курсы)
        /// </summary>
        [JsonProperty("instructors")]
        [JsonConverter(typeof(ConvertToInstructor))]
        public ICollection<Instructor> Instructors { get; set; }

        /// <summary>
        /// Связка многие ко многим (Университеты <-> Курсы)
        /// </summary>
        [JsonProperty("universities ")]
        [JsonConverter(typeof(ConvertToUniversity))]
        public ICollection<University> Universities { get; set; }

    }
}