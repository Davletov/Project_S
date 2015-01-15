using Web.Enum;

namespace Web.Models.CourseraEntity
{
    public class CourseraMaterial : IMaterial
    {
        public string VideoId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string LargeIcon { get; set; }

        public string SmallIcon { get; set; }

        public string AboutTheCourse { get; set; }

        public MaterialType Type
        {
            get
            {
                return MaterialType.Coursera;
            }
        }

    }
}