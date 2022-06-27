using Radzen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm.Models
{
    public  class Category
    {
        public int Id { get; set; }
        [DisplayName("CATEGORY NAME"), Required]
        public string Name { get; set; }
        
    }
}
