using NewPhoneBook.Core.Contracts.Tags;
using NewPhoneBook.Infrastractures.DataAccess.Common;
using PhoneBook.Domain.Core.Tags;
using PhoneBook.Infrastructures.DataLayer.Common;

namespace NewPhoneBook.Infrastractures.DataAccess.Tags
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(PhoneBookContext dbContext) : base(dbContext)
        {
        }
    }
}
