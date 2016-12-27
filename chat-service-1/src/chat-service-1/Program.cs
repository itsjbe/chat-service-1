using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace chat_service_1
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var builder = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseKestrel()
                .UseUrls("http://+:5002");

            var host = builder.Build();
            host.Run();

            return 0;
        }
    }
}
