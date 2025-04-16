using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiSearch.Library.Models;
using MultiSearch.Library.Services.Interfaces;

namespace MultiSearch.Web.Controllers
{
    [Route("api/search")]
    public class SearchController : Controller
    {
        private readonly ILogger<SearchController> _logger;
        readonly ISearchService _searchService;

        public SearchController(ISearchService searchService, ILogger<SearchController> logger)
        {
            _logger = logger;
            _searchService = searchService;
        }

        /// <summary>
        /// Endpoint for GET the search results.
        /// </summary>
        /// <param name="query">Query from user to search on.</param>
        /// <returns>Search respons, including succeeded and errors.</returns>
        // GET: api/search/{query}
        [HttpGet("{query}")]
        public SearchReponse Search(string query)
        {
            try
            {
                _logger.LogInformation($"Searching for: {query}");
                return _searchService.Search(query);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex.Message, ex);

                return new SearchReponse
                {
                    TotalCount = 0,
                    Errors = new List<HttpError>() { new HttpError { Reason = "Oops! Något gick fel med din sökning." } }
                };
            }
        }
    }
}
