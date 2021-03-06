﻿namespace Unosquare.Labs.EmbedIO.ExtraTests.TestObjects
{
    using System;
    using System.Net;
    using Unosquare.Labs.EmbedIO.Modules;

    public class TestController : WebApiController
    {
        [WebApiHandler(HttpVerbs.Get, "/people/*")]
        public bool GetPeople(WebServer server, HttpListenerContext context)
        {
            try
            {
                return context.JsonResponse(new { Name = "Hola" });
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return context.JsonResponse(ex);
            }
        }

    }
}
