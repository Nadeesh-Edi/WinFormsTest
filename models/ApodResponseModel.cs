using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.models
{
    internal class ApodResponseModel
    {
        public string Copyright {  get; set; }
        public string Date { get; set; }
        public string Explanation { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
