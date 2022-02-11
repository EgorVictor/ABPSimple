using Acme.BookStore.Books;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore
{
    public interface IBookAppService:ICrudAppService<BookDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateBookDto>
    {
        //ICrudAppService定义了常见的CRUD方法
    }
}
