namespace Theatre.Domain.Entities;
/// <summary>
/// Бронирование
/// </summary>
public class Booking
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Идентификатор распи
    /// </summary>
    public Guid SheduleId { get; set; }
    /// <summary>
    /// Временная отметка окончания брони
    /// </summary>
    public DateTime ExpirationTimeBrony { get; set; } 
    /// <summary>
    /// Уникальный код для брони
    /// </summary>
    public string UniqCode { get; set; }
    /// <summary>
    /// Связь с пользователем, если авторизован
    /// </summary>
    public virtual User? User { get; set; }
}