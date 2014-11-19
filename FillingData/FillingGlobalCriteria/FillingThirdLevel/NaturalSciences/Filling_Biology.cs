using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Biology(ref Criteria biology, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Aerobiology", Tags = "aerobiology", Parent = biology },
                new Criteria { Name = "Comparative anatomy", Tags = "comparative anatomy,anatomy", Parent = biology },
                new Criteria { Name = "Human anatomy", Tags = "human anatomy,anatomy", Parent = biology },
                new Criteria { Name = "Biochemistry", Tags = "biochemistry", Parent = biology },
                new Criteria { Name = "Bioinformatics", Tags = "bioinformatics", Parent = biology },
                new Criteria { Name = "Biophysics", Tags = "biophysics", Parent = biology },
                new Criteria { Name = "Biotechnology", Tags = "biotechnology", Parent = biology },
                new Criteria { Name = "Ethnobotany", Tags = "ethnobotany,botany", Parent = biology },
                new Criteria { Name = "Phycology", Tags = "phycology,botany", Parent = biology },
                new Criteria { Name = "Cell biology", Tags = "cell biology", Parent = biology },
                new Criteria { Name = "Chronobiology", Tags = "chronobiology", Parent = biology },
                new Criteria { Name = "Computational biology", Tags = "computational biology", Parent = biology },
                new Criteria { Name = "Cryobiology", Tags = "cryobiology", Parent = biology },
                new Criteria { Name = "Embryology", Tags = "embryology,developmental biology", Parent = biology },
                new Criteria { Name = "Teratology", Tags = "teratology,developmental biology", Parent = biology },
                new Criteria { Name = "Agroecology", Tags = "agroecology,ecology", Parent = biology },
                new Criteria { Name = "Ethnoecology", Tags = "ethnoecology,ecology", Parent = biology },
                new Criteria { Name = "Human ecology", Tags = "human ecology,ecology", Parent = biology },
                new Criteria { Name = "Landscape ecology", Tags = "landscape ecology,ecology", Parent = biology },
                new Criteria { Name = "Behavioural genetics", Tags = "behavioural genetics,genetics", Parent = biology },
                new Criteria { Name = "Molecular genetics", Tags = "molecular genetics,genetics", Parent = biology },
                new Criteria { Name = "Population genetics", Tags = "population genetics,genetics", Parent = biology },
                new Criteria { Name = "Endocrinology", Tags = "endocrinology", Parent = biology },
                new Criteria { Name = "Evolutionary biology", Tags = "evolutionary biology", Parent = biology },
                new Criteria { Name = "Human biology", Tags = "human biology", Parent = biology },
                new Criteria { Name = "Immunology", Tags = "immunology", Parent = biology },
                new Criteria { Name = "Limnology", Tags = "limnology", Parent = biology },
                new Criteria { Name = "Linnaean taxonomy", Tags = "linnaean taxonomy", Parent = biology },
                new Criteria { Name = "Marine biology", Tags = "marine biology", Parent = biology },
                new Criteria { Name = "Mathematical biology", Tags = "mathematical biology", Parent = biology },
                new Criteria { Name = "Microbiology", Tags = "microbiology", Parent = biology },
                new Criteria { Name = "Molecular biology", Tags = "molecular biology", Parent = biology },
                new Criteria { Name = "Mycology", Tags = "mycology", Parent = biology },
                new Criteria { Name = "Nutrition", Tags = "nutrition", Parent = biology },
                new Criteria { Name = "Behavioral neuroscience", Tags = "behavioral neuroscience,neuroscience", Parent = biology },
                new Criteria { Name = "Paleontology", Tags = "paleontology,paleobiology", Parent = biology },
                new Criteria { Name = "Parasitology", Tags = "parasitology", Parent = biology },
                new Criteria { Name = "Pathology", Tags = "pathology", Parent = biology },
                new Criteria { Name = "Human physiology", Tags = "human physiology", Parent = biology },
                new Criteria { Name = "Systematics", Tags = "systematics,taxonomy", Parent = biology },
                new Criteria { Name = "Systems biology", Tags = "systems biology", Parent = biology },
                new Criteria { Name = "Molecular virology", Tags = "molecular virology,virology", Parent = biology },
                new Criteria { Name = "Xenobiology", Tags = "xenobiology", Parent = biology },
                new Criteria { Name = "Animal communications", Tags = "animal communications,zoology", Parent = biology },
                new Criteria { Name = "Apiology", Tags = "apiology,zoology", Parent = biology },
                new Criteria { Name = "Arachnology", Tags = "arachnology,zoology", Parent = biology },
                new Criteria { Name = "Carcinology", Tags = "carcinology,zoology", Parent = biology },
                new Criteria { Name = "Cetology", Tags = "cetology,zoology", Parent = biology },
                new Criteria { Name = "Entomology", Tags = "entomology,zoology", Parent = biology },
                new Criteria { Name = "Ethnozoology", Tags = "ethnozoology,zoology", Parent = biology },
                new Criteria { Name = "Ethology", Tags = "ethology,zoology", Parent = biology },
                new Criteria { Name = "Helminthology", Tags = "helminthology,zoology", Parent = biology },
                new Criteria { Name = "Herpetology", Tags = "herpetology,zoology", Parent = biology },
                new Criteria { Name = "Ichthyology", Tags = "ichthyology,zoology", Parent = biology },
                new Criteria { Name = "Mammalogy", Tags = "mammalogy,zoology", Parent = biology },
                new Criteria { Name = "Malacology", Tags = "malacology,zoology", Parent = biology },
                new Criteria { Name = "Conchology", Tags = "conchology,zoology", Parent = biology },
                new Criteria { Name = "Myrmecology", Tags = "myrmecology,zoology", Parent = biology },
                new Criteria { Name = "Nematology", Tags = "nematology,zoology", Parent = biology },
                new Criteria { Name = "Neuroethology", Tags = "neuroethology,zoology", Parent = biology },
                new Criteria { Name = "Oology", Tags = "oology,zoology", Parent = biology },
                new Criteria { Name = "Ornithology", Tags = "ornithology,zoology", Parent = biology },
                new Criteria { Name = "Planktology", Tags = "planktology,zoology", Parent = biology },
                new Criteria { Name = "Primatology", Tags = "primatology,zoology", Parent = biology },
                new Criteria { Name = "Zootomy", Tags = "zootomy,zoology", Parent = biology },
                new Criteria { Name = "Zoosemiotics", Tags = "zoosemiotics,zoology", Parent = biology }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                biology.Children.Add(thirdLevelCriteria);
            }
        }
    }
}