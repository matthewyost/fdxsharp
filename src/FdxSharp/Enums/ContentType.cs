namespace FdxSharp.Enums
{
	/// <summary>
	/// Title: Content Types
	/// Description: Types of document formats. (Suggested values)
	/// </summary>
	public enum ContentType
	{
		PDF,
		GIF,
		JPEG,
		TIFF,
		PNG,
		JSON
	}

	/// <summary>
	/// Class to convert between ContentType and MIME type
	/// </summary>
	public static class ContentTypeConverter
	{
		/// <summary>
		/// Retrieve the MIME type for a given ContentType
		/// </summary>
		/// <param name="contentType"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public static string GetMimeType(ContentType contentType)
		{
			return contentType switch
			{
				ContentType.PDF => "application/pdf",
				ContentType.GIF => "image/gif",
				ContentType.JPEG => "image/jpeg",
				ContentType.TIFF => "image/tiff",
				ContentType.PNG => "image/png",
				ContentType.JSON => "application/json",
				_ => throw new ArgumentOutOfRangeException(nameof(contentType), contentType, null)
			};
		}
	}
}
