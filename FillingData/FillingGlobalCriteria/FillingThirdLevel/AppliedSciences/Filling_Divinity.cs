using System.Collections.Generic;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Divinity(ref SecondLevelCriteria divinity, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria {Name = "Canon law", Tags = "canon law", SecondLevelCriteria = divinity},
                new ThirdLevelCriteria {Name = "Church history", Tags = "church history", SecondLevelCriteria = divinity},
                new ThirdLevelCriteria {Name = "Pastoral counseling", Tags = "pastoral counseling,field ministry", SecondLevelCriteria = divinity},
                new ThirdLevelCriteria {Name = "Pastoral theology", Tags = "pastoral theology,field ministry", SecondLevelCriteria = divinity},
                new ThirdLevelCriteria {Name = "Religious education techniques", Tags = "religious education techniques,field ministry", SecondLevelCriteria = divinity},
                new ThirdLevelCriteria {Name = "Homiletics", Tags = "homiletics,field ministry", SecondLevelCriteria = divinity},
                new ThirdLevelCriteria {Name = "Liturgy", Tags = "liturgy,field ministry", SecondLevelCriteria = divinity},
                new ThirdLevelCriteria {Name = "Sacred music", Tags = "sacred music,field ministry", SecondLevelCriteria = divinity},
                new ThirdLevelCriteria {Name = "Missiology", Tags = "missiology,field ministry", SecondLevelCriteria = divinity},
                new ThirdLevelCriteria {Name = "Biblical Hebrew", Tags = "biblical Hebrew,scriptural study", SecondLevelCriteria = divinity},
                new ThirdLevelCriteria {Name = "Biblical studies", Tags = "biblical studies,sacred scripture,scriptural study", SecondLevelCriteria = divinity},
                new ThirdLevelCriteria {Name = "New Testament Greek", Tags = "new testament greek,scriptural study", SecondLevelCriteria = divinity},
                new ThirdLevelCriteria {Name = "Latin", Tags = "latin,scriptural study", SecondLevelCriteria = divinity},
                new ThirdLevelCriteria {Name = "Old Church Slavonic", Tags = "old church slavonic,scriptural study", SecondLevelCriteria = divinity},
                new ThirdLevelCriteria {Name = "Dogmatic theology", Tags = "dogmatic theology,theology", SecondLevelCriteria = divinity},
                new ThirdLevelCriteria {Name = "Ecclesiology", Tags = "ecclesiology,theology", SecondLevelCriteria = divinity},
                new ThirdLevelCriteria {Name = "Sacramental theology", Tags = "sacramental theology,theology", SecondLevelCriteria = divinity},
                new ThirdLevelCriteria {Name = "Systematic theology", Tags = "systematic theology,theology", SecondLevelCriteria = divinity},
                new ThirdLevelCriteria {Name = "Christian ethics", Tags = "christian ethics,theology", SecondLevelCriteria = divinity}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                divinity.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}



