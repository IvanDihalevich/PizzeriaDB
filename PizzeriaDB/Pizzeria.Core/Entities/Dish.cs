using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Core.Entities
{
    public class Dish
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public Category Сategory { get; set; }
        public string Ingredients { get; set; }

        public virtual ICollection<Prices> Prices { get; set; }
        public virtual ICollection<Orders_Dishes> Order_Dishes { get; set; }
    }
}
