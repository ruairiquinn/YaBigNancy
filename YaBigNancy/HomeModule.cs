﻿using System;
using System.Diagnostics;
using Nancy;
using Nancy.Responses;
using YaBigNancy.Modal;

namespace YaBigNancy
{
    public class HomeModule : NancyModule
    {
        private const string StartTime = "StartTime";

        public HomeModule()
        {
            // Hook into the pipeline to establish the process time for the request
            Before += ctx =>
                          {
                              ctx.Items.Add(StartTime, DateTime.UtcNow);
                              return null;
                          };

            After += ctx =>
                         {
                             var processTime = (DateTime.UtcNow - (DateTime) ctx.Items[StartTime]).TotalMilliseconds;
                             Debug.WriteLine(processTime);
                         };

            Get["/api/teams"] = p => new JsonResponse(SeedTeams.Seed(), new DefaultJsonSerializer());            
        }
    }
}