using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace QLNVSSV.WebApp.ApiIntergration
{
    public static class GetData<T>
    {
        public static List<T> GetList(string url) {

            var data = new List<T>();
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync();

                    data = (List<T>)JsonConvert.DeserializeObject(result.Result, typeof(List<T>));
                }
            }
            return data;
        }
    }
}
