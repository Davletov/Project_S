namespace Testing.CourseraEntity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Newtonsoft.Json;
    using Testing.Helpful;

    public class Session
    {
        /// <summary>
        /// private Id for database identity
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SessionId { get; set; }

        /// <summary>
        /// Session Id (public Id for identity with Session Id from Coursera API
        /// </summary>
        [JsonProperty("id")]
        public int SessionIdFromApi { get; set; }

        /// <summary>
        /// Course Id
        /// </summary>
        [JsonProperty("courseId")]
        public int CourseId { get; set; }

        /// <summary>
        /// Home link for the course.
        /// </summary>
        [JsonProperty("homeLink")]
        public string HomeLink { get; set; }

        /// <summary>
        /// Session status.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Whether the session is active.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Approximate (human readable) duration string. Typically of the format ‘XX weeks’.
        /// </summary>
        [JsonProperty("durationString")]
        public string DurationString { get; set; }

        /// <summary>
        /// Optional start day.
        /// </summary>
        [JsonProperty("startDay")]
        public int StartDay { get; set; }

        /// <summary>
        /// Optional start month.
        /// </summary>
        [JsonProperty("startMonth")]
        public int StartMonth { get; set; }

        /// <summary>
        /// Optional start year.
        /// </summary>
        [JsonProperty("startYear")]
        public int StartYear { get; set; }

        /// <summary>
        /// Session iteration name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Signature track information.
        /// </summary>
        [JsonProperty("signatureTrackCloseTime")]
        public int SignatureTrackCloseTime { get; set; }

        /// <summary>
        /// Signature track information.
        /// </summary>
        [JsonProperty("signatureTrackOpenTime")]
        public int SignatureTrackOpenTime { get; set; }

        /// <summary>
        /// Signature track information.
        /// </summary>
        [JsonProperty("signatureTrackPrice")]
        public double SignatureTrackPrice { get; set; }

        /// <summary>
        /// Signature track information.
        /// </summary>
        [JsonProperty("signatureTrackRegularPrice")]
        public float SignatureTrackRegularPrice { get; set; }

        /// <summary>
        /// Certificates allowed.
        /// </summary>
        [JsonProperty("eligibleForCertificates")]
        public bool EligibleForCertificates { get; set; }

        /// <summary>
        /// Signature track available.
        /// </summary>
        [JsonProperty("eligibleForSignatureTrack")]
        public bool EligibleForSignatureTrack { get; set; }

        /// <summary>
        /// Description on the course certificate.
        /// </summary>
        [JsonProperty("certificateDescription")]
        public string CertificateDescription { get; set; }

        /// <summary>
        /// Whether the certificates have been released.
        /// </summary>
        [JsonProperty("certificatesReady")]
        public bool CertificatesReady { get; set; }

        /// <summary>
        /// Связка многие ко многим (Сессия <-> Курсы)
        /// </summary>
        [JsonProperty("courses")]
        [JsonConverter(typeof(ConvertToCourse))]
        public ICollection<Course> Courses { get; set; }
    }
}