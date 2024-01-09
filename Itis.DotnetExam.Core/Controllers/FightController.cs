using Itis.DotnetExam.BLL.Contracts;
using Itis.DotnetExam.BLL.Services;
using Itis.DotnetExam.Models;
using Microsoft.AspNetCore.Mvc;

namespace Itis.DotnetExam.BLL.Controllers;

/// <summary>
/// Контроллер боя
/// </summary>
[Route("[controller]")]
public class FightController: Controller
{
    /// <summary>
    /// Расчитать исход боя
    /// </summary>
    /// <param name="opponents">Противники</param>
    /// <returns>Результат боя</returns>
    [HttpPost]
    [Route("calculateResult")]
    public JsonResult CalculateResult([FromBody] Opponents opponents)
    {
        var battle = new Battle(opponents);
        return new JsonResult(battle.GetResult());
    }
}