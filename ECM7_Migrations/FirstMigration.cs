using System.Data;
using ECM7.Migrator.Framework;

namespace Testing.ECM7_Migrations
{
    public class FirstMigration : Migration
    {
        public override void Apply()
        {
            Database.AddTable("Category",
                new Column("CategoryId", DbType.Int32, ColumnProperty.PrimaryKey),
                new Column("CategoryIdFromApi", DbType.Int32, ColumnProperty.NotNull),
                new Column("Name", DbType.String, ColumnProperty.Null),
                new Column("ShortName", DbType.String, ColumnProperty.Null),
                new Column("Description", DbType.String, ColumnProperty.Null));

            Database.AddTable("Course",
                new Column("CourseId", DbType.Int32, ColumnProperty.PrimaryKey),
                new Column("CourseIdFromApi", DbType.Int32, ColumnProperty.NotNull),
                new Column("ShortName", DbType.String, ColumnProperty.Null),
                new Column("Name", DbType.String, ColumnProperty.Null),
                new Column("Language", DbType.String, ColumnProperty.Null),
                new Column("LargeIcon", DbType.String, ColumnProperty.Null),
                new Column("Photo", DbType.String, ColumnProperty.Null),
                new Column("PreviewLink", DbType.String, ColumnProperty.Null),
                new Column("ShortDescription", DbType.String, ColumnProperty.Null),
                new Column("SmallIcon", DbType.String, ColumnProperty.Null),
                new Column("SmallIconHover", DbType.String, ColumnProperty.Null),
                new Column("SubtitleLanguagesCsv", DbType.String, ColumnProperty.Null),
                new Column("IsTranslate", DbType.Boolean, ColumnProperty.Null),
                new Column("UniversityLogo", DbType.String, ColumnProperty.Null),
                new Column("UniversityLogoSt", DbType.String, ColumnProperty.Null),
                new Column("Video", DbType.String, ColumnProperty.Null),
                new Column("VideoId", DbType.String, ColumnProperty.Null),
                new Column("AboutTheCourse", DbType.String, ColumnProperty.Null),
                new Column("TargetAudience", DbType.Int32, ColumnProperty.NotNull),
                new Column("Faq", DbType.String, ColumnProperty.Null),
                new Column("CourseSyllabus", DbType.String, ColumnProperty.Null),
                new Column("CourseFormat", DbType.String, ColumnProperty.Null),
                new Column("SuggestedReadings", DbType.String, ColumnProperty.Null),
                new Column("Instructor", DbType.String, ColumnProperty.Null),
                new Column("EstimatedClassWorkload", DbType.String, ColumnProperty.Null),
                new Column("AboutTheInstructor", DbType.String, ColumnProperty.Null),
                new Column("RecommendedBackground", DbType.String, ColumnProperty.Null));


            Database.AddTable("Instructor",
                new Column("InstructorId", DbType.Int32, ColumnProperty.PrimaryKey),
                new Column("InstructorIdFromApi", DbType.Int32, ColumnProperty.NotNull),
                new Column("Photo", DbType.String, ColumnProperty.Null),
                new Column("Photo150", DbType.String, ColumnProperty.Null),
                new Column("Bio", DbType.String, ColumnProperty.Null),
                new Column("PrefixName", DbType.String, ColumnProperty.Null),
                new Column("FirstName", DbType.String, ColumnProperty.Null),
                new Column("MiddleName", DbType.String, ColumnProperty.Null),
                new Column("LastName", DbType.Boolean, ColumnProperty.Null),
                new Column("FullName", DbType.String, ColumnProperty.Null),
                new Column("Title", DbType.String, ColumnProperty.Null),
                new Column("Department", DbType.String, ColumnProperty.Null),
                new Column("Website", DbType.String, ColumnProperty.Null),
                new Column("WebsiteTwitter", DbType.String, ColumnProperty.Null),
                new Column("WebsiteFacebook", DbType.Int32, ColumnProperty.NotNull),
                new Column("WebsiteLinkedin", DbType.String, ColumnProperty.Null),
                new Column("WebsiteGplus", DbType.String, ColumnProperty.Null),
                new Column("ShortName", DbType.String, ColumnProperty.Null));



            Database.AddTable("Session",
                new Column("SessionId", DbType.Int32, ColumnProperty.PrimaryKey),
                new Column("SessionIdFromApi", DbType.Int32, ColumnProperty.NotNull),
                new Column("CourseId", DbType.Int32, ColumnProperty.NotNull),
                new Column("HomeLink", DbType.String, ColumnProperty.Null),
                new Column("Status", DbType.String, ColumnProperty.NotNull),
                new Column("Active", DbType.Boolean, ColumnProperty.Null),
                new Column("DurationString", DbType.String, ColumnProperty.Null),
                new Column("StartDay", DbType.Int32, ColumnProperty.Null),
                new Column("StartMonth", DbType.Int32, ColumnProperty.Null),
                new Column("StartYear", DbType.Int32, ColumnProperty.Null),
                new Column("Name", DbType.String, ColumnProperty.Null),
                new Column("SignatureTrackCloseTime", DbType.Int32, ColumnProperty.Null),
                new Column("SignatureTrackOpenTime", DbType.String, ColumnProperty.Null),
                new Column("SignatureTrackPrice", DbType.Double, ColumnProperty.Null),
                new Column("SignatureTrackRegularPrice", DbType.Int32, ColumnProperty.NotNull),
                new Column("EligibleForCertificates", DbType.Boolean, ColumnProperty.Null),
                new Column("EligibleForSignatureTrack", DbType.Boolean, ColumnProperty.Null),
                new Column("CertificateDescription", DbType.String, ColumnProperty.Null),
                new Column("CertificatesReady", DbType.Boolean, ColumnProperty.Null));


            Database.AddTable("Category",
                new Column("CategoryId", DbType.Int32, ColumnProperty.PrimaryKey),
                new Column("CategoryIdFromApi", DbType.Int32, ColumnProperty.NotNull),
                new Column("Name", DbType.String, ColumnProperty.Null),
                new Column("ShortName", DbType.String, ColumnProperty.Null),
                new Column("Description", DbType.String, ColumnProperty.Null));
        }

        public override void Revert()
        {
            Database.RemoveTable("Category");
        }
    }
}