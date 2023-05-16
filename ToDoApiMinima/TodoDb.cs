using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace ApiMinima
{
    class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> option) : base(option) { }
        public DbSet<Todo> Todos => Set<Todo>();
    }
}
