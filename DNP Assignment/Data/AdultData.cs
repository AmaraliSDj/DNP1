using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FileData;
using Models;

namespace DNP_Assignment.Data
{
    public class AdultData : IAdultData
    {

      
        private FileContext adultFileContext;

        public AdultData()
        {

            adultFileContext = new FileContext();

        }

       

        public async Task<IList<Adult>> GetAdults()
        {
           
            using HttpClient client = new HttpClient();

            var httpResponseMessage = await client.GetAsync("https://localhost:5009/Adult");
            
            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                throw new Exception("failed to fetch data");
            }
            

            var readAsStringAsync = await httpResponseMessage.Content.ReadAsStringAsync();

            IList<Adult> adults = JsonSerializer.Deserialize<IList<Adult>>(readAsStringAsync, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });


            return adults;
        }

        public async Task<Adult>AddAdults(Adult adult)
        {
            using HttpClient client = new HttpClient();

            var adultSerialize = JsonSerializer.Serialize(adult);

            HttpContent httpContent = new StringContent(
                adultSerialize, Encoding.UTF8, "application/json");

            var httpResponseMessage = await client.PostAsync("https://localhost:5009/Adult", httpContent);
            
            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                throw new Exception("failed to add data");
            }

            return adult;

        }

        public async Task RemoveAdults(int adultId)
        {
            
            using HttpClient client = new HttpClient();
            var httpResponseMessage = await client.DeleteAsync($"https://localhost:5009/Adult/{adultId}");
            
            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                throw new Exception("failed to delete data");
            }
        }

        public  async Task<Adult> Update(Adult adult)
        {
            using HttpClient client = new HttpClient();

            var adultSerialize = JsonSerializer.Serialize(adult);

            HttpContent httpContent = new StringContent(
                adultSerialize, Encoding.UTF8, "application/json");

            var httpResponseMessage = await client.PatchAsync($"https://localhost:5009/Adult/{adult.Id}", httpContent);
            
            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                throw new Exception("failed to update data");
            }

            return adult;
        }

        public async Task<Adult> Get(int id)
        {
            using HttpClient client = new HttpClient();

            var httpResponseMessage = await client.GetAsync($"https://localhost:5009/Adult/{id}");
            
            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                throw new Exception("failed to fetch data by id");
            }
            

            var readAsStringAsync = await httpResponseMessage.Content.ReadAsStringAsync();

            Adult adults = JsonSerializer.Deserialize<Adult>(readAsStringAsync, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });


            return adults;

        }
    }
}