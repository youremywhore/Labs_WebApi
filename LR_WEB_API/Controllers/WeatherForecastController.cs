using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LR_WEB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private ILoggerManager _logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("��� �������������� ��������� �� ������ ����������� ��������.");
           
            _logger.LogDebug("��� ���������� ��������� �� ������ ����������� ��������.");
           
            _logger.LogWarn("��� ��������� �������������� �� ������ ����������� ��������.");
           
            _logger.LogError("��� ��������� �� ������ �� ������ ����������� ��������.");

            return new string[] { "value1", "value2" };
        }

        
       
    }
}