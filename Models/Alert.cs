public class Alert
{
    public int Id { get; set; }
    public String Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string SourceIp { get; set; } = string.Empty;
    public string DestinationIp { get; set; } = string.Empty;
    public Severity Severity { get; set; }
    public AlertStatus Status { get; set; }
    public DateTime CreatedAt  { get; set; } = DateTime.UtcNow;
    public DateTime? ResolvedAt { get; set; }
}