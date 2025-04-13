using dymaptic.GeoBlazor.Core.Components.Layers;
using dymaptic.GeoBlazor.Core.Objects;

namespace GeoBlazorPoc1.Models;

public partial class LocationElement
{
    public MapColor Color { get; set; }
    public MapColor ColorCalc => Color;
    public MapColor OutlineColor { get; set; } = new MapColor("white");
    public MapColor OutlineColorCalc => IsSelected ? new MapColor("grey") : OutlineColor;
    public double Size { get; set; } = 12;
    public double SizeCalc => IsSelected ? 12 : Size;
    public TheftReportPosition Position { get; set; }
    public bool IsSelected { get; set; }
    public Graphic? GraphicRef { get; set; }
}
