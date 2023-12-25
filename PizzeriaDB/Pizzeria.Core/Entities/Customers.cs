using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Core.Entities
{
    public class Customers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone_number { get; set; }
        public string Email { get; set; }
        public DateTime Dob {  get; set; }

        public virtual ICollection<Orders_Dishes> OrdersDishes { get; set; }
    }
}
