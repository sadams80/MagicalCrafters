
namespace MagicalCrafters.DAL.Models.DAL
{
    public class Favorite_ProjectsDAL
    {
        public int User_Id { get; set; }
        public int Project_Id { get; set; }
        public string Notes { get; set; }
        public ProjectsDAL Project { get; set; }
        public CraftsDAL Craft { get; set; }
    }
}
