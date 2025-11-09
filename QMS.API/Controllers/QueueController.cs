using Microsoft.AspNetCore.Mvc;
using QMS.Model.Entity;
using QMS.Business.Abstract;

namespace QMS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QueueController : ControllerBase
    { 
        private readonly IQueueService _queueService;

        public QueueController(IQueueService queueService) => _queueService = queueService;
        

        [HttpGet(Name = "GetList")]
        public ICollection<Queue> Get()
        {
            return _queueService.GetAll();
        }
    }
}
