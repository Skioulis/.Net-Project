using System.Net.NetworkInformation;

namespace BlazorApp.Client.Static
{
    public class Endpoint
    {
        public static string Prefix = "api";


        public static string CustomersPage = "customers";

        public static string CustomersEndpoint = $"{Prefix}/{CustomersPage}/";
    }
}
