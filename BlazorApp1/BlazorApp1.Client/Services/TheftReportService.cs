using System.Net.Http.Json;

using GeoBlazorPoc1.Models;

namespace GeoBlazorPoc1.Services;

public class TheftReportService : ITheftReportService
{
    private readonly HttpClient httpClient;

    public TheftReportService(HttpClient httpClient)
    {
        this.httpClient=httpClient;
    }

    public async Task<IEnumerable<TheftReportPosition>> GetPositionsByTheftReportId(string id, CancellationToken cancellationToken)
    {
        var theftReportsPositions = await this.httpClient.GetFromJsonAsync<TheftReportPositionWrapper[]>("sample-data/theft-reports-positions.json", cancellationToken);

        return theftReportsPositions.FirstOrDefault(x => x.TheftReportId.Equals(id, StringComparison.OrdinalIgnoreCase)).Positions?.AsEnumerable() ?? new List<TheftReportPosition>();
    }

    public async Task<TheftReportDto?> GetTheftReport(string id, CancellationToken cancellationToken)
    {
        var theftReports = await this.httpClient.GetFromJsonAsync<TheftReportDto[]>("sample-data/theft-reports.json", cancellationToken);

        return theftReports.FirstOrDefault();
    }
}
