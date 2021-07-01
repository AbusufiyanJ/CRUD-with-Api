using CrudBusinessLayer;
using CrudModel.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CrudWebApi.Controllers
{
    public class UserController : ApiController
    {
        [HttpPost]
        public bool Create([FromBody] CrudModel.UIModels.UserViewModel model)
        {
            return new UserBL().CreateUser(model);
        }
    }
}
