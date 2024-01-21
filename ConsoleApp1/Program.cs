using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ConsoleApp1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await StartGame.Start();
        }
    }
}
