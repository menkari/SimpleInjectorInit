using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using SimpleInjectorInit.Interfaces;

namespace SimpleInjectorInit.Repositories
{
    public class TextBasicRepository : IBasicRepository
    {
        public string GetHelloWorld()
        {
            var returnText = "Text Repo not initialised!";

            // Pull this information from the file system..
            var path = ConfigurationManager.AppSettings["TextRepositoryLocation"];
            var filePath = string.Format("{0}{1}", path, "BasicTextRepo.txt");

            using (var sr = new StreamReader(filePath))
            {
                returnText = sr.ReadToEnd();
            }

            return returnText;
        }

        public string GetSourceType { get; set; }
    }
}