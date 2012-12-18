using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleInjectorInit.Interfaces
{
    public interface IBasicRepository
    {
        string GetHelloWorld();

        string GetSourceType { get; set; }

    }
}