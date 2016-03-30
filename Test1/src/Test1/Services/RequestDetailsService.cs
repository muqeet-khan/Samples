using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Services
{
    public class RequestDetailsService
    {
        private List<string> Detail { get; set; }

        public RequestDetailsService()
        {
            Detail = new List<string>();
        }

        public void AddDetail(string detail)
        {
            Detail.Add(detail);
        }

        public string GetDetail()
        {
            return Detail[0];
        }
    }

    public class ServerDetailsService
    {
        private List<string> Detail { get; set; }

        public ServerDetailsService()
        {
            Detail = new List<string>();
        }

        public void AddDetail(string detail)
        {
            Detail.Add(detail);
        }

        public string GetDetail()
        {
            return Detail[0];
        }
    }
}
