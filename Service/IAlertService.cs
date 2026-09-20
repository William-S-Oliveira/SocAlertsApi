public interface IAlertService
{
    Task<List<AlertResponseDto>> GetAlertsAsync(AlertStatus? status , Severity? severity );
    Task<AlertResponseDto?> GetByIdAsync(int id);
    Task<AlertResponseDto> CreateAsync(CreateAlertDto dto);
    Task<bool> UpdateStatusAsync (int id, AlertStatus newStatus);

}