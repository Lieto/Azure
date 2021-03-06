﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PackageController : ApiController
    {
        private static IEnumerable<Package> packages;
        public Package Get(int id)
        {
            return packages.SingleOrDefault
                (p => p.Id == id);
        }

        protected override void Initialize(System.Web.Http.Controllers.HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
       
            base.Initialize(controllerContext);
            
            // Create package for testing purposes. In the real world use a repository pattern or entity framework to fetch this data.
            GenerateStubs();
        }
        
        private static void GenerateStubs()
        {
            packages = new List<Package>
            {
                new Package
                {
                    Id = 1,
                    AccountNumber = Guid.NewGuid(),
                    Origin = "CA",
                    Destination = "TX",
                    StatusCode = 1,
                    Units = 1,
                    Weight = 2.5,
                    Created = DateTime.UtcNow,
                },
                new Package
                {
                    Id = 2,
                    AccountNumber = Guid.NewGuid(),
                    Origin = "AZ",
                    Destination = "AL",
                    StatusCode = 1,
                    Units = 2,
                    Weight = 1,
                    Created = DateTime.UtcNow.AddDays(-2),
                },
                new Package
                {
                    Id = 3,
                    AccountNumber = Guid.NewGuid(),
                    Origin = "FL",
                    Destination = "GA",
                    StatusCode = 3,
                    Units = 1,
                    Weight = 2.5,
                    Created = DateTime.UtcNow,
                }
            };
        }
    }
}