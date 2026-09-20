
public class AlertService : IAlertService
{
    private readonly AppDbContext _db ;
    public AlertService(AppDbContext appDbContext)
    {
        _db = appDbContext;
    }

    public Task<AlertResponseDto> CreateAsync(CreateAlertDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<List<AlertResponseDto>> GetAlertsAsync(AlertStatus? status, Severity? severity)
    {
        throw new NotImplementedException();
    }

    public Task<AlertResponseDto?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateStatusAsync(int id, AlertStatus newStatus)
    {
        throw new NotImplementedException();
    }

    
}