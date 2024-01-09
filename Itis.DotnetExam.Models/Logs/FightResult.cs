namespace Itis.DotnetExam.Models;

/// <summary>
/// Результат боя
/// </summary>
public class FightResult
{
    /// <summary>
    /// Логи
    /// </summary>
    public List<Log> Logs { get; set; }

    /// <summary>
    /// Победитель
    /// </summary>
    public string Winner { get; set; }

    /// <summary>
    /// Игрок
    /// </summary>
    public Player Player { get; set; }

    /// <summary>
    /// Монстр
    /// </summary>
    public Monster Monster { get; set; }
}