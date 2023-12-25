using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Core.Entities
{
    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Waiters Waiter { get; set; }
        public Customers Customer { get; set; }
        public string Status { get; set; }
        public virtual ICollection<Orders_Dishes> Orders_Dishes { get; set; }
    }
}
