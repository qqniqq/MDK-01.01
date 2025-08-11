using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_3.Models
{
    public class MenuGroup
    {
        public string GroupName { get; set; }
        public List<Dish> Dishes { get; set; } = new List<Dish>();
    }
}
