using System;
using Xunit;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace QiwiRestMoq.RestTests
{
    public class RestTests
    {
        [Fact]
        public async void TestRestData()
        {
            HttpClient client = new HttpClient();
            var stringTask = client.GetStringAsync("https://localhost:5001/api/user");
            var msg = await stringTask;

            Task.WaitAll();

            var json = JsonConvert.DeserializeObject(msg);
            JObject jo = JObject.Parse(json.ToString());

            var name = jo["children"][0]["name"].ToString();
            Assert.Equal("Name0", name);

            name = jo["children"][1]["name"].ToString();
            Assert.Equal("Name1", name);

            var count = jo["children"].Children().GetEnumerator();
            Assert.Equal("Name1", name);
        }
    }
}
