using System;

namespace MagicalCrafters.BLL.Models.BLL
{
    public class HousesBLL
    {
        public int House_Id { get; set; }
        public int Source_Id { get; set; }
        public string Name { get; set; }
        public string Motto { get; set; }
        public long Points { get; set; }
        public Users_InfoBLL Users_Info { get; set; }
    }
}
