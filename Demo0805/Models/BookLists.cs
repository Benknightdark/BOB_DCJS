using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using L10N;

namespace Demo0805.Models
{
    public class BookLists
    {
        public class BookAll
        {
            [Display(ResourceType = typeof(L10N.Resource), Name = "name")]
            [Required]
            public string name { get; set; }
            [Display(ResourceType = typeof(L10N.Resource), Name = "quantity")]
            [Required]
            public int amount { get; set; }
        }

        public class BookSelect
        {
            [Display(ResourceType = typeof(L10N.Resource), Name = "bookname")]
            [Required]
            public string bookname { get; set; }
            [Display(ResourceType = typeof(L10N.Resource), Name = "author")]
            [Required]
            public string author { get; set; }
            [Display(ResourceType = typeof(L10N.Resource), Name = "quantity")]
            [Required]
            public int?  quantity { get; set; }
        }
    }
}