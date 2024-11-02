using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FdxSharp.Tests.Utilities
{
	/// <summary>
	/// Used to mock HttpClient for testing.
	/// </summary>
	public class TestHttpMessageHandler : HttpMessageHandler
	{
		private readonly Func<HttpRequestMessage, HttpResponseMessage> _sendFunc;

		/// <summary>
		/// Creates a new instance of <see cref="TestHttpMessageHandler"/>.
		/// </summary>
		/// <param name="sendFunc"></param>
		/// <exception cref="ArgumentNullException"></exception>
		public TestHttpMessageHandler(Func<HttpRequestMessage, HttpResponseMessage> sendFunc)
		{
			_sendFunc = sendFunc ?? throw new ArgumentNullException(nameof(sendFunc));
		}

		/// <inheritdoc />
		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			return Task.FromResult(_sendFunc(request));
		}
	}
}
