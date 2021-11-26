using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MobilePay.Model;
using MobilePay.Model.DTO;
using System;
using System.Threading.Tasks;

namespace MobilePay.Service
{


    public class MobilePayService : IPayService
    {

        private readonly ModelDbContext _context;

        public MobilePayService(ModelDbContext context)
        {
            _context = context;
        }


        public IClientService ClientService { get; set; }

        public async Task<ResponseServiceMV> Pay(PhonePayMV phone)
        {
            if (ClientService == null)
            {
                ClientService = ParsePhoneNumberGetService(phone.PhoneNumber);
            }
            var item = new Model.Pay
            {
                Cost = phone.MoneyValue,
                CreateDate = DateTime.UtcNow,
                Number = phone.PhoneNumber,
                SenderName = phone.SenderName,
                Successfully = null
            };


            await _context.Pays.AddAsync(item);
            await _context.SaveChangesAsync();

            var result = await ClientService.SendMoney(phone.MoneyValue, phone.PhoneNumber);


            item.Successfully = result.Success;
            await _context.SaveChangesAsync();


            return result;
        }

        public IClientService ParsePhoneNumberGetService(string phoneNumber)
        {
            if (phoneNumber.StartsWith("+7701")
                || phoneNumber.StartsWith("8701"))
            {
                return new ActiveService();
            }
            else
            if (phoneNumber.StartsWith("+7777")
                || phoneNumber.StartsWith("+7705")
                || phoneNumber.StartsWith("8777")
                || phoneNumber.StartsWith("8705"))
            {
                return new BeelinetService();
            }
            else
            if (phoneNumber.StartsWith("+7707")
                || phoneNumber.StartsWith("+7747")
                || phoneNumber.StartsWith("8707")
                || phoneNumber.StartsWith("87708"))
            {
                return new Tele2Service();
            }
            else
            if (phoneNumber.StartsWith("+7700")
                || phoneNumber.StartsWith("+7708")
                || phoneNumber.StartsWith("8700")
                || phoneNumber.StartsWith("8708"))
            {
                return new AltelService();
            }

            throw new Exception("");

        }
    }
}
