using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CharacterManagerData
{
    
    public class CharacterManagerDBContext : DbContext
    {
        private static IConfigurationRoot _configeration;

        public CharacterManagerDBContext()
        {
            // left blank for scaffolding
        }
        public CharacterManagerDBContext(DbContextOptions options)
        {
            // left blank to set options
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            _configeration  = builder.Build();
            var cnstr = _configeration.GetConnectionString("MyCharacterManager");
            optionsbuilder.UseSqlServer(cnstr);
                
        }
    }
}