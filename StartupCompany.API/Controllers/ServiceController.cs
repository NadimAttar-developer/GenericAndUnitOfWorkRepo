using Microsoft.AspNetCore.Mvc;
using StartupCompany.Domain.Entities;
using StartupCompany.Domain.Interface;
using System.Linq.Expressions;
using System;

namespace StartupCompany.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ServiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet(Name = "GetAllServices")]
        public IActionResult GetAll()
        {
            var result = _unitOfWork.ServiceRepository.GetAll();

            return Ok(result);
        }
        [HttpGet(Name = "GetService")]
        public IActionResult Get(int id)
        {
            var result = _unitOfWork.ServiceRepository.Get(id);

            return Ok(result);
        }

        [HttpPost(Name = "AddService")]
        public IActionResult Add(Service service)
        {
            var result = _unitOfWork.ServiceRepository.AddOne(service);

            return Ok(result);
        }

        [HttpPost(Name = "AddMultipleServices")]
        public IActionResult AddMultiple(IEnumerable<Service> services)
        {
            var result = _unitOfWork.ServiceRepository.AddMultiple(services);

            return Ok(result);
        }

        [HttpGet(Name = "SearchServices")]
        public IActionResult Search(string serviceName)
        {
            Expression<Func<Service, bool>> searchPredicate = p => p.Name.Contains(serviceName);

            var result = _unitOfWork.ServiceRepository.Find(searchPredicate);

            return Ok(result);
        }

        [HttpDelete(Name = "RemoveService")]
        public IActionResult Remove(Service service)
        {
            var result = _unitOfWork.ServiceRepository.RemoveOne(service);

            return Ok(result);
        }

        [HttpDelete(Name = "RemoveServices")]
        public IActionResult RemoveMultiple(IEnumerable<Service> services)
        {
            var result = _unitOfWork.ServiceRepository.RemoveMultiple(services);

            return Ok(result);
        }
    }
}
