

namespace MagicalCrafters.Models
{
    public class Favorite_Projects
    {
        public int User_Id { get; set; }
        public int Project_Id { get; set; }
        public string Notes { get; set; }
        public Projects Project { get; set; }
        public Crafts Craft { get; set; }
    }
}