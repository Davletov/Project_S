using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Google.YouTube;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Web.DataAccess.Repository;
using Web.Models.Profile;
using Web.Models.YouTube;

namespace Web.Helpers
{
    public static class YoutubeHelper
    {
        public const string APPLICATION_NAME = "test_with_youtubeapi";

        public const string DEVELOPER_KEY =
            "AI39si5kw76FsNjpn0CqxHM1Dmw7ZTicngpvLzzFGH1UEyC3TxaGbEz4EathozVydbfQgn5hBArTl8LC9N1OxMw2SCXuLicpKg";
        private static UserManager<Profile> userManager = new UserManager<Profile>(new UserStore<Profile>(new BdContext()));
        
        private static YouTubeRequestSettings requestSettings = new YouTubeRequestSettings(APPLICATION_NAME, DEVELOPER_KEY);

        public static async Task<List<YoutubeMaterial>> GetMaterials(IPrincipal User)
        {
            //Profile user = userManager.FindById(User.Identity.GetUserId());
            Profile user;
            using (var uow = new UnitOfWork())
            {
                user = uow.Repository<Profile>().GetById(User.Identity.GetUserId());
            }

            if (user == null)
            {
                return null;
            }

            YouTubeService youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApplicationName = APPLICATION_NAME,
                ApiKey = "AIzaSyD5-fxmngznhYSJgEPn-uAmkaaSisRvMr4"
            });

            List<YoutubeMaterial> materials = new List<YoutubeMaterial>();
            string query = string.Join(",",
                user.ProfileCriteria.Select(x => x.Criteria).Take(5).Select(x => x.Name));


            SearchResource.ListRequest searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = query;
            searchListRequest.MaxResults = 20;
            searchListRequest.PageToken = "";

            SearchListResponse searchListResponse = await searchListRequest.ExecuteAsync();

            foreach (SearchResult searchResult in searchListResponse.Items)
            {
                switch (searchResult.Id.Kind)
                {
                    case "youtube#video":
                        materials.Add(new YoutubeMaterial
                        {
                            Description = searchResult.Snippet.Description,
                            Name = searchResult.Snippet.Title,
                            VideoId = searchResult.Id.VideoId
                        });
                        break;

                    case "youtube#channel":

                        break;

                    case "youtube#playlist":

                        break;
                }
            }
            
            return materials;
        }
    }
}