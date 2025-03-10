using AgendamentodeTarefasAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendamentodeTarefasAPI.Context;

public class OrganizadorContext : DbContext
{
    public OrganizadorContext(DbContextOptions<OrganizadorContext> options ) : base(options) {}
    public DbSet<Tarefa>  Tarefas { get; set; }
    
}