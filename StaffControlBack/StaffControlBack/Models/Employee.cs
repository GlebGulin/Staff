using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public DateTime Hired { get; set; }
        public DateTime Fired { get; set; }
        public int PositionId { get; set; }
        //public string PositionName { get; set; }
        [ForeignKey("PositionId")]
        public virtual Position PositionOfEpmloyee { get; set; }

    }
}
