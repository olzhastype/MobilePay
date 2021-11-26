using Microsoft.Extensions.Localization;
using MobilePay.Model;
using MobilePay.Model.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePay.Service
{
    public interface IPayService
    {
        Task<ResponseServiceMV> Pay(PhonePayMV phone);
        IClientService ClientService { get; set; }
        IClientService ParsePhoneNumberGetService(string phone);
    }
}
