﻿using ElasticSearchExample.Core.Entities;

namespace ElasticSearchExample.Entities.DTOs.Posts
{
    public class PostInputDto : IDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public int ReadCount { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public List<int> PostTagIds { get; set; }
    }
}