using BlazorApp.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared.Static
{
    public static class CountryRepository
    {
        public static List<Country> countries = new List<Country>()
        {//apo edw
            new Country {
        CountryName = "Afghanistan",
                PhoneCode = "93"
        },
            new Country {
        CountryName = "Albania",
        PhoneCode = "355"
    },
    new Country {
        CountryName = "Algeria",
        PhoneCode = "213"
    },
    new Country {
    CountryName = "American Samoa",
        PhoneCode = "1-684"
    },
new Country {
    CountryName = "Andorra",
        PhoneCode = "376"
    },
new Country {
    CountryName = "Angola",
        PhoneCode = "244"
    },
new Country {
    CountryName = "Anguilla",
        PhoneCode = "1-264"
    },
new Country {
    CountryName = "Antarctica",
        PhoneCode = "672"
    },
new Country {
    CountryName = "Antigua and Barbuda",
        PhoneCode = "1-268"
    },
new Country {
    CountryName = "Argentina",
        PhoneCode = "54"
    },
new Country {
    CountryName = "Armenia",
        PhoneCode = "374"
    },
new Country {
    CountryName = "Aruba",
        PhoneCode = "297"
    },
new Country {
    CountryName = "Australia",
        PhoneCode = "61"
    },
new Country {
    CountryName = "Austria",
        PhoneCode = "43"
    },
new Country {
    CountryName = "Azerbaijan",
        PhoneCode = "994"
    },
new Country {
    CountryName = "Bahamas",
        PhoneCode = "1-242"
    },
new Country {
    CountryName = "Bahrain",
        PhoneCode = "973"
    },
new Country {
    CountryName = "Bangladesh",
        PhoneCode = "880"
    },
new Country {
    CountryName = "Barbados",
        PhoneCode = "1-246"
    },
new Country {
    CountryName = "Belarus",
        PhoneCode = "375"
    },
new Country {
    CountryName = "Belgium",
        PhoneCode = "32"
    },
new Country {
    CountryName = "Belize",
        PhoneCode = "501"
    },
new Country {
    CountryName = "Benin",
        PhoneCode = "229"
    },
new Country {
    CountryName = "Bermuda",
        PhoneCode = "1-441"
    },
new Country {
    CountryName = "Bhutan",
        PhoneCode = "975"
    },
new Country {
    CountryName = "Bolivia",
        PhoneCode = "591"
    },
new Country {
    CountryName = "Bosnia and Herzegovina",
        PhoneCode = "387"
    },
new Country {
    CountryName = "Botswana",
        PhoneCode = "267"
    },
new Country {
    CountryName = "Brazil",
        PhoneCode = "55"
    },
new Country {
    CountryName = "British Indian Ocean Territory",
        PhoneCode = "246"
    },
new Country {
    CountryName = "British Virgin Islands",
        PhoneCode = "1-284"
    },
new Country {
    CountryName = "Brunei",
        PhoneCode = "673"
    },
new Country {
    CountryName = "Bulgaria",
        PhoneCode = "359"
    },
new Country {
    CountryName = "Burkina Faso",
        PhoneCode = "226"
    },
new Country {
    CountryName = "Burundi",
        PhoneCode = "257"
    },
new Country {
    CountryName = "Cambodia",
        PhoneCode = "855"
    },
new Country {
    CountryName = "Cameroon",
        PhoneCode = "237"
    },
new Country {
    CountryName = "Canada",
        PhoneCode = "1"
    },
new Country {
    CountryName = "Cape Verde",
        PhoneCode = "238"
    },
new Country {
    CountryName = "Cayman Islands",
        PhoneCode = "1-345"
    },
new Country {
    CountryName = "Central African Republic",
        PhoneCode = "236"
    },
new Country {
    CountryName = "Chad",
        PhoneCode = "235"
    },
new Country {
    CountryName = "Chile",
        PhoneCode = "56"
    },
new Country {
    CountryName = "China",
        PhoneCode = "86"
    },
new Country {
    CountryName = "Christmas Island",
        PhoneCode = "61"
    },
new Country {
    CountryName = "Cocos Islands",
        PhoneCode = "61"
    },
new Country {
    CountryName = "Colombia",
        PhoneCode = "57"
    },
new Country {
    CountryName = "Comoros",
        PhoneCode = "269"
    },
new Country {
    CountryName = "Cook Islands",
        PhoneCode = "682"
    },
new Country {
    CountryName = "Costa Rica",
        PhoneCode = "506"
    },
new Country {
    CountryName = "Croatia",
        PhoneCode = "385"
    },
new Country {
    CountryName = "Cuba",
        PhoneCode = "53"
    },
new Country {
    CountryName = "Curacao",
        PhoneCode = "599"
    },
new Country {
    CountryName = "Cyprus",
        PhoneCode = "357"
    },
new Country {
    CountryName = "Czech Republic",
        PhoneCode = "420"
    },
new Country {
    CountryName = "Democratic Republic of the Congo",
        PhoneCode = "243"
    },
new Country {
    CountryName = "Denmark",
        PhoneCode = "45"
    },
new Country {
    CountryName = "Djibouti",
        PhoneCode = "253"
    },
new Country {
    CountryName = "Dominica",
        PhoneCode = "1-767"
    },
new Country {
    CountryName = "Dominican Republic",
        PhoneCode = "1-809, 1-829, 1-849"
    },
new Country {
    CountryName = "East Timor",
        PhoneCode = "670"
    },
new Country {
    CountryName = "Ecuador",
        PhoneCode = "593"
    },
new Country {
    CountryName = "Egypt",
        PhoneCode = "20"
    },
new Country {
    CountryName = "El Salvador",
        PhoneCode = "503"
    },
new Country {
    CountryName = "Equatorial Guinea",
        PhoneCode = "240"
    },
new Country {
    CountryName = "Eritrea",
        PhoneCode = "291"
    },
new Country {
    CountryName = "Estonia",
        PhoneCode = "372"
    },
new Country {
    CountryName = "Ethiopia",
        PhoneCode = "251"
    },
new Country {
    CountryName = "Falkland Islands",
        PhoneCode = "500"
    },
new Country {
    CountryName = "Faroe Islands",
        PhoneCode = "298"
    },
new Country {
    CountryName = "Fiji",
        PhoneCode = "679"
    },
new Country {
    CountryName = "Finland",
        PhoneCode = "358"
    },
new Country {
    CountryName = "France",
        PhoneCode = "33"
    },
new Country {
    CountryName = "French Polynesia",
        PhoneCode = "689"
    },
new Country {
    CountryName = "Gabon",
        PhoneCode = "241"
    },
new Country {
    CountryName = "Gambia",
        PhoneCode = "220"
    },
new Country {
    CountryName = "Georgia",
        PhoneCode = "995"
    },
new Country {
    CountryName = "Germany",
        PhoneCode = "49"
    },
new Country {
    CountryName = "Ghana",
        PhoneCode = "233"
    },
new Country {
    CountryName = "Gibraltar",
        PhoneCode = "350"
    },
new Country {
    CountryName = "Greece",
        PhoneCode = "30"
    },
new Country {
    CountryName = "Greenland",
        PhoneCode = "299"
    },
new Country {
    CountryName = "Grenada",
        PhoneCode = "1-473"
    },
new Country {
    CountryName = "Guam",
        PhoneCode = "1-671"
    },
new Country {
    CountryName = "Guatemala",
        PhoneCode = "502"
    },
new Country {
    CountryName = "Guernsey",
        PhoneCode = "44-1481"
    },
new Country {
    CountryName = "Guinea",
        PhoneCode = "224"
    },
new Country {
    CountryName = "Guinea-Bissau",
        PhoneCode = "245"
    },
new Country {
    CountryName = "Guyana",
        PhoneCode = "592"
    },
new Country {
    CountryName = "Haiti",
        PhoneCode = "509"
    },
new Country {
    CountryName = "Honduras",
        PhoneCode = "504"
    },
new Country {
    CountryName = "Hong Kong",
        PhoneCode = "852"
    },
new Country {
    CountryName = "Hungary",
        PhoneCode = "36"
    },
new Country {
    CountryName = "Iceland",
        PhoneCode = "354"
    },
new Country {
    CountryName = "India",
        PhoneCode = "91"
    },
new Country {
    CountryName = "Indonesia",
        PhoneCode = "62"
    },
new Country {
    CountryName = "Iran",
        PhoneCode = "98"
    },
new Country {
    CountryName = "Iraq",
        PhoneCode = "964"
    },
new Country {
    CountryName = "Ireland",
        PhoneCode = "353"
    },
new Country {
    CountryName = "Isle of Man",
        PhoneCode = "44-1624"
    },
new Country {
    CountryName = "Israel",
        PhoneCode = "972"
    },
new Country {
    CountryName = "Italy",
        PhoneCode = "39"
    },
new Country {
    CountryName = "Ivory Coast",
        PhoneCode = "225"
    },
new Country {
    CountryName = "Jamaica",
        PhoneCode = "1-876"
    },
new Country {
    CountryName = "Japan",
        PhoneCode = "81"
    },
new Country {
    CountryName = "Jersey",
        PhoneCode = "44-1534"
    },
new Country {
    CountryName = "Jordan",
        PhoneCode = "962"
    },
new Country {
    CountryName = "Kazakhstan",
        PhoneCode = "7"
    },
new Country {
    CountryName = "Kenya",
        PhoneCode = "254"
    },
new Country {
    CountryName = "Kiribati",
        PhoneCode = "686"
    },
new Country {
    CountryName = "Kosovo",
        PhoneCode = "383"
    },
new Country {
    CountryName = "Kuwait",
        PhoneCode = "965"
    },
new Country {
    CountryName = "Kyrgyzstan",
        PhoneCode = "996"
    },
new Country {
    CountryName = "Laos",
        PhoneCode = "856"
    },
new Country {
    CountryName = "Latvia",
        PhoneCode = "371"
    },
new Country {
    CountryName = "Lebanon",
        PhoneCode = "961"
    },
new Country {
    CountryName = "Lesotho",
        PhoneCode = "266"
    },
new Country {
    CountryName = "Liberia",
        PhoneCode = "231"
    },
new Country {
    CountryName = "Libya",
        PhoneCode = "218"
    },
new Country {
    CountryName = "Liechtenstein",
        PhoneCode = "423"
    },
new Country {
    CountryName = "Lithuania",
        PhoneCode = "370"
    },
new Country {
    CountryName = "Luxembourg",
        PhoneCode = "352"
    },
new Country {
    CountryName = "Macau",
        PhoneCode = "853"
    },
new Country {
    CountryName = "Macedonia",
        PhoneCode = "389"
    },
new Country {
    CountryName = "Madagascar",
        PhoneCode = "261"
    },
new Country {
    CountryName = "Malawi",
        PhoneCode = "265"
    },
new Country {
    CountryName = "Malaysia",
        PhoneCode = "60"
    },
new Country {
    CountryName = "Maldives",
        PhoneCode = "960"
    },
new Country {
    CountryName = "Mali",
        PhoneCode = "223"
    },
new Country {
    CountryName = "Malta",
        PhoneCode = "356"
    },
new Country {
    CountryName = "Marshall Islands",
        PhoneCode = "692"
    },
new Country {
    CountryName = "Mauritania",
        PhoneCode = "222"
    },
new Country {
    CountryName = "Mauritius",
        PhoneCode = "230"
    },
new Country {
    CountryName = "Mayotte",
        PhoneCode = "262"
    },
new Country {
    CountryName = "Mexico",
        PhoneCode = "52"
    },
new Country {
    CountryName = "Micronesia",
        PhoneCode = "691"
    },
new Country {
    CountryName = "Moldova",
        PhoneCode = "373"
    },
new Country {
    CountryName = "Monaco",
        PhoneCode = "377"
    },
new Country {
    CountryName = "Mongolia",
        PhoneCode = "976"
    },
new Country {
    CountryName = "Montenegro",
        PhoneCode = "382"
    },
new Country {
    CountryName = "Montserrat",
        PhoneCode = "1-664"
    },
new Country {
    CountryName = "Morocco",
        PhoneCode = "212"
    },
new Country {
    CountryName = "Mozambique",
        PhoneCode = "258"
    },
new Country {
    CountryName = "Myanmar",
        PhoneCode = "95"
    },
new Country {
    CountryName = "Namibia",
        PhoneCode = "264"
    },
new Country {
    CountryName = "Nauru",
        PhoneCode = "674"
    },
new Country {
    CountryName = "Nepal",
        PhoneCode = "977"
    },
new Country {
    CountryName = "Netherlands",
        PhoneCode = "31"
    },
new Country {
    CountryName = "Netherlands Antilles",
        PhoneCode = "599"
    },
new Country {
    CountryName = "New Caledonia",
        PhoneCode = "687"
    },
new Country {
    CountryName = "New Zealand",
        PhoneCode = "64"
    },
new Country {
    CountryName = "Nicaragua",
        PhoneCode = "505"
    },
new Country {
    CountryName = "Niger",
        PhoneCode = "227"
    },
new Country {
    CountryName = "Nigeria",
        PhoneCode = "234"
    },
new Country {
    CountryName = "Niue",
        PhoneCode = "683"
    },
new Country {
    CountryName = "North Korea",
        PhoneCode = "850"
    },
new Country {
    CountryName = "Northern Mariana Islands",
        PhoneCode = "1-670"
    },
new Country {
    CountryName = "Norway",
        PhoneCode = "47"
    },
new Country {
    CountryName = "Oman",
        PhoneCode = "968"
    },
new Country {
    CountryName = "Pakistan",
        PhoneCode = "92"
    },
new Country {
    CountryName = "Palau",
        PhoneCode = "680"
    },
new Country {
    CountryName = "Palestine",
        PhoneCode = "970"
    },
new Country {
    CountryName = "Panama",
        PhoneCode = "507"
    },
new Country {
    CountryName = "Papua New Guinea",
        PhoneCode = "675"
    },
new Country {
    CountryName = "Paraguay",
        PhoneCode = "595"
    },
new Country {
    CountryName = "Peru",
        PhoneCode = "51"
    },
new Country {
    CountryName = "Philippines",
        PhoneCode = "63"
    },
new Country {
    CountryName = "Pitcairn",
        PhoneCode = "64"
    },
new Country {
    CountryName = "Poland",
        PhoneCode = "48"
    },
new Country {
    CountryName = "Portugal",
        PhoneCode = "351"
    },
new Country {
    CountryName = "Puerto Rico",
        PhoneCode = "1-787, 1-939"
    },
new Country {
    CountryName = "Qatar",
        PhoneCode = "974"
    },
new Country {
    CountryName = "Republic of the Congo",
        PhoneCode = "242"
    },
new Country {
    CountryName = "Reunion",
        PhoneCode = "262"
    },
new Country {
    CountryName = "Romania",
        PhoneCode = "40"
    },
new Country {
    CountryName = "Russia",
        PhoneCode = "7"
    },
new Country {
    CountryName = "Rwanda",
        PhoneCode = "250"
    },
new Country {
    CountryName = "Saint Barthelemy",
        PhoneCode = "590"
    },
new Country {
    CountryName = "Saint Helena",
        PhoneCode = "290"
    },
new Country {
    CountryName = "Saint Kitts and Nevis",
        PhoneCode = "1-869"
    },
new Country {
    CountryName = "Saint Lucia",
        PhoneCode = "1-758"
    },
new Country {
    CountryName = "Saint Martin",
        PhoneCode = "590"
    },
new Country {
    CountryName = "Saint Pierre and Miquelon",
        PhoneCode = "508"
    },
new Country {
    CountryName = "Saint Vincent and the Grenadines",
        PhoneCode = "1-784"
    },
new Country {
    CountryName = "Samoa",
        PhoneCode = "685"
    },
new Country {
    CountryName = "San Marino",
        PhoneCode = "378"
    },
new Country {
    CountryName = "Sao Tome and Principe",
        PhoneCode = "239"
    },
new Country {
    CountryName = "Saudi Arabia",
        PhoneCode = "966"
    },
new Country {
    CountryName = "Senegal",
        PhoneCode = "221"
    },
new Country {
    CountryName = "Serbia",
        PhoneCode = "381"
    },
new Country {
    CountryName = "Seychelles",
        PhoneCode = "248"
    },
new Country {
    CountryName = "Sierra Leone",
        PhoneCode = "232"
    },
new Country {
    CountryName = "Singapore",
        PhoneCode = "65"
    },
new Country {
    CountryName = "Sint Maarten",
        PhoneCode = "1-721"
    },
new Country {
    CountryName = "Slovakia",
        PhoneCode = "421"
    },
new Country {
    CountryName = "Slovenia",
        PhoneCode = "386"
    },
new Country {
    CountryName = "Solomon Islands",
        PhoneCode = "677"
    },
new Country {
    CountryName = "Somalia",
        PhoneCode = "252"
    },
new Country {
    CountryName = "South Africa",
        PhoneCode = "27"
    },
new Country {
    CountryName = "South Korea",
        PhoneCode = "82"
    },
new Country {
    CountryName = "South Sudan",
        PhoneCode = "211"
    },
new Country {
    CountryName = "Spain",
        PhoneCode = "34"
    },
new Country {
    CountryName = "Sri Lanka",
        PhoneCode = "94"
    },
new Country {
    CountryName = "Sudan",
        PhoneCode = "249"
    },
new Country {
    CountryName = "Suriname",
        PhoneCode = "597"
    },
new Country {
    CountryName = "Svalbard and Jan Mayen",
        PhoneCode = "47"
    },
new Country {
    CountryName = "Swaziland",
        PhoneCode = "268"
    },
new Country {
    CountryName = "Sweden",
        PhoneCode = "46"
    },
new Country {
    CountryName = "Switzerland",
        PhoneCode = "41"
    },
new Country {
    CountryName = "Syria",
        PhoneCode = "963"
    },
new Country {
    CountryName = "Taiwan",
        PhoneCode = "886"
    },
new Country {
    CountryName = "Tajikistan",
        PhoneCode = "992"
    },
new Country {
    CountryName = "Tanzania",
        PhoneCode = "255"
    },
new Country {
    CountryName = "Thailand",
        PhoneCode = "66"
    },
new Country {
    CountryName = "Togo",
        PhoneCode = "228"
    },
new Country {
    CountryName = "Tokelau",
        PhoneCode = "690"
    },
new Country {
    CountryName = "Tonga",
        PhoneCode = "676"
    },
new Country {
    CountryName = "Trinidad and Tobago",
        PhoneCode = "1-868"
    },
new Country {
    CountryName = "Tunisia",
        PhoneCode = "216"
    },
new Country {
    CountryName = "Turkey",
        PhoneCode = "90"
    },
new Country {
    CountryName = "Turkmenistan",
        PhoneCode = "993"
    },
new Country {
    CountryName = "Turks and Caicos Islands",
        PhoneCode = "1-649"
    },
new Country {
    CountryName = "Tuvalu",
        PhoneCode = "688"
    },
new Country {
    CountryName = "U.S. Virgin Islands",
        PhoneCode = "1-340"
    },
new Country {
    CountryName = "Uganda",
        PhoneCode = "256"
    },
new Country {
    CountryName = "Ukraine",
        PhoneCode = "380"
    },
new Country {
    CountryName = "United Arab Emirates",
        PhoneCode = "971"
    },
new Country {
    CountryName = "United Kingdom",
        PhoneCode = "44"
    },
new Country {
    CountryName = "United States",
        PhoneCode = "1"
    },
new Country {
    CountryName = "Uruguay",
        PhoneCode = "598"
    },
new Country {
    CountryName = "Uzbekistan",
        PhoneCode = "998"
    },
new Country {
    CountryName = "Vanuatu",
        PhoneCode = "678"
    },
new Country {
    CountryName = "Vatican",
        PhoneCode = "379"
    },
new Country {
    CountryName = "Venezuela",
        PhoneCode = "58"
    },
new Country {
    CountryName = "Vietnam",
        PhoneCode = "84"
    },
new Country {
    CountryName = "Wallis and Futuna",
        PhoneCode = "681"
    },
new Country {
    CountryName = "Western Sahara",
        PhoneCode = "212"
    },
new Country {
    CountryName = "Yemen",
        PhoneCode = "967"
    },
new Country {
    CountryName = "Zambia",
        PhoneCode = "260"
    },
new Country {
    CountryName = "Zimbabwe",
    PhoneCode = "263"
    } };
        public static Country? GetCountryByCountryName(string countryName)
        {

            return countries.FirstOrDefault(x => x.CountryName.ToLower() == countryName.ToLower());
        }
    }

}
