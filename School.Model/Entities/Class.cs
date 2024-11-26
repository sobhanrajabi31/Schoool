using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model.Entities
{
    public class Class
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Capacity { get; set; }
        public List<Register> Registers { get; set; }
    }
}
