using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Economics(ref Criteria economics, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Agricultural economics", Tags = "agricultural economics", Parent = economics },
                new Criteria { Name = "Anarchist economics", Tags = "anarchist economics", Parent = economics },
                new Criteria { Name = "Behavioral economics", Tags = "behavioral economics", Parent = economics },
                new Criteria { Name = "Bioeconomics", Tags = "bioeconomics", Parent = economics },
                new Criteria { Name = "Complexity economics", Tags = "complexity economics", Parent = economics },
                new Criteria { Name = "Computational economics", Tags = "computational economics", Parent = economics },
                new Criteria { Name = "Consumer economics", Tags = "consumer economics", Parent = economics },
                new Criteria { Name = "Development economics", Tags = "development economics", Parent = economics },
                new Criteria { Name = "Ecological economics", Tags = "ecological economics", Parent = economics },
                new Criteria { Name = "Econometrics", Tags = "econometrics", Parent = economics },
                new Criteria { Name = "Economic geography", Tags = "economic geography", Parent = economics },
                new Criteria { Name = "Economic history", Tags = "economic history", Parent = economics },
                new Criteria { Name = "Economic sociology", Tags = "economic sociology", Parent = economics },
                new Criteria { Name = "Economic systems", Tags = "economic systems", Parent = economics },
                new Criteria { Name = "Energy economics", Tags = "energy economics", Parent = economics },
                new Criteria { Name = "Entrepreneurial economics", Tags = "entrepreneurial economics", Parent = economics },
                new Criteria { Name = "Environmental economics", Tags = "environmental economics", Parent = economics },
                new Criteria { Name = "Evolutionary economics", Tags = "evolutionary economics", Parent = economics },
                new Criteria { Name = "experimental economics", Tags = "experimental economics", Parent = economics },
                new Criteria { Name = "Feminist economics", Tags = "feminist economics", Parent = economics },
                new Criteria { Name = "Financial economics", Tags = "financial economics", Parent = economics },
                new Criteria { Name = "Financial econometrics", Tags = "financial econometrics", Parent = economics },
                new Criteria { Name = "Green economics", Tags = "green economics", Parent = economics },
                new Criteria { Name = "Growth economics", Tags = "growth economics", Parent = economics },
                new Criteria { Name = "Human development theory", Tags = "human development theory", Parent = economics },
                new Criteria { Name = "Industrial organization", Tags = "industrial organization", Parent = economics },
                new Criteria { Name = "Information economics", Tags = "information economics", Parent = economics },
                new Criteria { Name = "Institutional economics", Tags = "institutional economics", Parent = economics },
                new Criteria { Name = "International economics", Tags = "international economics", Parent = economics },
                new Criteria { Name = "Islamic economics", Tags = "islamic economics", Parent = economics },
                new Criteria { Name = "Labor economics", Tags = "labor economics", Parent = economics },
                new Criteria { Name = "Law and economics", Tags = "law and economics", Parent = economics },
                new Criteria { Name = "Macroeconomics", Tags = "macroeconomics", Parent = economics },
                new Criteria { Name = "Managerial economics", Tags = "managerial economics", Parent = economics },
                new Criteria { Name = "Marxian economics", Tags = "marxian economics", Parent = economics },
                new Criteria { Name = "Mathematical economics", Tags = "mathematical economics", Parent = economics },
                new Criteria { Name = "Microeconomics", Tags = "microeconomics", Parent = economics },
                new Criteria { Name = "Monetary economics", Tags = "monetary economics", Parent = economics },
                new Criteria { Name = "Neuroeconomics", Tags = "neuroeconomics", Parent = economics },
                new Criteria { Name = "Participatory economics", Tags = "participatory economics", Parent = economics },
                new Criteria { Name = "Political economy", Tags = "political economy", Parent = economics },
                new Criteria { Name = "Public finance", Tags = "public finance", Parent = economics },
                new Criteria { Name = "Public economics", Tags = "public economics", Parent = economics },
                new Criteria { Name = "Real estate economics", Tags = "real estate economics", Parent = economics },
                new Criteria { Name = "Resource economics", Tags = "resource economics", Parent = economics },
                new Criteria { Name = "Social choice theory", Tags = "social choice theory", Parent = economics },
                new Criteria { Name = "Socialist economics", Tags = "socialist economics", Parent = economics },
                new Criteria { Name = "Socioeconomics", Tags = "socioeconomics", Parent = economics },
                new Criteria { Name = "Transport economics", Tags = "transport economics", Parent = economics },
                new Criteria { Name = "Welfare economics", Tags = "welfare economics", Parent = economics }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                economics.Children.Add(thirdLevelCriteria);
            }
        }
    }
}