namespace Itis.DotnetExam.Models;

/// <summary>
/// Лог боя
/// </summary>
public class Log
{
    /// <summary>
    /// Имя атакующего
    /// </summary>
    public string AttackerName { get; set; }
    
    /// <summary>
    /// Имя защитника
    /// </summary>
    public string DefenderName { get; set; }
    
    /// <summary>
    /// Модификатор атаки
    /// </summary>
    public int AttackModifier { get; set; }
    
    /// <summary>
    /// Бросок кубика
    /// </summary>
    public int[] DiceRoll { get; set; }
    
    /// <summary>
    /// Урон
    /// </summary>
    public int[] Damage { get; set; }
    
    /// <summary>
    /// Остаток хп у противника
    /// </summary>
    public int[] EnemyHp { get; set; }
    
    /// <summary>
    /// Результат удара
    /// </summary>
    public HitResult[] HitResults { get; set; }
}