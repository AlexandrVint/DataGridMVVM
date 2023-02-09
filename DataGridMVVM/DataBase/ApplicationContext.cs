using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGridMVVM.Models;
using Microsoft.EntityFrameworkCore;

namespace DataGridMVVM.DataBase
{
    internal class ApplicationContext:DbContext
    {
        // коллекция лифтовых шахт
        public DbSet<Multiplier> Multipliers { get; set; }

        // метод создания файла базы данных с данными ElevatorShaft
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=matematicapp.db");
        }
    }
}
