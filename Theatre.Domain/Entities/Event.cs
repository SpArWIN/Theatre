using Theatre.Domain.Enums;

namespace Theatre.Domain.Entities;
/// <summary>
/// Мероприятие
/// </summary>
public sealed class Event
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Название мероприятия
    /// </summary>
    public string EventName { get; set; }
    /// <summary>
    /// Категории мероприятий
    /// </summary>
    public IEnumerable<Category> Categories { get; set; }
    /// <summary>
    /// Описание мероприятия
    /// </summary>
    public string? EventDescription { get; set; }

    /// <summary>
    /// Отменено ли расписание мероприятия
    /// </summary>
    public bool isСancelled { get; set; } = false;
}