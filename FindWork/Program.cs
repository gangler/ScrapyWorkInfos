using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Net;

namespace FindWork
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest request = WebRequest.Create("https://fe-api.zhaopin.com/c/i/sou?pageSize=90&cityId=538&salary=0,0&workExperience=0103&education=-1&companyType=-1&employmentType=-1&jobWelfareTag=-1&kw=.net&kt=3&=0&_v=0.42887844&x-zp-page-request-id=ed116367bd8a4329b746eea939046a4d-1565616935394-322677&x-zp-client-id=b29d7caf-01d4-4e18-8637-7f1d035208b5") as HttpWebRequest;
            request.Method = "GET";
            request.ProtocolVersion = HttpVersion.Version10;
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";
            StreamReader str = new StreamReader(request.GetResponse().GetResponseStream());
            Console.WriteLine(str.ReadToEnd());
            Console.ReadLine();
        }
    }
}
