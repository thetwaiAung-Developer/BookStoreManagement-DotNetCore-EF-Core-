﻿using System;

namespace BookManagement.Dtos
{
    public class BookCategoryDto
    {
        public long Category_Id { get; set; }
        public string Category_Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
