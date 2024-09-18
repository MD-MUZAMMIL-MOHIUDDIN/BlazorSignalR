using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Blazorwebserverapp;
using Blazorwebserverapp.Models;

namespace Blazorwebserverapp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Blazorwebserverapp.Movies> Movies { get; set; } = default!;
        public DbSet<Blazorwebserverapp.Models.Conversation> Conversation { get; set; } = default!;
        public DbSet<Blazorwebserverapp.Models.Group> Group { get; set; } = default!;
        public DbSet<Blazorwebserverapp.Models.GroupMember> GroupMember { get; set; } = default!;

        public DbSet<GroupMessage> GroupMessage { get; set; } = default!;
        public DbSet<GroupMessageTrack> GroupMessageTrack { get; set; } = default!;
    }
}
