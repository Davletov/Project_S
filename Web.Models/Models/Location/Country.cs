namespace Web.Models.Location
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountryId { get; set; }

        public string ShortName { get; set; }

        public string Name { get; set; }

        public string ImageFile { get; set; }

        public virtual ICollection<City> Cities { get; set; }

        public Country()
        {
            Cities = new Collection<City>();
        }
    }
}