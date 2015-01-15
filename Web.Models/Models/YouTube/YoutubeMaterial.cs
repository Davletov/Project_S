using Web.Enum;

namespace Web.Models.YouTube
{
    public class YoutubeMaterial : IMaterial
    {
        public string Name { get; set; }
        
        public int Duration { get; set; }

        public string Url { get; set; }

        public int Rating { get; set; }

        public int ViewCount { get; set; }

        public string ETag { get; set; }

        public string VideoId { get; set; }

        public string Description { get; set; }

        public string LargeIcon
        {
            get
            {
                return LargeIcon = string.Format("http://img.youtube.com/vi/{0}/hqdefault.jpg", this.VideoId);
            }
            set
            {
                
            }
            
        }

        public string SmallIcon
        {
            get
            {
                return LargeIcon = string.Format("http://img.youtube.com/vi/{0}/hqdefault.jpg", this.VideoId);
            }
            set
            {

            }
        }
        public MaterialType Type
        {
            get
            {
                return MaterialType.Youtube;
            }
        }
        public string AboutTheCourse { get; set; }
    }
}