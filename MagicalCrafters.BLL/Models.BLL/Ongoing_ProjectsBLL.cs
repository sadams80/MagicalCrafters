

namespace MagicalCrafters.BLL.Models.BLL
{
    public class Ongoing_ProjectsBLL
    {
        public int User_Id { get; set; }
        public int Project_Id { get; set; }
        public string Notes { get; set; }
        public ProjectsBLL Projecct { get; set; }
        public CraftsBLL Craft { get; set; }
    }
}
