using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Web_Message_Try2
{
    public class UserDataBase : DbContext
    {
        public UserDataBase() => Database.EnsureCreated();



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost; user=root; password=aternosru123; database=WebMessageDB;",
                            ServerVersion.AutoDetect("server=localhost; user=root; password=aternosru123; database=WebMessageDB;"));
        }
    }
}
