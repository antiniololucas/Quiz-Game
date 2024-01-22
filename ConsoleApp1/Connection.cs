using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Connection
    {
       public FirstObject ObjApi = new FirstObject();

        public async Task Conectar()
        {
            string url = "https://opentdb.com/api.php?amount=15&category=11&difficulty=easy&type=multiple";
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                ObjApi = JsonSerializer.Deserialize<FirstObject>(content);
            }
            else
            {
                Console.WriteLine("Error al obtener preguntas");
            }
        }
    }
}
