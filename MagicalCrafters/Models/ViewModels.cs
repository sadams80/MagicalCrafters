using System.Collections.Generic;

namespace MagicalCrafters.Models
{
    public class ViewModels
    {
        public Announcements SingleAnnouncement { get; set; }
        public List<Announcements> Announcements { get; set; }
        public Comments SingleComment { get; set; }
        public List<Comments> Comments { get; set; }
        public Completed_Projects SingleCompleted_Project { get; set; }
        public List<Completed_Projects> Completed_Projects { get; set; }
        public Crafts SingleCraft { get; set; }
        public List<Crafts> Crafts { get; set; }
        public Favorite_Projects SingleFavorite_Project { get; set; }
        public List<Favorite_Projects> Favorite_Projects { get; set; }
        public Flagged_Items SingleFlagged_Item { get; set; }
        public List<Flagged_Items> Flagged_Items { get; set; }
        public Houses SingleHouse { get; set; }
        public List<Houses> Houses { get; set; }
        public Ongoing_Projects SingleOngoing_Project { get; set; }
        public List<Ongoing_Projects> Ongoing_Projects { get; set; }
        public Projects SingleProject { get; set; }
        public List<Projects> Projects { get; set; }
        public Roles SingleRole { get; set; }
        public List<Roles> Roles { get; set; }
        public Skill_Levels SingleSkill_Level { get; set; }
        public List<Skill_Levels> Skill_Levels { get; set; }
        public Sources SingleSource { get; set; }
        public List<Sources> Sources { get; set; }
        public Users SingleUser { get; set; }
        public List<Users> Users { get; set; }
        public Users_Info SingleUsers_Info { get; set; }
        public List<Users_Info> Users_Info { get; set; }

        public ViewModels()
        {
            SingleAnnouncement = new Announcements();
            Announcements = new List<Announcements>();
            SingleComment = new Comments();
            Comments = new List<Comments>();
            SingleCompleted_Project = new Completed_Projects();
            Completed_Projects = new List<Completed_Projects>();
            SingleCraft = new Crafts();
            Crafts = new List<Crafts>();
            SingleFavorite_Project = new Favorite_Projects();
            Favorite_Projects = new List<Favorite_Projects>();
            SingleFlagged_Item = new Flagged_Items();
            Flagged_Items = new List<Flagged_Items>();
            SingleHouse = new Houses();
            Houses = new List<Houses>();
            SingleOngoing_Project = new Ongoing_Projects();
            Ongoing_Projects = new List<Ongoing_Projects>();
            SingleProject = new Projects();
            Projects = new List<Projects>();
            SingleRole = new Roles();
            Roles = new List<Roles>();
            SingleSkill_Level = new Skill_Levels();
            Skill_Levels = new List<Skill_Levels>();
            SingleSource = new Sources();
            Sources = new List<Sources>();
            SingleUser = new Users();
            Users = new List<Users>();
            SingleUsers_Info = new Users_Info();
            Users_Info = new List<Users_Info>();
        }
    }
}