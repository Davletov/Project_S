using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingSecondLevel
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;    
    using FiilingData.FillingGlobalCriteria.FillingThirdLevel;

    public partial class FillingSecondLevelCriteria
    {
        public static void Filling_SocialSciences(ref Criteria socialSciences, UnitOfWork uow)
        {
            var tmpSecondCritList = new List<Criteria>();
            var item_1 = new Criteria { Name = "Anthropology", Tags = "anthropology", Parent = socialSciences, Children = new Collection<Criteria>()};
            FillingThirdLevelCriteria.Filling_Anthropology(ref item_1, uow);
            tmpSecondCritList.Add(item_1);

            var item_2 = new Criteria { Name = "Archaeology", Tags = "archaeology", Parent = socialSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Archaeology(ref item_2, uow);
            tmpSecondCritList.Add(item_2);

            var item_3 = new Criteria { Name = "Area studies", Tags = "area studies", Parent = socialSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_AreaStudies(ref item_3, uow);
            tmpSecondCritList.Add(item_3);

            var item_4 = new Criteria { Name = "Cultural and ethnic studies", Tags = "cultural and ethnic studies", Parent = socialSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_CulturalEthnic(ref item_4, uow);
            tmpSecondCritList.Add(item_4);

            var item_5 = new Criteria { Name = "Economics", Tags = "economics", Parent = socialSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Economics(ref item_5, uow);
            tmpSecondCritList.Add(item_5);

            var item_6 = new Criteria { Name = "Gender and sexuality studies", Tags = "gender and sexuality studies", Parent = socialSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_GenderSexuality(ref item_6, uow);
            tmpSecondCritList.Add(item_6);

            var item_7 = new Criteria { Name = "Geography", Tags = "geography", Parent = socialSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Geography(ref item_7, uow);
            tmpSecondCritList.Add(item_7);

            var item_8 = new Criteria { Name = "Political science", Tags = "political science", Parent = socialSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_PoliticalScience(ref item_8, uow);
            tmpSecondCritList.Add(item_8);

            var item_9 = new Criteria { Name = "Psychology", Tags = "psychology", Parent = socialSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Psychology(ref item_9, uow);
            tmpSecondCritList.Add(item_9);

            var item_10 = new Criteria { Name = "Sociology", Tags = "sociology", Parent = socialSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Sociology(ref item_10, uow);
            tmpSecondCritList.Add(item_10);

            foreach (var secondLevelCriteria in tmpSecondCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(secondLevelCriteria);
                socialSciences.Children.Add(secondLevelCriteria);
            }
        }
    }
}