using NewPhoneBook.Core.Contracts.Common;
using PhoneBook.Domain.Core.Phones;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewPhoneBook.Core.Contracts.Phones
{
   public interface IPhoneRepository : IBaseRepository<Phone>
    {
    }
}
