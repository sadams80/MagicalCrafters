using System;

namespace MagicalCrafters.BLL.Models.BLL
{
    public class Flagged_ItemsBLL
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
