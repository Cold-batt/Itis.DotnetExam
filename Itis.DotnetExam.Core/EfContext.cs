using Itis.DotnetExam.BLL.Contracts;
using Itis.DotnetExam.Models;
using Microsoft.EntityFrameworkCore;

namespace Itis.DotnetExam.BLL;

/// <inheritdoc cref="IDbContext"/>
public class EfContext : DbContext, IDbContext
{
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="options">-</param>
    public EfContext(DbContextOptions options)
    : base(options)
    {
    }

    /// <inheritdoc />
    public DbSet<Monster> Monsters { get; set; } = default!;

    /// <inheritdoc />
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var negrintuk = new Monster()
        {
            Id = Guid.NewGuid(),
            Name = "Negrintuk",
            HitPoints = 10,
            AttackModifier = 2,
            AttackPerRound = 2,
            Damage = "1d6",
            DamageModifier = 1,
            ArmorClass = 12
        };

        var gikitru = new Monster()
        {
            Id = Guid.NewGuid(),
            Name = "Gikitru",
            HitPoints = 20,
            AttackModifier = 4,
            AttackPerRound = 1,
            Damage = "1d8",
            DamageModifier = 2,
            ArmorClass = 15
        };

        var gorulus = new Monster()
        {
            Id = Guid.NewGuid(),
            Name = "Gorulus",
            HitPoints = 8,
            AttackModifier = 3,
            AttackPerRound = 1,
            Damage = "1d4",
            DamageModifier = 0,
            ArmorClass = 10
        };

        var vapodus = new Monster()
        {
            Id = Guid.NewGuid(),
            Name = "Vapodus",
            HitPoints = 100,
            AttackModifier = 10,
            AttackPerRound = 3,
            Damage = "2d10",
            DamageModifier = 5,
            ArmorClass = 18
        };

        modelBuilder.Entity<Monster>()
            .HasData(negrintuk, gikitru, gorulus, vapodus);

        modelBuilder.Entity<Monster>()
            .HasKey(x => x.Id);
    }
}