using System;
using Microsoft.AspNetCore.Mvc;
using NewsApp.Models;

namespace NewsApp.Controllers
{
    [Route("api/news")]
    public class NewsController : Controller
    {
        private readonly INewsRepository _newsRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDatabaseService _dbservice;

        public NewsController(INewsRepository newsRepository, ICategoryRepository categoryRepository, IDatabaseService dbservice)
        {
            _newsRepository = newsRepository;
            _categoryRepository = categoryRepository;
            _dbservice = dbservice;
        }

        [HttpPost("seed")]
        public IActionResult Seed()
        {
            _dbservice.SeedRepo();
            return NoContent();
        }

        [HttpPost("recreate")]
        public IActionResult RecreateDatabase()
        {
            _dbservice.RecreateDatabase();
            return NoContent();
        }

        [HttpGet("count")]
        public IActionResult Count()
        {
            int numberOfNews = _newsRepository.Count();
            return Ok(numberOfNews);
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            var all = _newsRepository.GetAll();
            return Ok(all);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_newsRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Add([FromBody]News news)
        {
            if (news == null)
            {
                return BadRequest("News is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            news.CreatedDate = DateTime.Now;
            news.UpdatedDate = DateTime.Now;

            if (news.Category?.Id != null)
            {
                Category c = _categoryRepository.GetById((int)news.Category.Id);
                news.Category = c;
            }

            // Förhindra att ny kategori skapas om ingen anges
            if (news.Category?.Id == null)
                news.Category = null;

            _newsRepository.Add(news);

            return Ok(news.Id);
        }


        [HttpPut]
        public IActionResult Update([FromBody]News news)
        {
            if (news == null)
            {
                return BadRequest("News is null");
            }

            if (!_newsRepository.NewsExist(news.Id))
            {
                return NotFound($"{news.Id} not found");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Get previous news item

            News previousNews = _newsRepository.GetById(news.Id);

            // Fill with new values

            previousNews.Body = news.Body;
            previousNews.Header = news.Header;
            previousNews.Intro = news.Intro;

            previousNews.UpdatedDate = DateTime.Now;

            // Category

            if (news.Category.Id != null)
            {
                Category c = _categoryRepository.GetById((int)news.Category.Id);
                previousNews.Category = c;
            }

            _newsRepository.Update(previousNews);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            if (!_newsRepository.NewsExist(id))
            {
                return NotFound($"{id} not found");
            }

            _newsRepository.Remove(id);

            return NoContent();
        }

    }
}
