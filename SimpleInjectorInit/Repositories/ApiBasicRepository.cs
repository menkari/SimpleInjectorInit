using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using SimpleInjectorInit.Interfaces;

namespace SimpleInjectorInit.Repositories
{
    public class ApiBasicRepository: IBasicRepository
    {
        public string GetHelloWorld()
        {
            var client = new RestClient("http://mryful.com/HelloWorldApi/");
            var req = new RestRequest("api/world/{id}", Method.GET) {RequestFormat = DataFormat.Json};

            req.AddUrlSegment("id", "1");

            var resp = client.Execute(req);

            return resp.Content;
        }

        public string GetSourceType { get; set; }
    }
}