using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PhoneBook.Infrastructures.DataLayer.Common
{
    public class PhoneBookContextFactory : IDesignTimeDbContextFactory<PhoneBookContext>
    {
  
        public PhoneBookContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PhoneBookContext>();
            builder.UseSqlServer("Server=MOZAFARI-PC\\SA;Database=NewPhoneBook;user id=sa;password=1234567890;");

            return new PhoneBookContext(builder.Options);
        }    
    }
}
