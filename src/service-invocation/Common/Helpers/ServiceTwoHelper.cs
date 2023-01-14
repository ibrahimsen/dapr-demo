using System;
using Common.Interfaces;

namespace Common.Helpers
{
    public class ServiceTwoHelper : IServiceTwoHelper
    {
        private readonly IDaprClientHelper _daprClientHelper;

        public ServiceTwoHelper(IDaprClientHelper daprClientHelper)
        {
            _daprClientHelper = daprClientHelper;
        }
        public Task<object> GetMessage()
        {
            var response = _daprClientHelper.ResponseByDaprClient<object>(HttpMethod.Get, "servicetwoapp", "/message");
            return response;
        }
    }
}

