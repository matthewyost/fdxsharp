using FluentResults;
using System.Threading;
using System.Threading.Tasks;

namespace FdxSharp.Auth
{


	/// <summary>
	/// Interface for working with authentication clients.
	/// </summary>
	public interface IAuthClient<T, U> where T : class where U : class
	{

		/// <summary>
		/// Retrieve the OAuth token using the provided request
		/// </summary>
		/// <param name="request"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		Task<Result<U>> GetTokenAsync(T request, CancellationToken cancellationToken = default);
	}
}
