using MobilePay.Model.DTO;
using System.Threading.Tasks;

namespace MobilePay.Service
{
    public class BeelinetService : IClientService
    {
        public BeelinetService()
        {
            ClientServiceName = nameof(BeelinetService);
        }

        public string ClientServiceName { get; set; }

        public async Task<ResponseServiceMV> SendMoney(double money, string number)
        {
            await Task.Delay(1000);

            return new ResponseServiceMV
            {
                Name = ClientServiceName,
                Success = true
            };
        }
    }
}
