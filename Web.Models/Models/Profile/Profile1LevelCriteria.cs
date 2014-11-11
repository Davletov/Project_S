namespace Web.Models.Profile
{
    using System;
    using Web.Models.Criteria;

    // Связка профайл - критерии 1-го уровня
    public class ProfileCriteria
    {
        public long Id { get; set; }

        public virtual Criteria Criteria { get; set; }

        public Guid CriteriaId { get; set; }

        public virtual Profile Profile { get; set; }

        public long ProfileId { get; set; }
    }
}