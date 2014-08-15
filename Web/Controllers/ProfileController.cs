using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using Web.Models;

namespace Web.Controllers
{
    using System.Web.Mvc;

    public class ProfileController : Controller
    {
        // Метод для сохранения данных с профайла (переделать, разбить на методы)
        public ActionResult Profile(Profile profile, string values)
        {
            var currentUserName = User.Identity.Name;
            var currentUserId = User.Identity.GetUserId();

            if (currentUserId != null)
            {
                List<ProxyGenerator> criteriaData = null;
                if (!string.IsNullOrEmpty(values))
                {
                    var jss = new JavaScriptSerializer();
                    criteriaData = jss.Deserialize<List<ProxyGenerator>>(values);
                }

                using (var uow = new UnitOfWork.UnitOfWork())
                {
                    profile = uow.ProfileRepository.Get(x => x.UserId == currentUserId).FirstOrDefault();

                    if (criteriaData != null)
                    {
                        foreach (var criteria in criteriaData)
                        {
                            switch (criteria.level)
                            {
                                case 1:
                                    if (profile != null)
                                    {
                                        var firstLevelCriteria = uow.FirstLevelCriteriaRepository.GetById(criteria.id);
                                        profile.FirstLevelCriteria.Add(firstLevelCriteria);
                                    }
                                    break;
                                case 2:
                                    if (profile != null)
                                    {
                                        var secondLevelCriteria = uow.SecondLevelCriteriaRepository.GetById(criteria.id);
                                        profile.SecondLevelCriteria.Add(secondLevelCriteria);
                                    }
                                    break;
                                case 3:
                                    if (profile != null)
                                    {
                                        var thirdLevelCriteria = uow.ThirdLevelCriteriaRepository.GetById(criteria.id);
                                        profile.ThirdLevelCriteria.Add(thirdLevelCriteria);
                                    }
                                    break;
                            }
                        }
                    }

                    if (profile == null)
                    {
                        profile = new Profile {UserId = currentUserId, LoginName = currentUserName};
                        uow.ProfileRepository.Add(profile);
                    }
                    else
                    {

                        uow.ProfileRepository.Update(profile);
                    }
                    uow.Save();
                }

                ViewData["countryList"] = LocationController.GetCountries();
                return View(profile);
            }

            return RedirectToAction("Index", "Home"); // заглушка (переделать)
        }

        public ViewResult Save(Profile profile, string values)
        {

            return View("Profile");
        }

        private class ProxyGenerator 
        {
            public Guid id { get; set; }
            public int level { get; set; }
        }

        [HttpPost]
        public ActionResult GetTreeData()
        {
            // тестовые данные на случай, если данные по критериям в базе нет
            //var str = "[{ \"children\": [{ \"children\": [{ \"ThirdLevelCriteriaId\": 1, \"text\": \"African history\", \"Tags\": \"african history,africa,history\" }, { \"ThirdLevelCriteriaId\": 2, \"text\": \"American history\", \"Tags\": \"american history,america,history\" }], \"SecondLevelCriteriaId\": 1, \"text\": \"History\", \"Tags\": \"history\" }, { \"children\": [{ \"ThirdLevelCriteriaId\": 3, \"text\": \"Business English\", \"Tags\": \"business english\" }, { \"ThirdLevelCriteriaId\": 4, \"text\": \"Classical language\", \"Tags\": \"classical language\" }], \"SecondLevelCriteriaId\": 2, \"text\": \"Linguistics\", \"Tags\": \"linguistics\" }], \"FirstLevelCriteriaId\": 1, \"text\": \"Humanities sciences\", \"Tags\": \"humanities sciences,liberal arts\" }, { \"children\": [{ \"children\": [{ \"ThirdLevelCriteriaId\": 5, \"text\": \"Forensic anthropology\", \"Tags\": \"forensic anthropology,biological anthropology\" }, { \"ThirdLevelCriteriaId\": 6, \"text\": \"Gene-culture coevolution\", \"Tags\": \"Gene-culture coevolution,biological anthropology\" }], \"SecondLevelCriteriaId\": 3, \"text\": \"Anthropology\", \"Tags\": \"anthropology\" }, { \"children\": [{ \"ThirdLevelCriteriaId\": 7, \"text\": \"Classical archaeology\", \"Tags\": \"classical archaeology\" }, { \"ThirdLevelCriteriaId\": 8, \"text\": \"Egyptology\", \"Tags\": \"egyptology\" }], \"SecondLevelCriteriaId\": 4, \"text\": \"Archaeology\", \"Tags\": \"archaeology\" }], \"FirstLevelCriteriaId\": 2, \"text\": \"Social sciences\", \"Tags\": \"social sciences,public sciences,community sciences\" }, { \"children\": [{ \"children\": [{ \"ThirdLevelCriteriaId\": 9, \"text\": \"Acoustics\", \"Tags\": \"acoustics\" }, { \"ThirdLevelCriteriaId\": 10, \"text\": \"Applied Physics\", \"Tags\": \"applied physics\" }], \"SecondLevelCriteriaId\": 5, \"text\": \"Physics and Space sciences\", \"Tags\": \"physics sciences,space sciences\" }, { \"children\": [{ \"ThirdLevelCriteriaId\": 11, \"text\": \"Edaphology\", \"Tags\": \"edaphology\" }, { \"ThirdLevelCriteriaId\": 12, \"text\": \"Environmental science\", \"Tags\": \"environmental science\" }], \"SecondLevelCriteriaId\": 6, \"text\": \"Earth sciences\", \"Tags\": \"earth sciences\" }], \"FirstLevelCriteriaId\": 3, \"text\": \"Natural Sciences\", \"Tags\": \"natural sciences,natural\" }, { \"children\": [{ \"children\": [{ \"ThirdLevelCriteriaId\": 13, \"text\": \"Aeronautics Engineering\", \"Tags\": \"aeronautics engineering,aerospace engineering\" }, { \"ThirdLevelCriteriaId\": 14, \"text\": \"Astronautics Engineering\", \"Tags\": \"astronautics engineering,aerospace engineering\" }], \"SecondLevelCriteriaId\": 7, \"text\": \"Mechanical Engineering\", \"Tags\": \"mechanical engineering\" }, { \"children\": [{ \"ThirdLevelCriteriaId\": 15, \"text\": \"Biochemical Engineering\", \"Tags\": \"biochemical engineering,bioengineering\" }, { \"ThirdLevelCriteriaId\": 16, \"text\": \"Catalysis\", \"Tags\": \"catalysis\" }], \"SecondLevelCriteriaId\": 8, \"text\": \"Chemical Engineering\", \"Tags\": \"chemical engineering\" }], \"FirstLevelCriteriaId\": 4, \"text\": \"Engineering Sciences\", \"Tags\": \"engineering sciences,engineering\" }, { \"children\": [{ \"children\": [{ \"ThirdLevelCriteriaId\": 17, \"text\": \"Mathematical statistics\", \"Tags\": \"mathematical statistics,statistics\" }, { \"ThirdLevelCriteriaId\": 18, \"text\": \"Econometrics\", \"Tags\": \"econometrics,statistics\" }], \"SecondLevelCriteriaId\": 9, \"text\": \"Applied Mathematics\", \"Tags\": \"applied mathematics\" }, { \"children\": [{ \"ThirdLevelCriteriaId\": 19, \"text\": \"Automata theory\", \"Tags\": \"automata theory,formal languages,theory of computation\" }, { \"ThirdLevelCriteriaId\": 20, \"text\": \"Computability theory\", \"Tags\": \"computability theory,theory of computation\" }], \"SecondLevelCriteriaId\": 10, \"text\": \"Computer sciences\", \"Tags\": \"computer sciences\" }], \"FirstLevelCriteriaId\": 5, \"text\": \"Formal Sciences\", \"Tags\": \"formal sciences,formal\" }, { \"children\": [{ \"children\": [{ \"ThirdLevelCriteriaId\": 21, \"text\": \"Agroecology\", \"Tags\": \"agroecology\" }, { \"ThirdLevelCriteriaId\": 22, \"text\": \"Agronomy\", \"Tags\": \"agronomy\" }], \"SecondLevelCriteriaId\": 11, \"text\": \"Agriculture\", \"Tags\": \"agriculture\" }, { \"children\": [{ \"ThirdLevelCriteriaId\": 23, \"text\": \"Architecture\", \"Tags\": \"Architecture,related design\" }, { \"ThirdLevelCriteriaId\": 24, \"text\": \"Urban planning\", \"Tags\": \"urban design,related design\" }], \"SecondLevelCriteriaId\": 12, \"text\": \"Architecture and design\", \"Tags\": \"architecture,design\" }], \"FirstLevelCriteriaId\": 6, \"text\": \"Applied Sciences\", \"Tags\": \"applied sciences\" }]";

            string str;
            using (var uow = new UnitOfWork.UnitOfWork())
            {
                var listCategory = uow.FirstLevelCriteriaRepository.Get().ToList();

                str = JsonConvert.SerializeObject(listCategory, Formatting.None,
                    new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
            }


            /*Код ниже это пипец, переделать*/
            str =
                str.Replace("\"SecondLevelCriteria\"", "\"children\"")
                    .Replace("\"ThirdLevelCriteria\"", "\"children\"")
                    .Replace("Name", "text")
                    .Replace("Id", "id");


            var jsonStr = Json(str);
            return jsonStr;
        }
    }
}