using System;

namespace MagicalCrafters.BLL.Models.BLL
{
    public class AnnouncementsBLL
    {
        public int Announcement_Id { get; set; }
        public int User_Id { get; set; }
        public int Source_Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool isFlagged { get; set; }
        public bool isDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public UsersBLL User { get; set; }
        public Users_InfoBLL User_Info { get; set; }
    }
}
