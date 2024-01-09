namespace Itis.DotnetExam.UI.Constants;

/// <summary>
/// Ссылки для доступа к бизнес логике
/// </summary>
public class BlAccessConstants
{
    /// <summary>
    /// Url для получения случайного монстра
    /// </summary>
    public const string RandomMonsterUrl = "http://localhost:5276/monster/getMonster";
    
    /// <summary>
    /// Url для расчета результатов боя
    /// </summary>
    public const string FightUrl = "http://localhost:5276/fight/calculateResult";
}