using NewPhoneBook.Core.Contracts.Phones;
using NewPhoneBook.Infrastractures.DataAccess.Common;
using PhoneBook.Domain.Core.Phones;
using PhoneBook.Infrastructures.DataLayer.Common;

namespace NewPhoneBook.Infrastractures.DataAccess.Phones
{
    public class PhoneRepository : BaseRepository<Phone>, IPhoneRepository
    {
        public PhoneRepository(PhoneBookContext dbContext) : base(dbContext)
        {
        }
    }
}
