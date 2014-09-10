namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_ArchitectureAndDesign(ref SecondLevelCriteria architectureAndDesign, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Architecture", Tags = "Architecture,related design", SecondLevelCriteria = architectureAndDesign },
                new ThirdLevelCriteria { Name = "Urban planning", Tags = "urban design,related design", SecondLevelCriteria = architectureAndDesign },
                new ThirdLevelCriteria { Name = "Interior design", Tags = "urban design,interior architecture,related design", SecondLevelCriteria = architectureAndDesign },
                new ThirdLevelCriteria { Name = "Landscape architecture", Tags = "landscape planning,landscape architecture,related design", SecondLevelCriteria = architectureAndDesign },
                new ThirdLevelCriteria { Name = "Architectural analytics", Tags = "architectural analytics", SecondLevelCriteria = architectureAndDesign },
                new ThirdLevelCriteria { Name = "Historic preservation", Tags = "historic preservation", SecondLevelCriteria = architectureAndDesign },
                new ThirdLevelCriteria { Name = "Graphic design", Tags = "graphic design,visual communication", SecondLevelCriteria = architectureAndDesign },
                new ThirdLevelCriteria { Name = "Type design", Tags = "type design,visual communication", SecondLevelCriteria = architectureAndDesign },
                new ThirdLevelCriteria { Name = "Technical drawing", Tags = "technical drawing,visual communication", SecondLevelCriteria = architectureAndDesign },
                new ThirdLevelCriteria { Name = "Ergonomics", Tags = "ergonomics,industrial design,product design", SecondLevelCriteria = architectureAndDesign },
                new ThirdLevelCriteria { Name = "Game design", Tags = "game design,industrial design,product design", SecondLevelCriteria = architectureAndDesign },
                new ThirdLevelCriteria { Name = "Toy and amusement design", Tags = "toy design,industrial design,product design", SecondLevelCriteria = architectureAndDesign },
                new ThirdLevelCriteria { Name = "Interaction design", Tags = "interaction design,user experience design", SecondLevelCriteria = architectureAndDesign },
                new ThirdLevelCriteria { Name = "Information architecture", Tags = "information architecture,user experience design", SecondLevelCriteria = architectureAndDesign },
                new ThirdLevelCriteria { Name = "User interface design", Tags = "user interface design,user experience design", SecondLevelCriteria = architectureAndDesign },
                new ThirdLevelCriteria { Name = "User experience evaluation", Tags = "user experience evaluation,user experience design", SecondLevelCriteria = architectureAndDesign },
                new ThirdLevelCriteria { Name = "Fashion design", Tags = "fashion design", SecondLevelCriteria = architectureAndDesign },
                new ThirdLevelCriteria { Name = "Textile design", Tags = "textile design", SecondLevelCriteria = architectureAndDesign }
            };


            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                architectureAndDesign.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}
