using System.Text.Json.Serialization;

namespace FdxSharp;

/// <summary>
/// Tax Data for QR, Tax data container for QR Code purposes
/// </summary>
public class TaxDataForQR : TaxData
{
	/// <summary>
	/// [Financial Data Exchange (FDX)](https://financialdataexchange.org/) schema version number (e.g. "V5.0").
	/// </summary>
	[JsonPropertyName("version")]
	public string? Version { get; set; }

	/// <summary>
	/// The FDX registration ID of company or software generating this tax data
	/// </summary>
	[JsonPropertyName("softwareId")]
	public string? SoftwareId { get; set; }
}
