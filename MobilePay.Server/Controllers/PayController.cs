using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MobilePay.Model;
using MobilePay.Model.DTO;
using MobilePay.Service;
using System.Threading.Tasks;

namespace MobilePay.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayController : ControllerBase
    {
        private readonly IStringLocalizer<PayController> _localizer;
        private IPayService _service;

        private readonly ILogger<PayController> _logger;
        public PayController(MobilePayService service, IStringLocalizer<PayController> localizer, ILogger<PayController> logger)
        {
            _service = service;
            _localizer = localizer;
            _logger = logger;
        }


        [HttpPost]
        public async Task<ResponseServiceMV> PayPhone(PhonePayMV pay)
        {
            var error = _localizer["Error"];
            var success = _localizer["Success"];
            var result = await _service.Pay(pay);

            if (result.Success)
            {
                _logger.LogInformation($"{success} {pay.PhoneNumber}");
            }
            else
            {
                _logger.LogInformation($"{error} {pay.PhoneNumber}");
            }

            return result;
        }
    }
}
