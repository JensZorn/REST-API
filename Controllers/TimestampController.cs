using Microsoft.AspNetCore.Mvc;

namespace REST_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimestampController
    {
        [HttpGet(Name = "GetTimestamp")]
        public ServerTimestamp Get()
        {
            return new ServerTimestamp
            {
                Timestamp = DateTime.Now
            };
        }
    }
}