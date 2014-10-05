using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Religion(ref SecondLevelCriteria religion, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Baha'i Faith", Tags = "baha'i faith,abrahamic religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Bibliology", Tags = "bibliology,christianity,abrahamic religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Hermeneutics", Tags = "hermeneutics,christianity,abrahamic religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Christology", Tags = "christology,christianity,abrahamic religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Pneumatology", Tags = "pneumatology,christianity,abrahamic religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Demonology", Tags = "demonology,christianity,abrahamic religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Theological anthropology", Tags = "theological anthropology,christianity,abrahamic religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Soteriology", Tags = "soteriology,christianity,abrahamic religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Nomology", Tags = "nomology,christianity,abrahamic religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Ecclesiology", Tags = "ecclesiology,christianity,abrahamic religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Eschatology", Tags = "eschatology,christianity,abrahamic religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Christian ethics", Tags = "christian ethics,christianity,abrahamic religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Islam", Tags = "islam,abrahamic religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Judaism", Tags = "judaism,abrahamic religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Buddhism", Tags = "buddhism,indian religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Hinduism", Tags = "hinduism,indian religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Jainism", Tags = "jainism,indian religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Sikhism", Tags = "sikhism,indian religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Chinese folk religion", Tags = "chinese folk religion,east asian religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Confucianism", Tags = "confucianism,east asian religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Shinto", Tags = "shinto,east asian religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Daoism", Tags = "daoism,east asian religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "I-Kuan Tao", Tags = "i-kuan tao,east asian religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Caodaism", Tags = "caodaism,east asian religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Chondogyo", Tags = "chondogyo,east asian religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Tenrikyo", Tags = "tenrikyo,east asian religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Oomoto", Tags = "oomoto,east asian religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "African religions", Tags = "african religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Ancient Egyptian religion", Tags = "ancient egyptian religion", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Native American religions", Tags = "native american religions", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Gnosticism", Tags = "gnosticism", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Esotericism", Tags = "esotericism", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "New religious movements", Tags = "new religious movements", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Sumerian religion", Tags = "sumerian religion", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Zoroastrianism", Tags = "zoroastrianism", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Comparative religion", Tags = "comparative religion", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Mythology and Folklore", Tags = "mythology and folklore", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Agnosticism", Tags = "agnosticism", SecondLevelCriteria = religion },
                new ThirdLevelCriteria { Name = "Atheism and religious humanism", Tags = "atheism and religious humanism", SecondLevelCriteria = religion }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                religion.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}