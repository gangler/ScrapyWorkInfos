using System;
using System.Collections.Generic;
using System.Text;

namespace FindWork.Models
{
    public class CompInfo
    {
        public string CompName { get; set; }
        public string CompType { get; set; }
        public string CompSize { get; set; }
        public string City { get; set; }
        public string Money { get; set; }
        public string EduLevel { get; set; }
        public string WorkExp { get; set; }
        public List<string> WelFare { get; set; }
        public string Area { get; set; }
    }
}
