namespace Theatre.Domain.Entities;
/// <summary>
/// Пользователь
/// </summary>
public class User
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string FirstName { get; set; }
    /// <summary>
    /// Фамилия пользователя
    /// </summary>
    public string LastName { get; set; }
    /// <summary>
    /// Почта пользователя
    /// </summary>
    public string? Email { get; set; }
    /// <summary>
    /// Номер телефона пользователя
    /// </summary>
    public PhoneNumber PhoneNumber { get; set; }
    /// <summary>
    /// История бронирования
    /// </summary>
    public ICollection<Booking> HistoryBookings { get; set; }
}