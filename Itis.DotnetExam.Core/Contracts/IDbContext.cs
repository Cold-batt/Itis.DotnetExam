using Itis.DotnetExam.Models;
using Microsoft.EntityFrameworkCore;

namespace Itis.DotnetExam.BLL.Contracts;

/// <summary>
/// Контекст БД
/// </summary>
public interface IDbContext
{
    /// <summary>
    /// Монстры
    /// </summary>
    public DbSet<Monster> Monsters { get; set; }
}