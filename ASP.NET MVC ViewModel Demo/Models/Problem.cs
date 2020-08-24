using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Problem
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Treatment> Treatment { get; set; }
    }
}
