using System.ComponentModel;

using dymaptic.GeoBlazor.Core.Components.Geometries;
using dymaptic.GeoBlazor.Core.Components.Layers;
using dymaptic.GeoBlazor.Core.Objects;

namespace GeoBlazorPoc1.Models;

// Let Fody generate the INotifyPropertyChanged implementation
public partial class LocationElement : INotifyPropertyChanged
{
    public MapColor Color { get; set; }
    public MapColor OutlineColor { get; set; }
    public double Size { get; set; }
    public TheftReportPosition Position { get; set; }
    public bool IsSelected { get; set; }
    public Point? PointRef { get; set; }
    public Graphic? GraphicRef { get; set; }
}
