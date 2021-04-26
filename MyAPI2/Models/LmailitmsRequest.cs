using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomsDeclaration.Models
{
    public class LmailitmsRequest
    {
        [Key]
        public string MailitmFid { get; set; }

        public string CurrencyCd { get; set; }

        public decimal? MailitmValue { get; set; }

        public string DutiableInd { get; set; }

        public decimal? DutiesAmount { get; set; }
        public string CustomsNo { get; set; }
    }
}
