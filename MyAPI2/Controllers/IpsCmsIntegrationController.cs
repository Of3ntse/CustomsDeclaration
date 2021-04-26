using CustomsDeclaration.Contexts;
using CustomsDeclaration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomsDeclaration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IpsCmsIntegrationController : ControllerBase
    {
        /*[HttpGet("/api/customs/cmsdeclarationenquiry")]
        public async Task<ActionResult<>>GetDeclaration([FromBody] IpsDeclarationRequest ipsDeclarationRequest)
        {

        }*/
        [HttpGet("/api/customs/cmsdeclarationenquiry/{declarationno}")]
        public  async Task<ActionResult<LmailitmsRequest>> GetMailItem(string declarationno)
       // public ActionResult<LMailitms> GetMailItem(string mailItem)
        {

            using (IpsDBContext ipsDBContext = new IpsDBContext())
            {
                var mailitems = ipsDBContext.lmailitmsRequest.FirstOrDefault(x => x.MailitmFid == declarationno);                
                return mailitems;
            
            }
            
        }


        [HttpGet("{id}")]
        public ActionResult<MyTable> Get(int id)
        {
            using (TestDBContext testDBContext = new TestDBContext())
            {
                //return testDBContext.MyTables.ToList();
                var items = testDBContext.MyTables.FirstOrDefault(x => x.Id == id);
                return items;                
            }


        }
    }
}
