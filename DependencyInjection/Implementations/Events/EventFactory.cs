using System.Collections.Generic;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Implementations.Events
{
    public class EventFactory
    {
        private readonly IConfigProvider _configProvider;

        public EventFactory(IConfigProvider configProvider)
        {
            _configProvider = configProvider;
        }


        /// <summary>
        ///     Dictionaries here can be put in json configs as well to  allow modifications without code compile or Code
        ///     modification.
        /// </summary>
        /// <returns></returns>
        public IEvent CreateEvent()
        {
            var config = _configProvider.Get("EventType");
            var dictionary = new Dictionary<int, string>();
            switch (config.ToLower())
            {
                case "register":
                    dictionary = new Dictionary<int, string>
                    {
                        {3, "Register"},
                        {5, "Patient"}
                    };
                    break;

                case "diagnose":
                    dictionary = new Dictionary<int, string>
                    {
                        {2, "Diagnose"},
                        {7, "Patient"}
                    };
                    break;
            }

            return new BaseEvent(dictionary);
        }
    }
}