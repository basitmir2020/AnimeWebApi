using AnimeWebApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AnimeWebApi.DataBase
{
    public class AppDbContext : IdentityDbContext<ApiUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
