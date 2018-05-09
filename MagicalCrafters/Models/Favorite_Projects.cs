

namespace MagicalCrafters.Models
{
    public class Favorite_Projects : Projects
    {
        public new int User_Id { get; set; }
        public string Notes { get; set; }
    }
}