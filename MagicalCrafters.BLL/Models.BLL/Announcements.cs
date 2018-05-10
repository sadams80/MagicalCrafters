using System;

namespace MagicalCrafters.BLL.Models.BLL
{
    public class Announcements : Users_Info
    {
        public int Announcement_Id { get; set; }
        public new int Source_Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public new bool isFlagged { get; set; }
        public new bool isDeleted { get; set; }
        public new DateTime CreatedDate { get; set; }
        public new string LastModifiedBy { get; set; }
        public new DateTime LastModifiedDate { get; set; }
    }
}
