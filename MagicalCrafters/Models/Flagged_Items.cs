using System;
using System.ComponentModel.DataAnnotations;

namespace MagicalCrafters.Models
{
    public class Flagged_Items
    {
        public int Flag_Id { get; set; }
        public int User_Id { get; set; }
        public int Source_Id { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool Completed { get; set; }
        public Sources Source { get; set; }
        public Users User { get; set; }
    }
}