using System;
using System.ComponentModel.DataAnnotations;

namespace MagicalCrafters.Models
{
    public class Projects
    {
        public int Project_Id { get; set; }
        public int Source_Id { get; set; }
        public int Skill_Id { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public bool isFlagged { get; set; }
        public bool isDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public Users User { get; set; }
        public Users_Info User_Info { get; set; }
        public Crafts Craft { get; set; }
    }
}