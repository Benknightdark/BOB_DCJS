using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo0805.Models
{
    public partial class order
    {
        [Required]
        [Display(Name = "書店名稱")]
        public string name { get; set; }

        [Required]
        [Display(Name = "書籍名稱")]
        public string bookname { get; set; }

        [Required]
        [Display(Name = "出版社")]
        public string publisher { get; set; }

        [Display(ResourceType = typeof(L10N.Resource), Name = "city")]
        [Required]
        public string city { get; set; }
    }
}