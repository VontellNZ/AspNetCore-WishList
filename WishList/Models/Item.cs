using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WishList.Models
{
    public class Item
    {
        [Required] [MaxLength(50)]
        public string Description { get; set; }
        public int Id { get; set; }
    }
}
