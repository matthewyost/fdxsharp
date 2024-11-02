namespace FdxSharp.Enums
{
	/// <summary>
	/// Title: Consent Duration Type
	/// Description: Duration of the Consent Grant, per FDX UX Guidelines v1.0 (pp 18 - 20)
	/// </summary>
	public enum ConsentDurationType
	{
		/// <summary>
		/// One time consent
		/// </summary>
		ONE_TIME,
		/// <summary>
		/// Permanent consent
		/// </summary>
		PERSISTENT,
		/// <summary>
		/// Time bound consent
		/// </summary>
		TIME_BOUND
	}
}
