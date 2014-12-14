using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Religion(ref Criteria religion, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Baha'i Faith", Tags = "baha'i faith,abrahamic religions", Parent = religion },
                new Criteria { Name = "Bibliology", Tags = "bibliology,christianity,abrahamic religions", Parent = religion },
                new Criteria { Name = "Hermeneutics", Tags = "hermeneutics,christianity,abrahamic religions", Parent = religion },
                new Criteria { Name = "Christology", Tags = "christology,christianity,abrahamic religions", Parent = religion },
                new Criteria { Name = "Pneumatology", Tags = "pneumatology,christianity,abrahamic religions", Parent = religion },
                new Criteria { Name = "Demonology", Tags = "demonology,christianity,abrahamic religions", Parent = religion },
                new Criteria { Name = "Theological anthropology", Tags = "theological anthropology,christianity,abrahamic religions", Parent = religion },
                new Criteria { Name = "Soteriology", Tags = "soteriology,christianity,abrahamic religions", Parent = religion },
                new Criteria { Name = "Nomology", Tags = "nomology,christianity,abrahamic religions", Parent = religion },
                new Criteria { Name = "Ecclesiology", Tags = "ecclesiology,christianity,abrahamic religions", Parent = religion },
                new Criteria { Name = "Eschatology", Tags = "eschatology,christianity,abrahamic religions", Parent = religion },
                new Criteria { Name = "Christian ethics", Tags = "christian ethics,christianity,abrahamic religions", Parent = religion },
                new Criteria { Name = "Islam", Tags = "islam,abrahamic religions", Parent = religion },
                new Criteria { Name = "Judaism", Tags = "judaism,abrahamic religions", Parent = religion },
                new Criteria { Name = "Buddhism", Tags = "buddhism,indian religions", Parent = religion },
                new Criteria { Name = "Hinduism", Tags = "hinduism,indian religions", Parent = religion },
                new Criteria { Name = "Jainism", Tags = "jainism,indian religions", Parent = religion },
                new Criteria { Name = "Sikhism", Tags = "sikhism,indian religions", Parent = religion },
                new Criteria { Name = "Chinese folk religion", Tags = "chinese folk religion,east asian religions", Parent = religion },
                new Criteria { Name = "Confucianism", Tags = "confucianism,east asian religions", Parent = religion },
                new Criteria { Name = "Shinto", Tags = "shinto,east asian religions", Parent = religion },
                new Criteria { Name = "Daoism", Tags = "daoism,east asian religions", Parent = religion },
                new Criteria { Name = "I-Kuan Tao", Tags = "i-kuan tao,east asian religions", Parent = religion },
                new Criteria { Name = "Caodaism", Tags = "caodaism,east asian religions", Parent = religion },
                new Criteria { Name = "Chondogyo", Tags = "chondogyo,east asian religions", Parent = religion },
                new Criteria { Name = "Tenrikyo", Tags = "tenrikyo,east asian religions", Parent = religion },
                new Criteria { Name = "Oomoto", Tags = "oomoto,east asian religions", Parent = religion },
                new Criteria { Name = "African religions", Tags = "african religions", Parent = religion },
                new Criteria { Name = "Ancient Egyptian religion", Tags = "ancient egyptian religion", Parent = religion },
                new Criteria { Name = "Native American religions", Tags = "native american religions", Parent = religion },
                new Criteria { Name = "Gnosticism", Tags = "gnosticism", Parent = religion },
                new Criteria { Name = "Esotericism", Tags = "esotericism", Parent = religion },
                new Criteria { Name = "New religious movements", Tags = "new religious movements", Parent = religion },
                new Criteria { Name = "Sumerian religion", Tags = "sumerian religion", Parent = religion },
                new Criteria { Name = "Zoroastrianism", Tags = "zoroastrianism", Parent = religion },
                new Criteria { Name = "Comparative religion", Tags = "comparative religion", Parent = religion },
                new Criteria { Name = "Mythology and Folklore", Tags = "mythology and folklore", Parent = religion },
                new Criteria { Name = "Agnosticism", Tags = "agnosticism", Parent = religion },
                new Criteria { Name = "Atheism and religious humanism", Tags = "atheism and religious humanism", Parent = religion }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                religion.Children.Add(thirdLevelCriteria);
            }
        }
    }
}