namespace Theatre.Domain.Enums;

public enum Status
{
    /// <summary>
    /// По дефолту
    /// </summary>
    None,
    /// <summary>
    /// Статус ожидания оплаты
    /// </summary>
    AwaitingPayment,
    /// <summary>
    /// Оплачен
    /// </summary>
    Paid,
    /// <summary>
    /// Отменено
    /// </summary>
    Cancelled
    
}