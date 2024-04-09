using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared.Domain.Name
{
    public static class PrintClassName
    {
        public static string PrintName(object obj)
        {
            if (obj != null)
            {
                if (obj is Employee e)
                {
                    return e.Name;
                }
                else if (obj is Manager m)
                {
                    return m.Name;
                }
                else
                {
                    return "Not valid type";
                }

            }
            return "not Found";
        }
    }
}
