using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Itis.DotnetExam.Models;

/// <summary>
/// Модель Игрока
/// </summary>
public class Player : IOpponent
{
    /// <summary>
    /// Имя
    /// </summary>
    [Required]
    [DisplayName("Имя")]
    public string Name { get; set; }
    
    /// <summary>
    /// Очки здоровья
    /// </summary>
    [Required]
    [DisplayName("Очки здоровья")]
    public int HitPoints { get; set; }
    
    /// <summary>
    /// Модификатор атаки
    /// </summary>
    [Required]
    [DisplayName("Модификатор атаки")]
    public int AttackModifier { get; set; }
    
    /// <summary>
    /// Урон за раунд
    /// </summary>
    [Required]
    [DisplayName("Урон за раунд")]
    public int AttackPerRound { get; set; }
    
    /// <summary>
    /// Урон
    /// </summary>
    [Required]
    [DisplayName("Урон")]
    public string Damage { get; set; }
    
    /// <summary>
    /// Модификатор урона
    /// </summary>
    [Required]
    [DisplayName("Модификатор урона")]
    public int DamageModifier { get; set; }
    
    /// <summary>
    /// Класс брони
    /// </summary>
    [Required]
    [DisplayName("Класс брони")]
    public int ArmorClass { get; set; }
}