using Microsoft.EntityFrameworkCore;
using SNTApiV.Model;
using System.Xml;
using MySql.Data.MySqlClient;

namespace SNTApiV.App
{
    public class ApplicationContext : DbContext
    {
        private const string Server = "217.25.90.41";
        private const string UserName = "Viktor";
        private const string Password = "20022002Vk2002Vk*Vk";
        private const string DbName = "snt_buhgalter";  
        private const int Port = 3306;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql($"Server={Server};database={DbName};Port={Port};Uid={UserName};Pwd={Password}", new MySqlServerVersion(new Version(8, 0, 36)));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<пользователи>().HasOne(x => x.Rроль).WithMany().HasForeignKey(x => x.IDРольПользователя).IsRequired();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Должность> Должностьs { get; set; }

        public DbSet<Карточки_садоводов> Карточки_Садоводовs { get; set; }

        public DbSet<Оплата_взносов> Оплата_Взносовs { get; set; }

        public DbSet<пользователи> Пользователиs { get; set; }

        public DbSet<Работники> Работникиs { get; set; }

        public DbSet<Роль> Рольs { get; set; }

        public DbSet<Сотки> Соткиs { get; set; }

        public DbSet<Улицы> Улицыs { get; set; }

        public DbSet<взносы_тариф> Взносы_Тарифs { get; set; }

        public DbSet<Тип_взноса> Тип_Взносаs { get; set; }
    }
}
