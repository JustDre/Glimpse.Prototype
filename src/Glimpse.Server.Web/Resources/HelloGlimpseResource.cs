﻿using Glimpse.Web;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Glimpse.Server.Web.Resources
{
    public class HelloGlimpseResource : IRequestHandler
    {
        public bool WillHandle(IContext context)
        {
            return context.Request.Path == "/Glimpse";
        }

        public async Task Handle(IContext context)
        {
            var response = context.Response;

            response.SetHeader("Content-Type", "text/plain");

            var data = Encoding.UTF8.GetBytes("Hello world, Glimpse!");
            await response.WriteAsync(data);
        }
    }
}