using System.Text.Json.Serialization;
using FdxSharp.Models;

namespace FdxSharp.Forms
{
    /// <summary>
    /// Form 1099-S, Proceeds From Real Estate Transactions
    /// </summary>
    public class Tax1099S : Tax
    {
        /// <summary>
        /// Filer's name, address, and phone
        /// </summary>
        [JsonPropertyName("filerNameAddress")]
        public NameAddressPhone? FilerNameAddress { get; set; }

        /// <summary>
        /// FILER'S TIN
        /// </summary>
        [JsonPropertyName("filerTin")]
        public string? FilerTin { get; set; }

        /// <summary>
        /// TRANSFEROR'S TIN
        /// </summary>
        [JsonPropertyName("transferorTin")]
        public string? TransferorTin { get; set; }

        /// <summary>
        /// Transferor's name and address
        /// </summary>
        [JsonPropertyName("transferorNameAddress")]
        public NameAddress? TransferorNameAddress { get; set; }

        /// <summary>
        /// Account or escrow number
        /// </summary>
        [JsonPropertyName("accountNumber")]
        public string? AccountNumber { get; set; }

        /// <summary>
        /// Box 1, Date of closing
        /// </summary>
        [JsonPropertyName("dateOfClosing")]
        public DateTime? DateOfClosing { get; set; }

        /// <summary>
        /// Box 2, Gross proceeds
        /// </summary>
        [JsonPropertyName("grossProceeds")]
        public double GrossProceeds { get; set; }

        /// <summary>
        /// Box 3, Address or legal description
        /// </summary>
        [JsonPropertyName("addressOrLegalDescription")]
        public string? AddressOrLegalDescription { get; set; }

        /// <summary>
        /// Box 4, Transferor received or will receive property or services as part of the consideration (if checked)
        /// </summary>
        [JsonPropertyName("receivedOtherConsideration")]
        public bool ReceivedOtherConsideration { get; set; }

        /// <summary>
        /// Box 5, If checked, transferor is a foreign person (nonresident alien, foreign partnership, foreign estate, or foreign trust)
        /// </summary>
        [JsonPropertyName("foreignPerson")]
        public bool ForeignPerson { get; set; }

        /// <summary>
        /// Box 6, Buyer's part of real estate tax
        /// </summary>
        [JsonPropertyName("realEstateTax")]
        public double RealEstateTax { get; set; }
    }
}
