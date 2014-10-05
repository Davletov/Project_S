using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Biology(ref SecondLevelCriteria biology, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Aerobiology", Tags = "aerobiology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Comparative anatomy", Tags = "comparative anatomy,anatomy", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Human anatomy", Tags = "human anatomy,anatomy", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Biochemistry", Tags = "biochemistry", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Bioinformatics", Tags = "bioinformatics", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Biophysics", Tags = "biophysics", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Biotechnology", Tags = "biotechnology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Ethnobotany", Tags = "ethnobotany,botany", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Phycology", Tags = "phycology,botany", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Cell biology", Tags = "cell biology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Chronobiology", Tags = "chronobiology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Computational biology", Tags = "computational biology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Cryobiology", Tags = "cryobiology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Embryology", Tags = "embryology,developmental biology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Teratology", Tags = "teratology,developmental biology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Agroecology", Tags = "agroecology,ecology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Ethnoecology", Tags = "ethnoecology,ecology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Human ecology", Tags = "human ecology,ecology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Landscape ecology", Tags = "landscape ecology,ecology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Behavioural genetics", Tags = "behavioural genetics,genetics", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Molecular genetics", Tags = "molecular genetics,genetics", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Population genetics", Tags = "population genetics,genetics", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Endocrinology", Tags = "endocrinology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Evolutionary biology", Tags = "evolutionary biology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Human biology", Tags = "human biology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Immunology", Tags = "immunology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Limnology", Tags = "limnology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Linnaean taxonomy", Tags = "linnaean taxonomy", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Marine biology", Tags = "marine biology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Mathematical biology", Tags = "mathematical biology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Microbiology", Tags = "microbiology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Molecular biology", Tags = "molecular biology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Mycology", Tags = "mycology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Nutrition", Tags = "nutrition", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Behavioral neuroscience", Tags = "behavioral neuroscience,neuroscience", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Paleontology", Tags = "paleontology,paleobiology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Parasitology", Tags = "parasitology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Pathology", Tags = "pathology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Human physiology", Tags = "human physiology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Systematics", Tags = "systematics,taxonomy", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Systems biology", Tags = "systems biology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Molecular virology", Tags = "molecular virology,virology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Xenobiology", Tags = "xenobiology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Animal communications", Tags = "animal communications,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Apiology", Tags = "apiology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Arachnology", Tags = "arachnology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Carcinology", Tags = "carcinology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Cetology", Tags = "cetology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Entomology", Tags = "entomology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Ethnozoology", Tags = "ethnozoology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Ethology", Tags = "ethology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Helminthology", Tags = "helminthology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Herpetology", Tags = "herpetology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Ichthyology", Tags = "ichthyology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Mammalogy", Tags = "mammalogy,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Malacology", Tags = "malacology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Conchology", Tags = "conchology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Myrmecology", Tags = "myrmecology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Nematology", Tags = "nematology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Neuroethology", Tags = "neuroethology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Oology", Tags = "oology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Ornithology", Tags = "ornithology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Planktology", Tags = "planktology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Primatology", Tags = "primatology,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Zootomy", Tags = "zootomy,zoology", SecondLevelCriteria = biology },
                new ThirdLevelCriteria { Name = "Zoosemiotics", Tags = "zoosemiotics,zoology", SecondLevelCriteria = biology }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                biology.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}