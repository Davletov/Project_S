using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Google.GData.Client;
using Google.GData.YouTube;
using Google.YouTube;
using Web.Models.YouTube;
using Video = Google.YouTube.Video;
using YouTubeService = Google.Apis.YouTube.v3.YouTubeService;

namespace Web.Controllers
{
    public class YoutubeController : Controller
    {
        public const string APPLICATION_NAME = "test_with_youtubeapi";

        public const string DEVELOPER_KEY =
            "AI39si5kw76FsNjpn0CqxHM1Dmw7ZTicngpvLzzFGH1UEyC3TxaGbEz4EathozVydbfQgn5hBArTl8LC9N1OxMw2SCXuLicpKg";

        public const string CRITERIA_SAMPLE = "linear mathematics lecture";

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

        public async Task<ActionResult> Index2(string pageToken)
        {
            YouTubeService youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApplicationName = APPLICATION_NAME,
                ApiKey = "AIzaSyD5-fxmngznhYSJgEPn-uAmkaaSisRvMr4"
            });

            SearchResource.ListRequest searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = CRITERIA_SAMPLE;
            //searchListRequest.Order = SearchResource.ListRequest.OrderEnum.Relevance;
            //searchListRequest.VideoDuration = SearchResource.ListRequest.VideoDurationEnum.Long;
            searchListRequest.MaxResults = 50;
            searchListRequest.PageToken = pageToken;
            
            SearchListResponse searchListResponse = await searchListRequest.ExecuteAsync();           

            List<YoutubeMaterial> materials = new List<YoutubeMaterial>();
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
            return View(materials);
        }
    }
}