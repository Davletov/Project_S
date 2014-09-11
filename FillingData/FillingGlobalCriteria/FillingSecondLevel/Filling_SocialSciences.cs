namespace FiilingData.FillingGlobalCriteria.FillingSecondLevel
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;
    using Web.UnitOfWork;
    using FiilingData.FillingGlobalCriteria.FillingThirdLevel;

    public partial class FillingSecondLevelCriteria
    {
        public static void Filling_SocialSciences(ref FirstLevelCriteria socialSciences, UnitOfWork uow)
        {
            var tmpSecondCritList = new List<SecondLevelCriteria>();
            var item_1 = new SecondLevelCriteria { Name = "Anthropology", Tags = "anthropology", FirstLevelCriteria = socialSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>()};
            FillingThirdLevelCriteria.Filling_Anthropology(ref item_1, uow);
            tmpSecondCritList.Add(item_1);

            var item_2 = new SecondLevelCriteria { Name = "Archaeology", Tags = "archaeology", FirstLevelCriteria = socialSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Archaeology(ref item_2, uow);
            tmpSecondCritList.Add(item_2);

            var item_3 = new SecondLevelCriteria { Name = "Area studies", Tags = "area studies", FirstLevelCriteria = socialSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_AreaStudies(ref item_3, uow);
            tmpSecondCritList.Add(item_3);

            var item_4 = new SecondLevelCriteria { Name = "Cultural and ethnic studies", Tags = "cultural and ethnic studies", FirstLevelCriteria = socialSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_CulturalEthnic(ref item_4, uow);
            tmpSecondCritList.Add(item_4);

            var item_5 = new SecondLevelCriteria { Name = "Economics", Tags = "economics", FirstLevelCriteria = socialSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Economics(ref item_5, uow);
            tmpSecondCritList.Add(item_5);

            var item_6 = new SecondLevelCriteria { Name = "Gender and sexuality studies", Tags = "gender and sexuality studies", FirstLevelCriteria = socialSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_GenderSexuality(ref item_6, uow);
            tmpSecondCritList.Add(item_6);

            var item_7 = new SecondLevelCriteria { Name = "Geography", Tags = "geography", FirstLevelCriteria = socialSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Geography(ref item_7, uow);
            tmpSecondCritList.Add(item_7);

            var item_8 = new SecondLevelCriteria { Name = "Political science", Tags = "political science", FirstLevelCriteria = socialSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_PoliticalScience(ref item_8, uow);
            tmpSecondCritList.Add(item_8);

            var item_9 = new SecondLevelCriteria { Name = "Psychology", Tags = "psychology", FirstLevelCriteria = socialSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Psychology(ref item_9, uow);
            tmpSecondCritList.Add(item_9);

            var item_10 = new SecondLevelCriteria { Name = "Sociology", Tags = "sociology", FirstLevelCriteria = socialSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Sociology(ref item_10, uow);
            tmpSecondCritList.Add(item_10);

            foreach (var secondLevelCriteria in tmpSecondCritList)
            {
                uow.SecondLevelCriteriaRepository.Add(secondLevelCriteria);
                socialSciences.SecondLevelCriteria.Add(secondLevelCriteria);
            }
        }
    }
}