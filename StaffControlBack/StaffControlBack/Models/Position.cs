using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }
        public string PositionName { get; set; }
    }
}
