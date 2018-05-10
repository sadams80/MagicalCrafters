using System;

namespace MagicalCrafters.BLL.Models.BLL
{
    public class Completed_Projects : Projects
    {
        public new int User_Id { get; set; }
        public string Notes { get; set; }
    }
}
