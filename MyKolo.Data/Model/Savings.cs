using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKolo.Data.Model
{
    public class Savings
    {
        public int Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }

    }
}
