using System.Text.Json.Serialization;
using FdxSharp.Models;

namespace FdxSharp.Forms
{
    public class TaxFormAttribute : FiAttribute
    {
        [JsonPropertyName("boxNumber")]
        public string? BoxNumber { get; set; }

        [JsonPropertyName("code")]
        public string? Code { get; set; }
    }
}
