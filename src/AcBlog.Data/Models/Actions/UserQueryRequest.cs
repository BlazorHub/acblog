﻿namespace AcBlog.Data.Models.Actions
{
    public class UserQueryRequest
    {
        public string Nickname { get; set; } = string.Empty;

        public Pagination? Pagination { get; set; } = null;
    }
}
