using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_PhysicsSpaceSciences(ref SecondLevelCriteria physicsSpaceSciences, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Acoustics", Tags = "acoustics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Applied Physics", Tags = "applied physics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Astrobiology", Tags = "astrobiology", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Observational astronomy", Tags = "observational astronomy,astronomy", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Radio astronomy", Tags = "radio astronomy,astronomy", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Microwave astronomy", Tags = "microwave astronomy,astronomy", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Infrared astronomy", Tags = "infrared astronomy,astronomy", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Optical astronomy", Tags = "optical astronomy,astronomy", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "UV astronomy", Tags = "uv astronomy,astronomy", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "X-ray astronomy", Tags = "x-ray astronomy,astronomy", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Gamma ray astronomy", Tags = "gamma ray astronomy,astronomy", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Gravitational astronomy", Tags = "gravitational astronomy,astrophysics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Black holes", Tags = "black holes,astrophysics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Interstellar medium", Tags = "interstellar medium,astrophysics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Astrophysical plasma", Tags = "astrophysical plasma,astrophysics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Galaxy formation and evolution", Tags = "galaxy formation and evolution,astrophysics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "High-energy astrophysics", Tags = "high-energy astrophysics,astrophysics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Hydrodynamics", Tags = "hydrodynamics,astrophysics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Magnetohydrodynamics", Tags = "magnetohydrodynamics,astrophysics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Star formation", Tags = "star formation,astrophysics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Physical cosmology", Tags = "physical cosmology,astrophysics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Stellar astrophysics", Tags = "stellar astrophysics,astrophysics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Helioseismology", Tags = "helioseismology,astrophysics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Stellar evolution", Tags = "stellar evolution,astrophysics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Stellar nucleosynthesis", Tags = "stellar nucleosynthesis,astrophysics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "atomic, molecular, and optical physics", Tags = "atomic, molecular, and optical physics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Biophysics", Tags = "biophysics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Computational physics", Tags = "computational physics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Condensed matter physics", Tags = "condensed matter physics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Cryogenics", Tags = "cryogenics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Electromagnetism", Tags = "electromagnetism", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Elementary particle physics", Tags = "elementary particle physics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Fluid dynamics", Tags = "fluid dynamics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Geophysics", Tags = "geophysics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Mathematical physics", Tags = "mathematical physics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Medical physics", Tags = "medical physics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Mechanics", Tags = "mechanics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Molecular physics", Tags = "molecular physics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Newtonian dynamics", Tags = "newtonian dynamics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Nuclear physics", Tags = "nuclear physics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Optics", Tags = "optics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Planetary science", Tags = "planetary science", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Plasma physics", Tags = "plasma physics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Quantum physics", Tags = "quantum physics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Solid mechanics", Tags = "solid mechanics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Solid state physics", Tags = "solid state physics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Statistical mechanics", Tags = "statistical mechanics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Theoretical physics", Tags = "theoretical physics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Thermodynamics", Tags = "thermodynamics", SecondLevelCriteria = physicsSpaceSciences },
                new ThirdLevelCriteria { Name = "Vehicle dynamics", Tags = "vehicle dynamics", SecondLevelCriteria = physicsSpaceSciences }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                physicsSpaceSciences.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}