using Web.DataAccess.Repository;
using Web.Models.Criteria;

namespace Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Web.Script.Serialization;
    using Microsoft.AspNet.Identity;
    using Web.Enum;
    using Web.Models.Profile;

    public class ProfileController : Controller
    {
        // Метод для сохранения данных с профайла (переделать, разбить на методы)
        [HttpGet]
        public ActionResult Profile()
        {
            ViewData["countryList"] = LocationController.GetCountries();

            var currentUserId = User.Identity.GetUserId();
            if (currentUserId != null)
            {
                Profile profile;
                using (var uow = new UnitOfWork())
                {
                    profile = uow.Repository<Profile>().Get(x => x.Id == currentUserId).FirstOrDefault();
                }

                return profile != null ? View(profile) : View();
            }

            return RedirectToAction("Index", "Home"); // заглушка (переделать)
        }

        [HttpPost]
        public ActionResult Profile(string values, string model)
        {
            var jsTool = new JavaScriptSerializer();
            var formProxyObj = jsTool.Deserialize<FormProxy>(model);

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

                Profile profile;
                using (var uow = new UnitOfWork())
                {
                    var profileQuery = uow.Repository<Profile>().Get(x => x.Id == currentUserId);

                    if (profileQuery.FirstOrDefault() == null)
                    {
                        profile = new Profile {UserId = currentUserId, LoginName = currentUserName};
                        profile.LoginName = formProxyObj.LoginName;
                        if (formProxyObj.BirthDay != null) profile.BirthDay = (int)formProxyObj.BirthDay;
                        if (formProxyObj.BirthMonth != null) profile.BirthMonth = (int)formProxyObj.BirthMonth;
                        if (formProxyObj.BirthYear != null) profile.BirthYear = (int)formProxyObj.BirthYear;

                        UserSocialStatus var;
                        var boolTmp = Enum.TryParse(formProxyObj.UserSocialStatus, false, out var);
                        profile.UserSocialStatus = boolTmp ? var : UserSocialStatus.Other;

                        int countryId;
                        int cityId;
                        int.TryParse(formProxyObj.Country, out countryId);
                        int.TryParse(formProxyObj.City, out cityId);
                        profile.Country = countryId;
                        profile.City = cityId;

                        profile.CreateDate = new DateTime(2014, 8, 22);
                        profile.FirstName = "test1";
                        profile.LastName = "test2";

                        if (criteriaData != null)
                        {
                            profile.ProfileCriteria = new Collection<ProfileCriteria>();
                            foreach (var criteria in criteriaData)
                            {
                                var Criteria = uow.Repository<Criteria>().GetById(criteria.id);
                                var newProfileCriteria = new ProfileCriteria
                                {
                                    Criteria = Criteria,
                                    Profile = profile
                                };
                                uow.Repository<ProfileCriteria>().Add(newProfileCriteria);
                            }
                        }

                        uow.Repository<Profile>().Add(profile);
                    }
                    else
                    {
                        profile = profileQuery.FirstOrDefault();
                        profile.LoginName = formProxyObj.LoginName;
                        if (formProxyObj.BirthDay != null) profile.BirthDay = (int)formProxyObj.BirthDay;
                        if (formProxyObj.BirthMonth != null) profile.BirthMonth = (int)formProxyObj.BirthMonth;
                        if (formProxyObj.BirthYear != null) profile.BirthYear = (int)formProxyObj.BirthYear;

                        UserSocialStatus var;
                        var boolTmp = UserSocialStatus.TryParse(formProxyObj.UserSocialStatus, false, out var);
                        profile.UserSocialStatus = boolTmp ? var : UserSocialStatus.Other;

                        int countryId;
                        int cityId;
                        int.TryParse(formProxyObj.Country, out countryId);
                        int.TryParse(formProxyObj.City, out cityId);
                        profile.Country = countryId;
                        profile.City = cityId;

                        profile.CreateDate = new DateTime(2014, 8, 22);
                        profile.FirstName = "test1";
                        profile.LastName = "test2";

                        if (criteriaData != null)
                        {
                            var curUserFirstCriteriasQuery = uow.Repository<ProfileCriteria>().Get().AsEnumerable().Where(x => x.Profile.Id == profile.Id);
                            

                            // get current user's criterias from repository
                            var curUserFirstCriteriaIds = curUserFirstCriteriasQuery.Select(x => x.Criteria.Id).ToList();
                            

                            // get current user's criterias from client side
                            var jstreeFirstCriteriaIds = criteriaData.Where(x => x.level == 1).Select(x => x.id).ToList();                            

                            // find criterias, which need add to repository
                            var needToAddFirstCriterias = jstreeFirstCriteriaIds.Except(curUserFirstCriteriaIds);
                            

                            // find criterias, which need delete from repository
                            var needToDeleteFirstCriterias = curUserFirstCriteriaIds.Except(jstreeFirstCriteriaIds);                            

                            // Add criterias to profile
                            foreach (var firstCriteria in needToAddFirstCriterias)
                            {
                                var criteria = uow.Repository<Criteria>().GetById(firstCriteria);
                                var newProfileCriteria = new ProfileCriteria { Criteria = criteria, Profile = profile };
                                uow.Repository<ProfileCriteria>().Add(newProfileCriteria); 
                            }
                            

                            // Delete criterias from profile
                            foreach (var firstCriteria in needToDeleteFirstCriterias)
                            {
                                var newProfileCriteria = curUserFirstCriteriasQuery.Where(x => x.Criteria.Id == firstCriteria).Select(x => x.Id).FirstOrDefault();
                                uow.Repository<ProfileCriteria>().Delete(newProfileCriteria);
                            }
                            

                        }

                        uow.Repository<Profile>().Update(profile);
                    }

                    uow.Commit();
                }

                ViewData["countryList"] = LocationController.GetCountries();
                return View(profile);
            }

            return RedirectToAction("Index", "Home"); // заглушка (переделать)
        }

        // Get currents user's criterias to jstree in view
        [HttpPost]
        public ActionResult GetCriteria()
        {
            var currentUserId = User.Identity.GetUserId();
            var listCriteriaIds = new List<Guid>();
            using (var uow = new UnitOfWork())
            {
                if (currentUserId != null)
                {
                    var first = uow.Repository<Profile>().GetById(currentUserId).ProfileCriteria.Select(x => x.CriteriaId).ToList();                    
                    listCriteriaIds.AddRange(first);                    
                }
            }

            return Json(listCriteriaIds);
        }

        public class FormProxy
        {
            public string LoginName { get; set; }
            public int? BirthDay { get; set; }
            public int? BirthMonth { get; set; }
            public int? BirthYear { get; set; }
            public string UserSocialStatus { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
        }

        private class ProxyGenerator 
        {
            public Guid id { get; set; }
            public int level { get; set; }
        }

    }
}