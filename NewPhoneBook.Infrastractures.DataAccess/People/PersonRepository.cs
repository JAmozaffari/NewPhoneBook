using NewPhoneBook.Core.Contracts.People;
using NewPhoneBook.Infrastractures.DataAccess.Common;
using PhoneBook.Domain.Core.People;
using PhoneBook.Infrastructures.DataLayer.Common;

namespace NewPhoneBook.Infrastractures.DataAccess.People
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(PhoneBookContext dbContext) : base(dbContext)
        {
        }
    }
}
