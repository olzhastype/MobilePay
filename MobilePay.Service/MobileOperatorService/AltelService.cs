using MobilePay.Model.DTO;
using System.Threading.Tasks;

namespace MobilePay.Service
{
    public class AltelService : IClientService
    {
        public AltelService()
        {
            ClientServiceName = nameof(AltelService);
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
