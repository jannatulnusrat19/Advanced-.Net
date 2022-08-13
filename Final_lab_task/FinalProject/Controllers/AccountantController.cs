using BLL.BO;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalProject.Controllers
{
    public class AccountantController : ApiController
    {
        [Route("api/Accountant/All")]
        [HttpGet]
        public List<AccountantModel> GetAll()
        {
            return AccountantService.Get();
        }
        [Route("api/Accountant/Create")]
        [HttpPost]
        public HttpResponseMessage Create(AccountantModel r)
        {
            AccountantService.Create(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Created");
        }
        [Route("api/Accountant/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = AccountantService.GetOnly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/Accountant/update")]
        [HttpPost]
        public HttpResponseMessage Update(AccountantModel r)
        {
            AccountantService.Update(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");

        }
        [Route("api/Accountant/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            AccountantService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }
    }
}
