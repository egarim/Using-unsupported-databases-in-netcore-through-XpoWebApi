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
        //public IHttpActionResult Post()
        //{
        //    return base.Post(null);
        //}
        //public override IHttpActionResult Post([FromBody] DataParameters value)
        //{
        //    return Ok("Hi from the server");
        //    //return base.Post(value);
        //}
        //public async override Task<IHttpActionResult> Post()
        //{


           

        //    try
        //    {
        //        //Task<IHttpActionResult> task = base.Post();
        //        //return task;


        //        var body = this.Request.Content;



        //        IDataParameters parameters = await DeserializeFromStream(await body.ReadAsStreamAsync());

        //        parameters.AdditionalValues.Add("DataStoreId", "001");
        //        IDataResult content = this.DataStoreFunctionServer.ExecuteFunction(parameters);
        //        return Ok(content);
        //    }
        //    catch (Exception ex)
        //    {
        //        var test = ex.Message;
        //        throw;
        //    }


        //}

    }
}
