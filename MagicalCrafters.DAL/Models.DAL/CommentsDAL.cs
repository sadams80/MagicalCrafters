﻿using System;

namespace MagicalCrafters.DAL.Models.DAL
{
    public class CommentsDAL
    {
        public int Comment_Id { get; set; }
        public int User_Id { get; set; }
        public int Source_Id { get; set; }
        public int Parent_Id { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool isFlagged { get; set; }
        public bool isDeleted { get; set; }
    }
}
