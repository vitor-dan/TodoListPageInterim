
using Microsoft.EntityFrameworkCore;
using TodoListAPI.Domain.Entities;

namespace TodoListAPI.Infraestructure.Context
{
    public class TodoDbContext: DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options): base(options)
        {
        }

        public DbSet<Todo> Todos{ get; set; }
    }
}
