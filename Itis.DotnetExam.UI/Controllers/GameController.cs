using Itis.DotnetExam.Models;
using Itis.DotnetExam.UI.Constants;
using Microsoft.AspNetCore.Mvc;

namespace Itis.DotnetExam.UI.Controllers;

/// <summary>
/// Контроллер для игры
/// </summary>
public class GameController : Controller
{
    private Player? _player { get; set; }

    /// <summary>
    /// Старт игры
    /// </summary>
    /// <returns></returns>
    [Route("game")]
    [HttpGet]
    public async Task<IActionResult> Game() 
        => View();

    /// <summary>
    /// Отобразить результат сражения
    /// </summary>
    /// <param name="player">Игрок</param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> GetFightResult(Player player)
    {
        var client = new HttpClient();
        var monster = (await client.GetFromJsonAsync<Monster>(BlAccessConstants.RandomMonsterUrl))!;
        var response = await client.PostAsJsonAsync(
            BlAccessConstants.FightUrl, 
            new Opponents(player, monster));

        var fightResult = await response.Content.ReadFromJsonAsync<FightResult>();

        return View(fightResult);
    }
}