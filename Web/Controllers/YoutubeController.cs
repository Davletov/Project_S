namespace Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Google.Apis.Services;
    using Google.Apis.YouTube.v3;
    using Google.Apis.YouTube.v3.Data;
    using Google.GData.Client;
    using Google.GData.YouTube;
    using Google.YouTube;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Web.Models.Profile;
    using Web.Models.YouTube;
    using Video = Google.YouTube.Video;
    using YouTubeService = Google.Apis.YouTube.v3.YouTubeService;

    public class YoutubeController : Controller
    {
        public const string APPLICATION_NAME = "test_with_youtubeapi";

        public const string DEVELOPER_KEY =
            "AI39si5kw76FsNjpn0CqxHM1Dmw7ZTicngpvLzzFGH1UEyC3TxaGbEz4EathozVydbfQgn5hBArTl8LC9N1OxMw2SCXuLicpKg";

        public const string CRITERIA_SAMPLE = "linear mathematics lecture";

        private UserManager<Profile> userManager = new UserManager<Profile>(new UserStore<Profile>(new BdContext()));
        private YouTubeRequestSettings requestSettings = new YouTubeRequestSettings(APPLICATION_NAME, DEVELOPER_KEY);

        public ActionResult Index(int pageNumber = 0)
        {            
            YouTubeRequest request = new YouTubeRequest(requestSettings);
            YouTubeQuery q = new YouTubeQuery(YouTubeQuery.DefaultVideoUri);
            q.Query = CRITERIA_SAMPLE;
            q.OrderBy = "rating";
            q.StartIndex = pageNumber;
            q.Categories.Add(new QueryCategory(new AtomCategory("education")));
            Feed<Video> videos = request.Get<Video>(q);
            var res = videos.Entries.Take(25).ToList().Select(x => new YoutubeMaterial
            {
                Duration = int.Parse(x.Media.Duration.Seconds),
                Name = x.Title,
                Description = x.Description,
                Url = x.WatchPage.AbsoluteUri,
                ViewCount = x.ViewCount,
                ETag = x.ETag,
                VideoId = x.VideoId
            });
            return View(res);
        }

        public async Task<ActionResult> Index2(string criteriaName, string pageToken)
        {
            Profile user = userManager.FindById(User.Identity.GetUserId());
            ViewBag.SecondLevelCriterias = user.ProfileCriteria.Where(x => x.Criteria.Parent != null && x.Criteria.Children != null).Select(x => x.Criteria).Select(x => x.Name).ToList();

            if (string.IsNullOrEmpty(criteriaName))
            {
                return View(new List<YoutubeMaterial>());
            }

            YouTubeService youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApplicationName = APPLICATION_NAME,
                ApiKey = "AIzaSyD5-fxmngznhYSJgEPn-uAmkaaSisRvMr4"
            });

            List<YoutubeMaterial> materials = new List<YoutubeMaterial>();
            string query = string.Join(",",
                user.ProfileCriteria.Select(x => x.Criteria).Where(x => x.Name == criteriaName).Select(x => x.Name));


            SearchResource.ListRequest searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = query;
            searchListRequest.MaxResults = 10;
            searchListRequest.PageToken = pageToken;
            
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
            ViewBag.NextPageToken = searchListResponse.NextPageToken;
            ViewBag.PrevPageToken = searchListResponse.PrevPageToken;
            ViewBag.CriteriaName = criteriaName;
            return View(materials);
        }
    }
}