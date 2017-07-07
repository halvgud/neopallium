// Copyright (C) 2016 by Barend Erasmus and donated to the public domain

using System;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace Corecortex
{
    class Program
    {
        static readonly Uri _baseAddress = new Uri("http://localhost:8080/");
        static void Main(string[] args)
        {
            // Set up server configuration
            HttpSelfHostConfiguration config = new HttpSelfHostConfiguration(_baseAddress);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{fechaIni}/{fechaFin}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            // Create server
            var server = new HttpSelfHostServer(config);

            // Start listening
            server.OpenAsync().Wait();
            Console.WriteLine("Web API Self hosted on " + _baseAddress + " Hit ENTER to exit...");
            Console.ReadLine();
            server.CloseAsync().Wait();
        }
    }
}
