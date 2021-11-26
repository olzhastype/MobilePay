using Microsoft.EntityFrameworkCore;
using MobilePay.Model;
using MobilePay.Service;
using System;
using System.Threading.Tasks;
using Xunit;

namespace MobilePay.Test
{
    public class PayTest
    {
        public static DbContextOptions<ModelDbContext> InMemoryBase = new DbContextOptionsBuilder<ModelDbContext>()
          .UseInMemoryDatabase(databaseName: "TestDb")
          .Options;


        private IPayService _service;

        public PayTest()
        {
            var dbContext = new ModelDbContext(InMemoryBase);
            _service = new MobilePayService(dbContext);
        }

        [Fact]
        public async Task PayBeeline_TrueResponse()
        {
            _service.ClientService = new BeelinetService();
            var item = await _service.Pay(new Model.DTO.PhonePayMV { MoneyValue = 200, PhoneNumber = "87055270497" });
            var val = item.Name.Equals(nameof(BeelinetService));
            Assert.True(val);
        }


        [Fact]
        public async Task ParseALtelPhoneNumber()
        {

            _service.ClientService = new AltelService();
            var dto = new Model.DTO.PhonePayMV { MoneyValue = 200, PhoneNumber = "87000000000" };
            var item = await _service.Pay(dto);
            var val = _service.ParsePhoneNumberGetService(dto.PhoneNumber);
            Assert.Equal(nameof(AltelService), val.ClientServiceName);
        }
    }
}
