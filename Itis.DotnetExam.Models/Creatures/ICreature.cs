namespace Itis.DotnetExam.Models;


/// <summary>
/// Интерфейс для сущности противника
/// </summary>
public interface IOpponent
{
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Очки здоровья
    /// </summary>
    public int HitPoints { get; set; }
    
    /// <summary>
    /// Модификатор атаки
    /// </summary>
    public int AttackModifier { get; set; }
    
    /// <summary>
    /// Атака за раунд
    /// </summary>
    public int AttackPerRound { get; set; }
    
    /// <summary>
    /// Урон
    /// </summary>
    public string Damage { get; set; }
    
    /// <summary>
    /// Модифкатор урона
    /// </summary>
    public int DamageModifier { get; set; }
    
    /// <summary>
    /// Класс брони
    /// </summary>
    public int ArmorClass { get; set; }
}