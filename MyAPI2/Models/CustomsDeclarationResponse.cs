using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomsDeclaration.Models
{
    public class CustomsDeclarationResponse
    {
        public DeclarationResponse declarationResponse { get; set; }
        public Status[] status { get; set; }
    }

    public class DeclarationResponse 
    {
        public string traderReferenceNo { get; set; }
        public string declarationNo { get; set; }
        public string provisional_dec_number { get; set; }
        public string totalAmountPayable { get; set; }
        public string status { get; set; }

    }

    public class Status
    {
        public string faultcode { get; set; }
        public string detail { get; set; }
        public string message { get; set; }

    }
}
