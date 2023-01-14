using System;
namespace Common.Interfaces
{
	public interface IDaprClientHelper
	{
		Task<T> ResponseByDaprClient<T>(HttpMethod httpMethod, string appId, string endpoint);
	}
}

