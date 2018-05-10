using System;

namespace MagicalCrafters.DAL.Models.DAL
{
    public class Projects : Crafts
    {
        public int Project_Id { get; set; }
        public new int Source_Id { get; set; }
        public int Skill_Id { get; set; }
        public new string Name { get; set; }
        public string Body { get; set; }
        public new bool isFlagged { get; set; }
        public new bool isDeleted { get; set; }
        public new DateTime CreatedDate { get; set; }
        public new string LastModifiedBy { get; set; }
        public new DateTime LastModifiedDate { get; set; }
    }
}
