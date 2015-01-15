using Web.Enum;

namespace Web.Models
{
    public interface IMaterial
    {
        string VideoId { get; set; }
        string Name { get; set; }

        string Description { get; set; }

        string LargeIcon { get; set; }

        string SmallIcon { get; set; }

        string AboutTheCourse { get; set; }
        MaterialType Type { get; }
    }
}