using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Routing;

namespace BasicSearchAppCSharp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.Clear();
            JsonMediaTypeFormatter jsonFormatter = new JsonMediaTypeFormatter();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.Add(jsonFormatter);

            // Web API routes
            config.MapHttpAttributeRoutes();

            // define search route
            IHttpRoute patientsSearchRoute = config.Routes.CreateRoute("api/patients/search", null, null);

            // Add route
            config.Routes.Add("PatientsSearch", patientsSearchRoute);
        }
    }
}
