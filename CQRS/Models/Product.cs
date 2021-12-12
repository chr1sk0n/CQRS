namespace CQRS.Models;

/// <summary>
/// Product
/// </summary>
public class Product
{
    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Name
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Barcode
    /// </summary>
    public string? Barcode { get; set; }
    /// <summary>
    /// IsActive
    /// </summary>
    public bool IsActive { get; set; }
    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// Rate
    /// </summary>
    public decimal Rate { get; set; }
    /// <summary>
    /// BuyingPrice
    /// </summary>
    public decimal BuyingPrice { get; set; }
    /// <summary>
    /// ConfidentialData
    /// </summary>
    public string? ConfidentialData { get; set; }
}