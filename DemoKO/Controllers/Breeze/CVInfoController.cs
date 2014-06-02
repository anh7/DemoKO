using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Web.Http;
using Breeze.WebApi2;
using Breeze.ContextProvider.EF6;
using DemoKO.Models;

namespace DemoKO.Controllers.Breeze
{
    [BreezeController]
    public class CVInfoController : ApiController
    {
        readonly EFContextProvider<CVMContext> contextProvider = new EFContextProvider<CVMContext>();
        public CVInfoController()
        { }
        [System.Web.Http.HttpGet]
        public string Metadata()
        {
            return contextProvider.Metadata();
        }
        [System.Web.Http.HttpGet]
        public IQueryable CV()
        {

        }
	}
}