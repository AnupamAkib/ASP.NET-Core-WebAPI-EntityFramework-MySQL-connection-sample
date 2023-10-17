using TestingConnection.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestingConnection;

namespace ErrorReportingWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        DBContext _dbContext;
        public ErrorController(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult Create([FromBody] ErrorEntity error)
        {
            try
            {
                _dbContext.Errors.Add(error);
                int affectedRow = _dbContext.SaveChanges();
                if (affectedRow > 0)
                {
                    return Ok(error);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAllErrors()
        {
            try
            {
                return Ok(_dbContext.Errors);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
