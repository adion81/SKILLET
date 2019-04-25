using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace skillet.Models
{
    public class Household
    {
        [Key]
        public int HouseholdId { get; set;}

        public string HouseName { get; set; }

        public string HouseStreet { get; set; }

        public string HouseCity { get; set; }

        public string HouseState { get; set; }

        public int HouseZip { get; set; }

        public List<User> Members { get; set; }

        public User Head { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

    }
}