using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using FindWork.Models;

namespace FindWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //HttpWebRequest request = WebRequest.Create("https://fe-api.zhaopin.com/c/i/sou?pageSize=90&cityId=538&salary=0,0&workExperience=0103&education=-1&companyType=-1&employmentType=-1&jobWelfareTag=-1&kw=.net&kt=3&=0&_v=0.42887844&x-zp-page-request-id=ed116367bd8a4329b746eea939046a4d-1565616935394-322677&x-zp-client-id=b29d7caf-01d4-4e18-8637-7f1d035208b5") as HttpWebRequest;
            //request.Method = "GET";
            //request.ProtocolVersion = HttpVersion.Version10;
            //request.ContentType = "application/x-www-form-urlencoded";
            //request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";
            //StreamReader str = new StreamReader(request.GetResponse().GetResponseStream());

            //将获得数据写入json文件
            string path = @"..\..\..\info.json";
            //using(StreamWriter sw = File.CreateText(path))
            //{
            //    sw.Write(str.ReadToEnd());
            //    Console.WriteLine("写入成功");
            //}


            using(StreamReader sr = File.OpenText(path))
            {
                JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(sr));
                IList<JToken> results = o["data"]["results"].Children().ToList();
                foreach(var item in results)
                {
                    CompInfo info = new CompInfo()
                    {
                        CompName = item["company"]["name"].ToString(),
                        CompSize = item["company"]["type"]["name"].ToString(),
                        CompType = item["company"]["size"]["name"].ToString(),
                        City = item["city"]["display"].ToString(),
                        Money = item["salary"].ToString(),
                        EduLevel = item["eduLevel"]["name"].ToString(),
                        WorkExp = item["workingExp"]["name"].ToString(),
                        WelFare = item["welfare"].Children().Select(t => t.ToString()).ToList(),
                        Area = item["businessArea"].ToString(),
                    };
                    string ss = "";
                }
                string a = "";
            }



            Console.ReadLine();
        }
    }
}
