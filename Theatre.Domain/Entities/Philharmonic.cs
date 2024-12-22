namespace Theatre.Domain.Entities;
/// <summary>
/// Сущность филармония 
/// </summary>
public sealed class Philharmonic
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Название филармонии.
    /// </summary>
    public string PhihalrmonicName { get; set; } = string.Empty;
    /// <summary>
    /// Адрес
    /// </summary>
    public string Adress { get; set; }
    /// <summary>
    /// Описание филармонии
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// Номера телефонов организации
    /// </summary>
    public IEnumerable<PhoneNumber> PhoneNumbers { get; set; }
    
    
}