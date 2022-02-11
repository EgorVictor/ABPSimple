using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Books
{
    /// <summary>
    /// 用户新增或更新时从界面传递图书信息
    /// </summary>
    public class CreateUpdateBookDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public BookType Type { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublisherDate { get; set; }

        [Required]
        public float Price { get; set; }
    }
}
