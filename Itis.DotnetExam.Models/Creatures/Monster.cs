using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Itis.DotnetExam.Models;

/// <summary>
/// Модель монстра
/// </summary>
public class Monster : IOpponent
{
    /// <summary>
    /// Id сущности
    /// </summary>
    [Key]
    public Guid Id { get; set; }
    
    /// <summary>
    /// Имя
    /// </summary>
    [Required] 
    public string Name { get; set; }
    
    /// <summary>
    /// Очки здоровья
    /// </summary>
    [Required] 
    public int HitPoints { get; set; }
    
    /// <summary>
    /// Модификатор атаки
    /// </summary>
    [Required]
    public int AttackModifier { get; set; }
    
    /// <summary>
    /// Атака за раунд
    /// </summary>
    [Required] 
    public int AttackPerRound { get; set; }
    
    /// <summary>
    /// Урон
    /// </summary>
    [Required]
    public string Damage { get; set; }
    
    /// <summary>
    /// Модифкатор урона
    /// </summary>
    [Required] 
    public int DamageModifier { get; set; }
    
    /// <summary>
    /// Класс брони
    /// </summary>
    [Required] 
    public int ArmorClass { get; set; }
}