using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Chemistry(ref Criteria chemistry, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Agrochemistry", Tags = "agrochemistry", Parent = chemistry },
                new Criteria { Name = "Analytical chemistry", Tags = "analytical chemistry", Parent = chemistry },
                new Criteria { Name = "Astrochemistry", Tags = "astrochemistry", Parent = chemistry },
                new Criteria { Name = "Atmospheric chemistry", Tags = "atmospheric chemistry", Parent = chemistry },
                new Criteria { Name = "Biochemistry", Tags = "biochemistry", Parent = chemistry },
                new Criteria { Name = "Chemical engineering", Tags = "chemical engineering", Parent = chemistry },
                new Criteria { Name = "Chemical biology", Tags = "chemical biology", Parent = chemistry },
                new Criteria { Name = "Cheminformatics", Tags = "cheminformatics", Parent = chemistry },
                new Criteria { Name = "Computational chemistry", Tags = "computational chemistry", Parent = chemistry },
                new Criteria { Name = "Cosmochemistry", Tags = "cosmochemistry", Parent = chemistry },
                new Criteria { Name = "Electrochemistry", Tags = "electrochemistry", Parent = chemistry },
                new Criteria { Name = "Environmental chemistry", Tags = "environmental chemistry", Parent = chemistry },
                new Criteria { Name = "Femtochemistry", Tags = "femtochemistry", Parent = chemistry },
                new Criteria { Name = "Flavor", Tags = "flavor", Parent = chemistry },
                new Criteria { Name = "Flow chemistry", Tags = "flow chemistry", Parent = chemistry },
                new Criteria { Name = "Geochemistry", Tags = "geochemistry", Parent = chemistry },
                new Criteria { Name = "Green chemistry", Tags = "green chemistry", Parent = chemistry },
                new Criteria { Name = "Histochemistry", Tags = "histochemistry", Parent = chemistry },
                new Criteria { Name = "Hydrogenation", Tags = "hydrogenation", Parent = chemistry },
                new Criteria { Name = "Immunochemistry", Tags = "immunochemistry", Parent = chemistry },
                new Criteria { Name = "Inorganic chemistry", Tags = "inorganic chemistry", Parent = chemistry },
                new Criteria { Name = "Marine chemistry", Tags = "marine chemistry", Parent = chemistry },
                new Criteria { Name = "Mathematical chemistry", Tags = "mathematical chemistry", Parent = chemistry },
                new Criteria { Name = "Mechanochemistry", Tags = "mechanochemistry", Parent = chemistry },
                new Criteria { Name = "Medicinal chemistry", Tags = "medicinal chemistry", Parent = chemistry },
                new Criteria { Name = "Molecular biology", Tags = "molecular biology", Parent = chemistry },
                new Criteria { Name = "Molecular mechanics", Tags = "molecular mechanics", Parent = chemistry },
                new Criteria { Name = "Nanotechnology", Tags = "nanotechnology", Parent = chemistry },
                new Criteria { Name = "Natural product chemistry", Tags = "natural product chemistry", Parent = chemistry },
                new Criteria { Name = "Neurochemistry", Tags = "neurochemistry", Parent = chemistry },
                new Criteria { Name = "Oenology", Tags = "oenology", Parent = chemistry },
                new Criteria { Name = "Organic chemistry", Tags = "organic chemistry", Parent = chemistry },
                new Criteria { Name = "Organometallic chemistry", Tags = "organometallic chemistry", Parent = chemistry },
                new Criteria { Name = "Petrochemistry", Tags = "petrochemistry", Parent = chemistry },
                new Criteria { Name = "Pharmacology", Tags = "pharmacology", Parent = chemistry },
                new Criteria { Name = "Photochemistry", Tags = "photochemistry", Parent = chemistry },
                new Criteria { Name = "Physical chemistry", Tags = "physical chemistry", Parent = chemistry },
                new Criteria { Name = "Physical organic chemistry", Tags = "physical organic chemistry", Parent = chemistry },
                new Criteria { Name = "Phytochemistry", Tags = "phytochemistry", Parent = chemistry },
                new Criteria { Name = "Polymer chemistry", Tags = "polymer chemistry", Parent = chemistry },
                new Criteria { Name = "Quantum chemistry", Tags = "quantum chemistry", Parent = chemistry },
                new Criteria { Name = "Radiochemistry", Tags = "radiochemistry", Parent = chemistry },
                new Criteria { Name = "Solid-state chemistry", Tags = "solid-state chemistry", Parent = chemistry },
                new Criteria { Name = "Sonochemistry", Tags = "sonochemistry", Parent = chemistry },
                new Criteria { Name = "Supramolecular chemistry", Tags = "supramolecular chemistry", Parent = chemistry },
                new Criteria { Name = "Surface chemistry", Tags = "surface chemistry", Parent = chemistry },
                new Criteria { Name = "Synthetic chemistry", Tags = "synthetic chemistry", Parent = chemistry },
                new Criteria { Name = "Theoretical chemistry", Tags = "theoretical chemistry", Parent = chemistry },
                new Criteria { Name = "Thermochemistry", Tags = "thermochemistry", Parent = chemistry }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                chemistry.Children.Add(thirdLevelCriteria);
            }
        }
    }
}