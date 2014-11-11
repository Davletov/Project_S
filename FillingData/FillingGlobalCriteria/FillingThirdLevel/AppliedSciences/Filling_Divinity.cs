using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Divinity(ref Criteria divinity, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria {Name = "Canon law", Tags = "canon law", Parent = divinity},
                new Criteria {Name = "Church history", Tags = "church history", Parent = divinity},
                new Criteria {Name = "Pastoral counseling", Tags = "pastoral counseling,field ministry", Parent = divinity},
                new Criteria {Name = "Pastoral theology", Tags = "pastoral theology,field ministry", Parent = divinity},
                new Criteria {Name = "Religious education techniques", Tags = "religious education techniques,field ministry", Parent = divinity},
                new Criteria {Name = "Homiletics", Tags = "homiletics,field ministry", Parent = divinity},
                new Criteria {Name = "Liturgy", Tags = "liturgy,field ministry", Parent = divinity},
                new Criteria {Name = "Sacred music", Tags = "sacred music,field ministry", Parent = divinity},
                new Criteria {Name = "Missiology", Tags = "missiology,field ministry", Parent = divinity},
                new Criteria {Name = "Biblical Hebrew", Tags = "biblical Hebrew,scriptural study", Parent = divinity},
                new Criteria {Name = "Biblical studies", Tags = "biblical studies,sacred scripture,scriptural study", Parent = divinity},
                new Criteria {Name = "New Testament Greek", Tags = "new testament greek,scriptural study", Parent = divinity},
                new Criteria {Name = "Latin", Tags = "latin,scriptural study", Parent = divinity},
                new Criteria {Name = "Old Church Slavonic", Tags = "old church slavonic,scriptural study", Parent = divinity},
                new Criteria {Name = "Dogmatic theology", Tags = "dogmatic theology,theology", Parent = divinity},
                new Criteria {Name = "Ecclesiology", Tags = "ecclesiology,theology", Parent = divinity},
                new Criteria {Name = "Sacramental theology", Tags = "sacramental theology,theology", Parent = divinity},
                new Criteria {Name = "Systematic theology", Tags = "systematic theology,theology", Parent = divinity},
                new Criteria {Name = "Christian ethics", Tags = "christian ethics,theology", Parent = divinity}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                divinity.Children.Add(thirdLevelCriteria);
            }
        }
    }
}



