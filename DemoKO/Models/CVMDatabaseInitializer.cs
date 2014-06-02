using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace DemoKO.Models
{
    public class CVMDatabaseInitializer : CreateDatabaseIfNotExists<CVMContext>
    {
        protected override void Seed(CVMContext context)
        {
            CVInfo info = new CVInfo
            {
                FirstName = "Trong",
                LastName = "Huynh",
                Country = "Viet Nam",
                DoB = new DateTime(1992, 11, 11),
                Occupation = "Waiter",
                Email = "trong@gmail.com",
                Mobile = "(84) 1689 304 378",
                Address = "123 Nguyen Trai, District 1"
            };
            context.infoes.Add(info);
            base.Seed(context);
        }
    }
}