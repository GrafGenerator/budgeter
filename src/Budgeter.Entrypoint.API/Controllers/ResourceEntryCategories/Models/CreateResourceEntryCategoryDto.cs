﻿namespace Budgeter.Entrypoint.API.Controllers.ResourceEntryCategories.Models
{
    public class CreateResourceEntryCategoryDto
    {
        public string Name { get; set; }
        public long? ParentId { get; set; }
    }
}