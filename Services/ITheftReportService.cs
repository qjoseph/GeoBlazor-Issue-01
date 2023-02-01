using GeoBlazorPoc1.Models;

namespace GeoBlazorPoc1.Services;

public interface ITheftReportService
{
    Task<TheftReportDto?> GetTheftReport(string id, CancellationToken cancellationToken);
    Task<IEnumerable<TheftReportPosition>> GetPositionsByTheftReportId(string id, CancellationToken cancellationToken);
}
