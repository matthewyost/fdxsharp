namespace FdxSharp.Models
{
	/// <summary>
	/// Code and Amount, Code and amount pair used on IRS W-2, K-1, etc.
	/// </summary>
	public class CodeAmount
	{
		/// <summary>
		/// Code.
		/// </summary>
		public string? Code { get; set; }

		/// <summary>
		/// Amount.
		/// </summary>
		public double Amount { get; set; }
	}
}
