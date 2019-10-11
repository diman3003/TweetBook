using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using QiwiRestMoq.Model;

namespace QiwiRestMoq.Controllers
{
    public class RESTController : Controller
    {
        [HttpGet("api/user")]
        [Produces("application/json")]
        public IActionResult Get()
        {
            Provider p;
            Random random = new Random();

            Provider root = new Model.Provider
            {
                ProviderCode = "root",
                Name = "Корень каталога",
                Payable = false,
                Form = false,
                Parents = new List<string> { },
                Children = new List<Provider>()
            };

            for (int i = 0; i < 3; i++)
            {
                p = new Provider
                {
                    ProviderCode = $"PCode 00{i}",
                    Name = $"Name{i}",
                    Payable = random.Next() > (Int32.MaxValue / 2),
                    Form = random.Next() > (Int32.MaxValue / 2),
                    Parents = new List<string> { root.ProviderCode },
                    Children = new List<Provider>()
                };

                root.Children.Add(p);
            }
            return Ok(root);
        }
    }
}