using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_MechanicalEngineering(ref Criteria mechanicalEngineering, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Aeronautics engineering", Tags = "aeronautics engineering,aerospace engineering", Parent = mechanicalEngineering },
                new Criteria { Name = "Astronautics engineering", Tags = "astronautics engineering,aerospace engineering", Parent = mechanicalEngineering },
                new Criteria { Name = "Acoustical engineering", Tags = "acoustical engineering", Parent = mechanicalEngineering },
                new Criteria { Name = "Automotive engineering", Tags = "automotive engineering", Parent = mechanicalEngineering },
                new Criteria { Name = "Biomedical engineering", Tags = "biomedical engineering", Parent = mechanicalEngineering },
                new Criteria { Name = "Biomechanical engineering", Tags = "biomechanical engineering", Parent = mechanicalEngineering },
                new Criteria { Name = "Continuum mechanics", Tags = "continuum mechanics", Parent = mechanicalEngineering },
                new Criteria { Name = "Fluid mechanics", Tags = "fluid mechanics", Parent = mechanicalEngineering },
                new Criteria { Name = "Heat transfer", Tags = "heat transfer", Parent = mechanicalEngineering },
                new Criteria { Name = "Industrial engineering", Tags = "industrial engineering", Parent = mechanicalEngineering },
                new Criteria { Name = "Manufacturing engineering", Tags = "manufacturing engineering", Parent = mechanicalEngineering },
                new Criteria { Name = "Marine engineering", Tags = "marine engineering", Parent = mechanicalEngineering },
                new Criteria { Name = "Mass transfer", Tags = "mass transfer", Parent = mechanicalEngineering },
                new Criteria { Name = "Mechatronics", Tags = "mechatronics", Parent = mechanicalEngineering },
                new Criteria { Name = "Nanoengineering", Tags = "nanoengineering", Parent = mechanicalEngineering },
                new Criteria { Name = "Ocean engineering", Tags = "ocean engineering", Parent = mechanicalEngineering },
                new Criteria { Name = "Optical engineering", Tags = "optical engineering", Parent = mechanicalEngineering },
                new Criteria { Name = "Robotics", Tags = "robotics", Parent = mechanicalEngineering },
                new Criteria { Name = "Thermodynamics", Tags = "thermodynamics", Parent = mechanicalEngineering }
            };

             foreach (var thirdLevelCriteria in tmpThirdCritList)
             {
                 uow.Repository<Criteria>().Add(thirdLevelCriteria);
                 mechanicalEngineering.Children.Add(thirdLevelCriteria);
             }
        }
    }
}