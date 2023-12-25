using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Core.Entities
{
    public class Waiters
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Work_exp {  get; set; }
        public int Age { get; set;}

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
