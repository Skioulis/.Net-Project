using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared.Domain
{
    public class BingResponseModel
    {
        public string AuthenticationResultCode { get; set; }

        public Resourceset[] ResourceSets { get; set; }
        public int StatusCode { get; set; }
        public string StatusDescription { get; set; }

    }

    public class Resourceset
    {

        public Resource[] Resources { get; set; }
    }

    public class Resource
    {
        public string Type { get; set; }
        public Value[] value { get; set; } = null!;
    }

    public class Value
    {
        public string Type { get; set; }
        public Address Address { get; set; }
        public string Name { get; set; }
    }

    public class Address
    {
        public string CountryRegion { get; set; }
        public string Locality { get; set; }
        public string AdminDistrict { get; set; }
        public string AdminDistrict2 { get; set; }
        public string CountryRegionIso2 { get; set; }
        public string FormattedAddress { get; set; }
    }
}

