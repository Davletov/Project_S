namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Chemistry(ref SecondLevelCriteria chemistry, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Agrochemistry", Tags = "agrochemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Analytical chemistry", Tags = "analytical chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Astrochemistry", Tags = "astrochemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Atmospheric chemistry", Tags = "atmospheric chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Biochemistry", Tags = "biochemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Chemical engineering", Tags = "chemical engineering", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Chemical biology", Tags = "chemical biology", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Cheminformatics", Tags = "cheminformatics", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Computational chemistry", Tags = "computational chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Cosmochemistry", Tags = "cosmochemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Electrochemistry", Tags = "electrochemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Environmental chemistry", Tags = "environmental chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Femtochemistry", Tags = "femtochemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Flavor", Tags = "flavor", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Flow chemistry", Tags = "flow chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Geochemistry", Tags = "geochemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Green chemistry", Tags = "green chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Histochemistry", Tags = "histochemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Hydrogenation", Tags = "hydrogenation", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Immunochemistry", Tags = "immunochemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Inorganic chemistry", Tags = "inorganic chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Marine chemistry", Tags = "marine chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Mathematical chemistry", Tags = "mathematical chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Mechanochemistry", Tags = "mechanochemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Medicinal chemistry", Tags = "medicinal chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Molecular biology", Tags = "molecular biology", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Molecular mechanics", Tags = "molecular mechanics", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Nanotechnology", Tags = "nanotechnology", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Natural product chemistry", Tags = "natural product chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Neurochemistry", Tags = "neurochemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Oenology", Tags = "oenology", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Organic chemistry", Tags = "organic chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Organometallic chemistry", Tags = "organometallic chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Petrochemistry", Tags = "petrochemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Pharmacology", Tags = "pharmacology", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Photochemistry", Tags = "photochemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Physical chemistry", Tags = "physical chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Physical organic chemistry", Tags = "physical organic chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Phytochemistry", Tags = "phytochemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Polymer chemistry", Tags = "polymer chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Quantum chemistry", Tags = "quantum chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Radiochemistry", Tags = "radiochemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Solid-state chemistry", Tags = "solid-state chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Sonochemistry", Tags = "sonochemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Supramolecular chemistry", Tags = "supramolecular chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Surface chemistry", Tags = "surface chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Synthetic chemistry", Tags = "synthetic chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Theoretical chemistry", Tags = "theoretical chemistry", SecondLevelCriteria = chemistry },
                new ThirdLevelCriteria { Name = "Thermochemistry", Tags = "thermochemistry", SecondLevelCriteria = chemistry }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                chemistry.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}