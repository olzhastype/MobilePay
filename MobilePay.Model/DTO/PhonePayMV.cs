using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MobilePay.Model.DTO
{
    public class PhonePayMV
    {
        [Required]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$")]
        public string PhoneNumber { get; set; }
        [Required]
        public string SenderName { get; set; }
        [Required]
        [Range(1, double.MaxValue)]
        public double MoneyValue { get; set; }
    }
}
