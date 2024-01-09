namespace Itis.DotnetExam.Models;

/// <summary>
/// Оппоненты боя
/// </summary>
public class Opponents
{
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="player">Игрок</param>
    /// <param name="monster">Монстр</param>
    public Opponents(Player player, Monster monster)
    {
        Player = player;
        Monster = monster;
    }
    
    /// <summary>
    /// Игрок
    /// </summary>
    public Player Player { get; set; }

    /// <summary>
    /// Монстр
    /// </summary>
    public Monster Monster { get; set; }
}