using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Patient
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public List<Problem> Problems { get; set; }
    }
}
