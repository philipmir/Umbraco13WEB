using UM13WEBSITE.Models.ContentModels;
using UM13WEBSITE.Models.Search;
using UM13WEBSITE.Models.ViewModels;
using UM13WEBSITE.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;

namespace UM13WEBSITE.Controllers.Render;

public class SearchPageController(
    ILogger<RenderController> logger,
    ICompositeViewEngine compositeViewEngine,
    IUmbracoContextAccessor umbracoContextAccessor,
    IHttpContextAccessor httpContextAccessor,
    ISearchService searchService)
        : RenderController(logger, compositeViewEngine, umbracoContextAccessor)
{
    public override IActionResult Index()
    {
        var httpContext = httpContextAccessor.HttpContext;
        var query = httpContext?.Request.Query["query"];
        var page = httpContext?.Request.Query["page"];

        if (CurrentPage == null) return BadRequest();

        var pageSize = 10;

        var searchRequest = new SearchRequestModel(query, page, pageSize);

        var searchResponse = searchService.Search(searchRequest);

        var pagination = new PaginationViewModel
        {
            TotalResults = searchResponse.TotalResultCount,
            TotalPages = (int)Math.Ceiling((double)(searchResponse.TotalResultCount / searchRequest.PageSize)),
            ResultsPerPage = searchRequest.PageSize,
            CurrentPage = searchRequest.Page
        };

        var model = new SearchPageContentModel(CurrentPage)
        {
            SearchRequest = searchRequest,
            SearchResponse = searchResponse,
            Pagination = pagination
        };

        return CurrentTemplate(model);
    }
}