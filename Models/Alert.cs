public class Alert
{
    public int Id { get; set; }
    public String ?Title { get; set; }
    public string ?Description { get; set; }
    public string ?SourceIp { get; set; }
    public string ?DestinationIp { get; set; }
    public Severity Severity { get; set; }
    public AlertStatus Status { get; set; }
    public DateTime CreatedAt  { get; set; } = DateTime.UtcNow;
    public DateTime? ResolvedAt { get; set; }
}