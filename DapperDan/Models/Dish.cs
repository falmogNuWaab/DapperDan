using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDan.Models
{
    public class Dish
    {
        [Key]
        public int Id { get; set; }
        [MaxLength]
        public string Name { get; set; }
        public float Price { get; set; }
        public bool IsHealthy { get; set; }
        public bool isVegetarian { get; set; }
        [Range(1,10)]
        public int SpiceLevel { get; set; }

    }
}
