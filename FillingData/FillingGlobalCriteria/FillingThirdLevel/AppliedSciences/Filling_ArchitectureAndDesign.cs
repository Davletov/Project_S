using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_ArchitectureAndDesign(ref Criteria architectureAndDesign, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Architecture", Tags = "Architecture,related design", Parent = architectureAndDesign },
                new Criteria { Name = "Urban planning", Tags = "urban design,related design", Parent = architectureAndDesign },
                new Criteria { Name = "Interior design", Tags = "urban design,interior architecture,related design", Parent = architectureAndDesign },
                new Criteria { Name = "Landscape architecture", Tags = "landscape planning,landscape architecture,related design", Parent = architectureAndDesign },
                new Criteria { Name = "Architectural analytics", Tags = "architectural analytics", Parent = architectureAndDesign },
                new Criteria { Name = "Historic preservation", Tags = "historic preservation", Parent = architectureAndDesign },
                new Criteria { Name = "Graphic design", Tags = "graphic design,visual communication", Parent = architectureAndDesign },
                new Criteria { Name = "Type design", Tags = "type design,visual communication", Parent = architectureAndDesign },
                new Criteria { Name = "Technical drawing", Tags = "technical drawing,visual communication", Parent = architectureAndDesign },
                new Criteria { Name = "Ergonomics", Tags = "ergonomics,industrial design,product design", Parent = architectureAndDesign },
                new Criteria { Name = "Game design", Tags = "game design,industrial design,product design", Parent = architectureAndDesign },
                new Criteria { Name = "Toy and amusement design", Tags = "toy design,industrial design,product design", Parent = architectureAndDesign },
                new Criteria { Name = "Interaction design", Tags = "interaction design,user experience design", Parent = architectureAndDesign },
                new Criteria { Name = "Information architecture", Tags = "information architecture,user experience design", Parent = architectureAndDesign },
                new Criteria { Name = "User interface design", Tags = "user interface design,user experience design", Parent = architectureAndDesign },
                new Criteria { Name = "User experience evaluation", Tags = "user experience evaluation,user experience design", Parent = architectureAndDesign },
                new Criteria { Name = "Fashion design", Tags = "fashion design", Parent = architectureAndDesign },
                new Criteria { Name = "Textile design", Tags = "textile design", Parent = architectureAndDesign }
            };


            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                architectureAndDesign.Children.Add(thirdLevelCriteria);
            }
        }
    }
}
