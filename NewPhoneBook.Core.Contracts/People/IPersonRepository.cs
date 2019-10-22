using NewPhoneBook.Core.Contracts.Common;
using PhoneBook.Domain.Core.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewPhoneBook.Core.Contracts.People
{
   public interface IPersonRepository : IBaseRepository<Person>
    {
    }
}
