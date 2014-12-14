using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_ChemicalEngineering(ref Criteria chemicalEngineering, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Biochemical Engineering", Tags = "biochemical engineering,bioengineering", Parent = chemicalEngineering },
                new Criteria { Name = "Catalysis", Tags = "catalysis", Parent = chemicalEngineering },
                new Criteria { Name = "Molecular engineering", Tags = "molecular engineering", Parent = chemicalEngineering },
                new Criteria { Name = "Nanotechnology", Tags = "nanotechnology", Parent = chemicalEngineering },
                new Criteria { Name = "Polymer engineering", Tags = "polymer engineering", Parent = chemicalEngineering },
                new Criteria { Name = "Petroleum engineering", Tags = "petroleum engineering,process design", Parent = chemicalEngineering },
                new Criteria { Name = "Nuclear engineering", Tags = "nuclear engineering,process design", Parent = chemicalEngineering },
                new Criteria { Name = "Food engineering", Tags = "food engineering,process design", Parent = chemicalEngineering },
                new Criteria { Name = "Reaction engineering", Tags = "reaction engineering", Parent = chemicalEngineering },
                new Criteria { Name = "Thermodynamics", Tags = "thermodynamics", Parent = chemicalEngineering },
                new Criteria { Name = "Transport phenomena", Tags = "transport phenomena", Parent = chemicalEngineering }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                chemicalEngineering.Children.Add(thirdLevelCriteria);
            }
        }
    }
}