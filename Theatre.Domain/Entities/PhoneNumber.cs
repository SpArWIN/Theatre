namespace Theatre.Domain.Entities;
/// <summary>
/// Номера телефонов
/// </summary>
public sealed class PhoneNumber
{
    /// <summary>
    /// Уникальный идентификатор
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Номер телефона
    /// </summary>
    public string Number { get; set; }
}