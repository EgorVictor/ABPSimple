/**
* 
* BookAppService派生自CrudAppService<...>它实现由ICrudAppService.
* BookAppService注入IRepository<Book, Guid>是Book实体的默认存储库。ABP 自动为每个聚合根（或实体）创建默认存储库。请参阅存储库文档。
* BookAppService使用IObjectMapper服务（请参阅）将对象映射Book到BookDto对象以及将对象映射CreateUpdateBookDto到Book对象。
* Startup 模板使用AutoMapper库作为对象映射提供者。我们之前已经定义了映射，因此它将按预期工作。
* 
* 
*/
using Acme.BookStore.Books;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Service
{
    public class BookAppService : CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBookDto>, IBookAppService
    {
        public BookAppService(IRepository<Book, Guid> repository) : base(repository)
        {
        }
    }


}
