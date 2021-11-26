using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePay.Model
{

    public class Pay : Entity<int>
    {
        public double Cost { get; set; }

        public string Number { get; set; }
        public bool? Successfully { get; set; }
    }
}
