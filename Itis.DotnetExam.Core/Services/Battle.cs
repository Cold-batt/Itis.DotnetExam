using Itis.DotnetExam.BLL.Contracts;
using Itis.DotnetExam.Models;

namespace Itis.DotnetExam.BLL.Services;

/// <summary>
/// Логика боя
/// </summary>
public class Battle
{
    private FightResult _fightResult { get; set; }
    private Random _random { get; set; }
    private IOpponent _player { get; set; }
    private IOpponent _monster { get; set; }
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="opponents">Соперники</param>
    public Battle(Opponents opponents)
    {
        _player = opponents.Player;
        _monster = opponents.Monster;
        _random = new Random();
        _fightResult = new FightResult();
        _fightResult.Player = new Player()
        {
            Name = _player.Name,
            ArmorClass = _player.ArmorClass,
            AttackModifier = _player.AttackModifier,
            DamageModifier = _player.DamageModifier,
            HitPoints = _player.HitPoints,
            AttackPerRound = _player.AttackPerRound,
            Damage = _player.Damage
        };
        _fightResult.Monster = new Monster()
        {
            Name = _monster.Name,
            ArmorClass = _monster.ArmorClass,
            AttackModifier = _monster.AttackModifier,
            DamageModifier = _monster.DamageModifier,
            HitPoints = _monster.HitPoints,
            AttackPerRound = _monster.AttackPerRound,
            Damage = _monster.Damage
        };
    }

    /// <summary>
    /// Расчитать исход боя
    /// </summary>
    /// <returns>Логи боя</returns>
    public FightResult GetResult()
    {
        _fightResult.Logs = new List<Log>();
        while (_player.HitPoints > 0 && _monster.HitPoints > 0)
        {
            _fightResult.Logs.Add(Round(_player, _monster));
            _fightResult.Logs.Add(Round(_monster, _player));
        }

        _fightResult.Winner = _player.HitPoints > 0 ? _player.Name : _monster.Name;
        return _fightResult;
    }
    
    private Log Round(IOpponent attacker, IOpponent defender)
    {
        var log = new Log
        {
            AttackerName = attacker.Name,
            DefenderName = defender.Name
        };
        var throwsCount = int.Parse(attacker.Damage.Split('d')[0]);
        var diceValue = int.Parse(attacker.Damage.Split('d')[1]);
        
        log.HitResults = new HitResult[attacker.AttackPerRound];
        log.Damage = new int[attacker.AttackPerRound];
        log.EnemyHp = new int[attacker.AttackPerRound];
        log.DiceRoll = new int[attacker.AttackPerRound];
        log.AttackModifier = attacker.AttackModifier;
        
        for (var i = 0; i < attacker.AttackPerRound && defender.HitPoints > 0; i++)
        {
            var hitRoll = _random.Next(1, 21);
            log.DiceRoll[i] = hitRoll;
            log.EnemyHp[i] = defender.HitPoints;
            if (hitRoll == 1 || log.DiceRoll[i] < defender.ArmorClass)
            {
                log.HitResults[i] = HitResult.Miss;
                continue;
            }

            if (hitRoll == 20)
                log.HitResults[i] = HitResult.Critical;
            else 
                log.HitResults[i] = HitResult.Hit;
            
            for (var j = 0; j < throwsCount; j++)
                log.Damage[i] += (_random.Next(1, diceValue + 1) + attacker.DamageModifier) * hitRoll / 10;
            
            defender.HitPoints -= Math.Min(defender.HitPoints, log.Damage[i]);
            log.EnemyHp[i] = defender.HitPoints;
            
            //if (defender.HitPoints == 0) break;
        }

        return log;
    }
}