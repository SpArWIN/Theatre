namespace Theatre.Domain.Entities;
/// <summary>
/// Расписание мероприятий
/// </summary>
public sealed class Schedule
{
    /// <summary>
    /// Идентификатор расписания
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Идентификатор мероприятия.
    /// </summary>
    public Guid EventId { get; set; }
    public Event Event { get; set; }
    /// <summary>
    /// Дата
    /// </summary>
    public DateOnly StartDate { get; set; }
    /// <summary>
    /// Время начала
    /// </summary>
    public DateTime TimeStart { get; set; }
    /// <summary>
    /// Цена билета - зависит от диапазона
    /// </summary>
    public double Price { get; set; } 
}