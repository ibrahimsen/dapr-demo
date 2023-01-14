using System;
using Common.Interfaces;
using Dapr.Client;

namespace Common.Helpers
{
	public class DaprClientHelper : IDaprClientHelper
	{
        public async Task<T> ResponseByDaprClient<T>(HttpMethod httpMethod, string appId, string endpoint)
        {
			var daprClient = new DaprClientBuilder().Build();
			HttpRequestMessage daprRequest = daprClient.CreateInvokeMethodRequest(httpMethod, appId, endpoint);
			var result = await daprClient.InvokeMethodAsync<T>(daprRequest);
			return result;
        }
    }
}

