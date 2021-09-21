using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst_EF_1_1_.Models
{
    public class Student
    {
        
            public int Id { get; set; }
            public string Name { get; set; }

            public StudentAddress Address { get; set; }
        
    }
}
