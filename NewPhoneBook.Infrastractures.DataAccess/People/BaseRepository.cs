using PhoneBook.Infrastructures.DataLayer.Common;

namespace PhoneBook.Infrastructures.DataLayer.People
{
    public class BaseRepository<T>
    {
        private PhoneBookContext dbContext;

        public BaseRepository(PhoneBookContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}