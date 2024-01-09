using Itis.DotnetExam.BLL.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Itis.DotnetExam.BLL.Controllers;

/// <summary>
/// Контроллер для сущности "Монстр"/>
/// </summary>
[Route("[controller]")]
public class MonsterController : Controller
{
    private readonly IDbContext _dbContext;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="dfContext">Контекст БД</param>
    public MonsterController(IDbContext dfContext)
    {
        _dbContext = dfContext;
    }

    /// <summary>
    /// Получить случайного монстра
    /// </summary>
    /// <returns>Случайный монстр</returns>
    [HttpGet]
    [Route("getMonster")]
    public async Task<JsonResult> GetVapodus(CancellationToken cancellationToken)
    {
        var random = new Random();
        var monsters = await _dbContext.Monsters.ToListAsync(cancellationToken);
        var count = monsters.Count;
        return new JsonResult(monsters[random.Next(0, count)]);
    }
}