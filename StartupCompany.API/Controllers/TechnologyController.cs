using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StartupCompany.Domain.Entities;
using StartupCompany.Domain.Interface;
using System.Linq.Expressions;

namespace StartupCompany.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TechnologyController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TechnologyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet(Name = "GetAllTechnologies")]
        public IActionResult GetAll()
        {
            var result = _unitOfWork.TechnologyRepository.GetAll();

            return Ok(result);
        }
        [HttpGet(Name = "GetTechnology")]
        public IActionResult Get(int id)
        {
            var result = _unitOfWork.TechnologyRepository.Get(id);

            return Ok(result);
        }

        [HttpPost(Name = "AddTechnology")]
        public IActionResult Add(Technology technology)
        {
            var result = _unitOfWork.TechnologyRepository.AddOne(technology);

            return Ok(result);
        }

        [HttpPost(Name = "AddMultipleTechnologies")]
        public IActionResult AddMultiple(IEnumerable<Technology> tTechnologies)
        {
            var result = _unitOfWork.TechnologyRepository.AddMultiple(tTechnologies);

            return Ok(result);
        }

        [HttpGet(Name = "SearchTechnologies")]
        public IActionResult Search(string technologyName)
        {
            Expression<Func<Technology, bool>> technologyPredicate = p => p.Name.Contains(technologyName);

            var result = _unitOfWork.TechnologyRepository.Find(technologyPredicate);

            return Ok(result);
        }

        [HttpDelete(Name = "RemoveTechnology")]
        public IActionResult Remove(Technology technology)
        {
            var result = _unitOfWork.TechnologyRepository.RemoveOne(technology);

            return Ok(result);
        }

        [HttpDelete(Name = "RemoveMultipleTechnologies")]
        public IActionResult RemoveMultiple(IEnumerable<Technology> technologies)
        {
            var result = _unitOfWork.TechnologyRepository.RemoveMultiple(technologies);

            return Ok(result);
        }
        [HttpGet(Name = "TeamWithTechnologies")]
        public IActionResult GetTeamWithTechnologies()
        {
            var result = _unitOfWork.TechnologyRepository.GetTeamWithTheirTechnologies();

            return Ok(result);
        }
    }
}
