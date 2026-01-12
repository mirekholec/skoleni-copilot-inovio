using System.ComponentModel.DataAnnotations;

namespace Demolice.Demo04_AgentMode.Subscriptions;

/// <summary>
/// DTO pro pøedplatné ze systému XY
/// </summary>
public class SubscriptionDto
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    public DateTime StartDate { get; set; }

    [Required]
    public DateTime EndDate { get; set; }

    [Required]
    public string Plan { get; set; }

    /// <summary>
    /// Vrátí základní informace o pøedplatném
    /// </summary>
    public string GetBasicInfo()
    {
        return $"{Id}-{Plan}-{UserId}";
    }

    /// <summary>
    /// Zkontroluje, zda je pøedplatné aktuálnì aktivní
    /// </summary>
    public bool IsActive()
    {
        var now = DateTime.UtcNow;
        return StartDate <= now && EndDate >= now;
    }
}