using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoEntityFramework.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}