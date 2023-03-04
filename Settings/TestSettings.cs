using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnit.TestAutomation.Module.Driver;

namespace xUnit.TestAutomation.Module.Settings
{
    public class TestSettings
    {

        public BrowserType BrowserType { get; set; }
        public string? ApplicationUrl { get; set; }
        public int TimeoutInterval { get; set; }


    }
}
