using System;

namespace MagicalCrafters.DAL.Models.DAL
{
    public class Flagged_Items : Sources
    {
        public int Flag_Id { get; set; }
        public int User_Id { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool Completed { get; set; }
    }
}
