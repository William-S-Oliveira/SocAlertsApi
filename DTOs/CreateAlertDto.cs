public class CreateAlertDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public string SourceIp { get; set; } = string.Empty;

    public string DestinationIp { get; set; } = string.Empty;
    public Severity Severity { get; set; }
}