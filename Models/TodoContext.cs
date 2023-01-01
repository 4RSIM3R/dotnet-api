using Microsoft.EntityFrameworkCore;
using BasicApi.Models;

namespace BasicApi.Models;

public class TodoContext : DbContext
{

    public TodoContext(DbContextOptions<TodoContext> options) : base(options)
    {

    }

    public DbSet<TodoItem> TodoItems = null!;

    public DbSet<BasicApi.Models.TodoItem> TodoItem { get; set; } = default!;

}