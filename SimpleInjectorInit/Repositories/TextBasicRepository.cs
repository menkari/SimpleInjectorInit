using System;
using System.Collections.Generic;
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
            var filePath = @"C:\Temp\TextRepo\BasicTextRepo.txt";

            using (var sr = new StreamReader(filePath))
            {
                returnText = sr.ReadToEnd();
            }

            return returnText;
        }

        public string GetSourceType { get; set; }
    }
}