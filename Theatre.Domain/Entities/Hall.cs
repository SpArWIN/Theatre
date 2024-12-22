namespace Theatre.Domain.Entities;
/// <summary>
/// Залы
/// </summary>
public class Hall
{
    /// <summary>
    /// Идентификатор зала
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Название зала
    /// </summary>
    public string HallName { get; set; }
    /// <summary>
    /// Вместимость зала (может быть вычислена на основе HallLayout)
    /// </summary>
    public int Capacity { get; set; }
    /// <summary>
    /// JSON-представление схемы зала (ряды, места, их типы и цены)
    /// </summary>
    public string HallLayout { get; set; }
    /// <summary>
    /// Связь с расписанием
    /// </summary>
    public ICollection<Schedule> Schedules { get; set; }
}