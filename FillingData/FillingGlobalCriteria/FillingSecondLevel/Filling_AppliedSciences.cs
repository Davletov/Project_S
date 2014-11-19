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
        public static void Filling_AppliedSciences(ref Criteria appliedSciences, UnitOfWork uow)
        {
            var tmpSecondCritList = new List<Criteria>();
            var item_1 = new Criteria { Name = "Agriculture", Tags = "agriculture", Parent = appliedSciences, Children = new Collection<Criteria>()};
            FillingThirdLevelCriteria.Filling_Agriculture(ref item_1, uow);
            tmpSecondCritList.Add(item_1);
            
            var item_2 = new Criteria { Name = "Architecture and design", Tags = "architecture,design", Parent = appliedSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_ArchitectureAndDesign(ref item_2, uow);
            tmpSecondCritList.Add(item_2);

            var item_3 = new Criteria { Name = "Business", Tags = "business", Parent = appliedSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Business(ref item_3, uow);
            tmpSecondCritList.Add(item_3);

            var item_4 = new Criteria { Name = "Divinity", Tags = "divinity", Parent = appliedSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Divinity(ref item_4, uow);
            tmpSecondCritList.Add(item_4);

            var item_5 = new Criteria { Name = "Education", Tags = "education", Parent = appliedSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Education(ref item_5, uow);
            tmpSecondCritList.Add(item_5);

            var item_6 = new Criteria { Name = "Environmental studies and forestry", Tags = "environmental studies and forestry", Parent = appliedSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_EnvironmentalAndForestry(ref item_6, uow);
            tmpSecondCritList.Add(item_6);

            var item_7 = new Criteria { Name = "Family and consumer science", Tags = "family and consumer science", Parent = appliedSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_FamilyAndConsumer(ref item_7, uow);
            tmpSecondCritList.Add(item_7);

            var item_8 = new Criteria { Name = "Healthcare science", Tags = "healthcare science", Parent = appliedSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_HealthcareScience(ref item_8, uow);
            tmpSecondCritList.Add(item_8);

            var item_9 = new Criteria { Name = "Human physical performance and recreation", Tags = "human physical performance,recreation", Parent = appliedSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_HumanPerformanceRecreation(ref item_9, uow);
            tmpSecondCritList.Add(item_9);

            var item_10 = new Criteria { Name = "Journalism, media studies and communication", Tags = "journalism, media studies and communication", Parent = appliedSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Journalism(ref item_10, uow);
            tmpSecondCritList.Add(item_10);

            var item_11 = new Criteria { Name = "Law", Tags = "law", Parent = appliedSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Law(ref item_11, uow);
            tmpSecondCritList.Add(item_11);

            var item_12 = new Criteria { Name = "Library and museum studies", Tags = "library studies,museum studies", Parent = appliedSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_LibraryMuseum(ref item_12, uow);
            tmpSecondCritList.Add(item_12);

            var item_13 = new Criteria { Name = "Military sciences", Tags = "military sciences", Parent = appliedSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Military(ref item_13, uow);
            tmpSecondCritList.Add(item_13);

            var item_14 = new Criteria { Name = "Public administration", Tags = "public administration", Parent = appliedSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_PublicAdministration(ref item_14, uow);
            tmpSecondCritList.Add(item_14);

            var item_15 = new Criteria { Name = "Social work", Tags = "social work", Parent = appliedSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_SocialWork(ref item_15, uow);
            tmpSecondCritList.Add(item_15);

            var item_16 = new Criteria { Name = "Transportation", Tags = "transportation", Parent = appliedSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Transportation(ref item_16, uow);
            tmpSecondCritList.Add(item_16);

            foreach (var secondLevelCriteria in tmpSecondCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(secondLevelCriteria);
                appliedSciences.Children.Add(secondLevelCriteria);
            }
        }
    }
}