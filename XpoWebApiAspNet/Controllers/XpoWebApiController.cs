using BIT.Data.DataTransfer;
using BIT.Xpo.Providers.WebApi.AspNet;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace XpoWebApiAspNet.Controllers
{
    public class XpoWebApiController : XpoWebApiControllerBase
    {
        public XpoWebApiController(IFunction DataStoreFunctionServer) : base(DataStoreFunctionServer)
        {

        }
 
   

    }
}
