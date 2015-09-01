using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Demo0805.Models
{
    public class BOBOrderList
    {
        public class OrderList
        {
            [Required]
            [Display(Name = "書店名稱")]
            public string name { get; set; }

            [Required]
            [Display(Name = "書籍名稱")]
            public string bookname { get; set; }

            [Required]
            [Display(Name = "書籍存貨數量")]
            public Nullable<int> quantity { get; set; }

            [Required]
            [Display(Name = "書籍編號")]
            public long? id { get; set; }

            [Required]
            [Display(Name = "書店編號")]
            public long? no  { get; set; }

            [Required]
            [Display(Name = "出版社")]
            public string publisher { get; set; }
        }
        public class BookStoreNo
        {
            public string SelectValue { get; set; }
        }
        
    }
}