﻿using AcBlog.Data.Models;
using AcBlog.Data.Models.Actions;
using System.Net.Http;
using System.Threading.Tasks;

namespace AcBlog.SDK.API
{
    internal class CategoryService : BaseApiService<Category, CategoryQueryRequest>, ICategoryService
    {
        public CategoryService(IBlogService blog, HttpClient httpClient) : base(blog, httpClient)
        {
        }

        protected override string PrepUrl => "/Categories";
    }
}
