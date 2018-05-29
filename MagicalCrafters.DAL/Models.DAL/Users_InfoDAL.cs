using System;

namespace MagicalCrafters.DAL.Models.DAL
{
    public class Users_InfoDAL
    {
        public int User_Id { get; set; }
        public int Role_Id { get; set; }
        public int Source_Id { get; set; }
        public int House_Id { get; set; }
        public string Email { get; set; }
        public bool isFlagged { get; set; }
        //public bool isDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public int Points { get; set; }
        public HousesDAL House { get; set; }
        public RolesDAL Role { get; set; }

        public Users_InfoDAL()
        {
            House = new HousesDAL();
            Role = new RolesDAL();
        }
    }
}
