using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_PhysicsSpaceSciences(ref Criteria physicsSpaceSciences, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Acoustics", Tags = "acoustics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Applied Physics", Tags = "applied physics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Astrobiology", Tags = "astrobiology", Parent = physicsSpaceSciences },
                new Criteria { Name = "Observational astronomy", Tags = "observational astronomy,astronomy", Parent = physicsSpaceSciences },
                new Criteria { Name = "Radio astronomy", Tags = "radio astronomy,astronomy", Parent = physicsSpaceSciences },
                new Criteria { Name = "Microwave astronomy", Tags = "microwave astronomy,astronomy", Parent = physicsSpaceSciences },
                new Criteria { Name = "Infrared astronomy", Tags = "infrared astronomy,astronomy", Parent = physicsSpaceSciences },
                new Criteria { Name = "Optical astronomy", Tags = "optical astronomy,astronomy", Parent = physicsSpaceSciences },
                new Criteria { Name = "UV astronomy", Tags = "uv astronomy,astronomy", Parent = physicsSpaceSciences },
                new Criteria { Name = "X-ray astronomy", Tags = "x-ray astronomy,astronomy", Parent = physicsSpaceSciences },
                new Criteria { Name = "Gamma ray astronomy", Tags = "gamma ray astronomy,astronomy", Parent = physicsSpaceSciences },
                new Criteria { Name = "Gravitational astronomy", Tags = "gravitational astronomy,astrophysics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Black holes", Tags = "black holes,astrophysics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Interstellar medium", Tags = "interstellar medium,astrophysics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Astrophysical plasma", Tags = "astrophysical plasma,astrophysics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Galaxy formation and evolution", Tags = "galaxy formation and evolution,astrophysics", Parent = physicsSpaceSciences },
                new Criteria { Name = "High-energy astrophysics", Tags = "high-energy astrophysics,astrophysics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Hydrodynamics", Tags = "hydrodynamics,astrophysics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Magnetohydrodynamics", Tags = "magnetohydrodynamics,astrophysics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Star formation", Tags = "star formation,astrophysics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Physical cosmology", Tags = "physical cosmology,astrophysics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Stellar astrophysics", Tags = "stellar astrophysics,astrophysics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Helioseismology", Tags = "helioseismology,astrophysics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Stellar evolution", Tags = "stellar evolution,astrophysics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Stellar nucleosynthesis", Tags = "stellar nucleosynthesis,astrophysics", Parent = physicsSpaceSciences },
                new Criteria { Name = "atomic, molecular, and optical physics", Tags = "atomic, molecular, and optical physics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Biophysics", Tags = "biophysics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Computational physics", Tags = "computational physics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Condensed matter physics", Tags = "condensed matter physics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Cryogenics", Tags = "cryogenics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Electromagnetism", Tags = "electromagnetism", Parent = physicsSpaceSciences },
                new Criteria { Name = "Elementary particle physics", Tags = "elementary particle physics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Fluid dynamics", Tags = "fluid dynamics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Geophysics", Tags = "geophysics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Mathematical physics", Tags = "mathematical physics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Medical physics", Tags = "medical physics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Mechanics", Tags = "mechanics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Molecular physics", Tags = "molecular physics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Newtonian dynamics", Tags = "newtonian dynamics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Nuclear physics", Tags = "nuclear physics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Optics", Tags = "optics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Planetary science", Tags = "planetary science", Parent = physicsSpaceSciences },
                new Criteria { Name = "Plasma physics", Tags = "plasma physics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Quantum physics", Tags = "quantum physics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Solid mechanics", Tags = "solid mechanics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Solid state physics", Tags = "solid state physics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Statistical mechanics", Tags = "statistical mechanics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Theoretical physics", Tags = "theoretical physics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Thermodynamics", Tags = "thermodynamics", Parent = physicsSpaceSciences },
                new Criteria { Name = "Vehicle dynamics", Tags = "vehicle dynamics", Parent = physicsSpaceSciences }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                physicsSpaceSciences.Children.Add(thirdLevelCriteria);
            }
        }
    }
}