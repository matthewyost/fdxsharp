using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FdxSharp.Tests.Utilities
{
	/// <summary>
	/// Implementation of <see cref="IHttpClientFactory"/> for testing.
	/// </summary>
	public class TestHttpClientFactory : IHttpClientFactory
	{
		public Func<HttpRequestMessage, HttpResponseMessage> Func { get; set; }

		public HttpClient CreateClient(string name)
		{
			return new HttpClient(new TestHttpMessageHandler(Func)) { BaseAddress = new Uri("http://localhost/") };
		}
	}
}
