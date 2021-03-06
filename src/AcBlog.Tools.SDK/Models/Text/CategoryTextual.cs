﻿using AcBlog.Data.Models;

namespace AcBlog.Tools.SDK.Models.Text
{
    public class CategoryTextual : TextualBase<Category, CategoryTextual.Metadata>
    {
        public class Metadata
        {
            public string name { get; set; } = string.Empty;
        }

        protected override Metadata? GetMetadata(Category data) => new Metadata
        {
            name = data.Name
        };

        protected override void SetMetadata(Category data, Metadata meta)
        {
            if (!string.IsNullOrWhiteSpace(meta.name))
                data.Name = meta.name;
        }

        public Category InitialData { get; set; } = new Category();

        protected override Category CreateInitialData() => InitialData;
    }
}
