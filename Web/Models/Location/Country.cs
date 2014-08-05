using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Models
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountryId { get; set; }

        public string ShortName { get; set; }

        public string Name { get; set; }

        public string ImageFile { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}