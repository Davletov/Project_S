namespace Web.Models.CourseraEntity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Newtonsoft.Json;    

    public class University
    {
        /// <summary>
        /// private Id for database identity
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UniversityId { get; set; }

        /// <summary>
        /// University Id (public Id for identity with University Id from Coursera API
        /// </summary>
        [JsonProperty("id")]
        public int UniversityIdFromApi { get; set; }

        /// <summary>
        /// The university’s name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The short name associated with the university
        /// </summary>
        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        /// <summary>
        /// The university’s description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The URL to a background banner image
        /// </summary>
        [JsonProperty("banner")]
        public string Banner { get; set; }

        /// <summary>
        /// Link to the university’s home page.
        /// </summary>
        [JsonProperty("homeLink")]
        public string HomeLink { get; set; }

        /// <summary>
        /// Human-readable description of the partner’s location.
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// University’s city.
        /// </summary>
        [JsonProperty("locationCity")]
        public string LocationCity { get; set; }

        /// <summary>
        /// University’s state.
        /// </summary>
        [JsonProperty("locationState")]
        public string LocationState { get; set; }

        /// <summary>
        /// University’s country.
        /// </summary>
        [JsonProperty("locationCountry")]
        public string LocationCountry { get; set; }

        /// <summary>
        /// University’s latitude.
        /// </summary>
        [JsonProperty("locationLat")]
        public double LocationLat { get; set; }

        /// <summary>
        /// University’s longitude.
        /// </summary>
        [JsonProperty("locationLng")]
        public double LocationLng { get; set; }

        /// <summary>
        /// URL to the logo used inside courses.
        /// </summary>
        [JsonProperty("classLogo")]
        public string ClassLogo { get; set; }

        /// <summary>
        /// University’s website.
        /// </summary>
        [JsonProperty("website")]
        public string Website { get; set; }

        /// <summary>
        /// University’s offical twitter handle.
        /// </summary>
        [JsonProperty("websiteTwitter")]
        public string WebsiteTwitter { get; set; }

        /// <summary>
        /// University’s facebook page.
        /// </summary>
        [JsonProperty("websiteFacebook")]
        public string WebsiteFacebook { get; set; }

        /// <summary>
        /// University’s youtube channel.
        /// </summary>
        [JsonProperty("websiteYoutube")]
        public string WebsiteYoutube { get; set; }

        /// <summary>
        /// University’s Logo
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// University’s Logo (Square)
        /// </summary>
        [JsonProperty("squareLogo")]
        public string SquareLogo { get; set; }

        /// <summary>
        /// High-resolution banner for use on the Coursera home landing page.
        /// </summary>
        [JsonProperty("landingPageBanner")]
        public string LandingPageBanner { get; set; }

        /// <summary>
        /// Связка многие ко многим (Университеты <-> Курсы)
        /// </summary>
        [JsonProperty("courses")]
        //[JsonConverter(typeof(ConvertToCourse))]
        public ICollection<Course> Courses { get; set; }
    }
}