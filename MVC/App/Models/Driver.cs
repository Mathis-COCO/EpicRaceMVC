using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Driver
    {
        public int ID { get; set; }
        public string? LastName { get; set; }
        public string? FirstMidName { get; set; }
        public DateTime Birthdate { get; set; }
        public int Rank { get;set; }
    }
}