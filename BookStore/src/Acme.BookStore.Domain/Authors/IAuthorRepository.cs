using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Authors
{
    public interface IAuthorRepository:IRepository<Author,Guid>
    {
        /// <summary>
        /// 此方法仅用于学习,IRepository中已经定义IQueryable
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<Author> FindByNameAsync(string name);

        Task<List<Author>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            string filter = null
        );
    }
}
