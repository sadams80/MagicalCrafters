using System;

namespace MagicalCrafters.DAL.Models.DAL
{
    public class ProjectsDAL
    {
        public int Project_Id { get; set; }
        public int User_Id { get; set; }
        public int Source_Id { get; set; }
        public int Craft_Id { get; set; }
        public int Skill_Id { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public bool isFlagged { get; set; }
        public bool isDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public UsersDAL User { get; set; }
        public Users_InfoDAL User_Info { get; set; }
        public CraftsDAL Craft { get; set; }
        public Skill_LevelsDAL Skill_Level { get; set; }
    }
}
