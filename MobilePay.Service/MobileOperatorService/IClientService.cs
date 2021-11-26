using MobilePay.Model.DTO;
using System.Threading.Tasks;

namespace MobilePay.Service
{
    public interface IClientService
    {
        string ClientServiceName { get; set; }
        Task<ResponseServiceMV> SendMoney(double money, string number);
    }
}
