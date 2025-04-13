namespace GeoBlazorPoc1.Models;

public readonly record struct TheftReportDto
(
    string Vin,
    string? LicencePlate,
    string Brand,
    string Model,
    DateTimeOffset? ManufacturedAt
);

public readonly record struct TheftReportPositionWrapper
(
    string TheftReportId,
    TheftReportPosition[] Positions
);

public readonly record struct TheftReportPosition
(
    double Latitude,
    double Longitude,
    int EstimatedPositionError,
    double Altitude,
    int EstimatedAltitudeError,
    string Direction,
    string EnginePositionStatus,
    DateTime EmittedAt,
    DateTime IntegratedAt
);

