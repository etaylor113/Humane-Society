using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PracticeASp.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        [ForeignKey("Person")]
        public int CarId { get; set; }
        public Person Person { get; set; }


    }
}