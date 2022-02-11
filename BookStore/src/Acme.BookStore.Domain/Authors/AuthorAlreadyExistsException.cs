using System;
using System.Runtime.Serialization;
using Volo.Abp;

namespace Acme.BookStore.Authors
{
    /// <summary>
    /// 自定义错误消息,继承自BusinessException
    /// </summary>
    [Serializable]
    public class AuthorAlreadyExistsException : BusinessException
    {
        public AuthorAlreadyExistsException()
        {
        }

        public AuthorAlreadyExistsException(string name) : base(BookStoreDomainErrorCodes.AuthorAlreadyExists)
        {
            WithData("name", name);
        }

    
    }
}