namespace Web.Models.Profile
{
    using System;
    using Web.Models.Criteria;

    // Связка профайл - критерии 3-го уровня
    public class Profile3LevelCriteria
    {
        public long Id { get; set; }

        public virtual ThirdLevelCriteria Criteria { get; set; }

        public Guid CriteriaId { get; set; }

        public virtual Models.Profile.Profile Profile { get; set; }

        public long ProfileId { get; set; }
    }
}