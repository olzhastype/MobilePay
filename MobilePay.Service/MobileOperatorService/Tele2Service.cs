using MobilePay.Model.DTO;
using System.Threading.Tasks;

namespace MobilePay.Service
{
    public class Tele2Service : IClientService
    {
        public Tele2Service()
        {
            ClientServiceName = nameof(Tele2Service);
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
