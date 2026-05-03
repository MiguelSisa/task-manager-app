using Microsoft.EntityFrameworkCore;
using TaskManager.API.Models;
using System;

namespace TaskManager.API.Data
{
public class AppDbContext : DbContext
{
	public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) { }

	public DbSet<User> Users => Set<User>();
    public DbSet<TaskItem> Task => Set<TaskItem>();
    public DbSet<Project> Projects => Set<Project>();
}
}