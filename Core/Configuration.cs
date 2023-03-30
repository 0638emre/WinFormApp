using Microsoft.Extensions.Configuration;

namespace Core
{
    public static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../WebAPI"));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("WinFormAppDB");
            }
        }
    }
}
