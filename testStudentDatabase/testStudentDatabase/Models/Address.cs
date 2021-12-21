using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testStudentDatabase.Models
{
    public class Address 
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string DiemTB { get; set; }
        public string Class { get; set; }

    }
}
