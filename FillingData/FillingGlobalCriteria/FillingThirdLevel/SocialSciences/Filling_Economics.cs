using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Economics(ref SecondLevelCriteria economics, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Agricultural economics", Tags = "agricultural economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Anarchist economics", Tags = "anarchist economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Behavioral economics", Tags = "behavioral economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Bioeconomics", Tags = "bioeconomics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Complexity economics", Tags = "complexity economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Computational economics", Tags = "computational economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Consumer economics", Tags = "consumer economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Development economics", Tags = "development economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Ecological economics", Tags = "ecological economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Econometrics", Tags = "econometrics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Economic geography", Tags = "economic geography", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Economic history", Tags = "economic history", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Economic sociology", Tags = "economic sociology", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Economic systems", Tags = "economic systems", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Energy economics", Tags = "energy economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Entrepreneurial economics", Tags = "entrepreneurial economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Environmental economics", Tags = "environmental economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Evolutionary economics", Tags = "evolutionary economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "experimental economics", Tags = "experimental economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Feminist economics", Tags = "feminist economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Financial economics", Tags = "financial economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Financial econometrics", Tags = "financial econometrics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Green economics", Tags = "green economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Growth economics", Tags = "growth economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Human development theory", Tags = "human development theory", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Industrial organization", Tags = "industrial organization", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Information economics", Tags = "information economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Institutional economics", Tags = "institutional economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "International economics", Tags = "international economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Islamic economics", Tags = "islamic economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Labor economics", Tags = "labor economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Law and economics", Tags = "law and economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Macroeconomics", Tags = "macroeconomics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Managerial economics", Tags = "managerial economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Marxian economics", Tags = "marxian economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Mathematical economics", Tags = "mathematical economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Microeconomics", Tags = "microeconomics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Monetary economics", Tags = "monetary economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Neuroeconomics", Tags = "neuroeconomics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Participatory economics", Tags = "participatory economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Political economy", Tags = "political economy", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Public finance", Tags = "public finance", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Public economics", Tags = "public economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Real estate economics", Tags = "real estate economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Resource economics", Tags = "resource economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Social choice theory", Tags = "social choice theory", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Socialist economics", Tags = "socialist economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Socioeconomics", Tags = "socioeconomics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Transport economics", Tags = "transport economics", SecondLevelCriteria = economics },
                new ThirdLevelCriteria { Name = "Welfare economics", Tags = "welfare economics", SecondLevelCriteria = economics }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                economics.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}