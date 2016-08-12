using System.Collections.Generic;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Implementations.Events
{
    public class BaseEvent : IEvent
    {
        private readonly Dictionary<int, string> _mod;

        public BaseEvent(Dictionary<int, string> mod)
        {
            _mod = mod;
        }

        public virtual string Fire(int number)
        {
            var record = string.Empty;
            foreach (var keyValue in _mod)
            {
                if (number%keyValue.Key != 0) continue;
                record += record == string.Empty ? string.Empty : " ";
                record += keyValue.Value;
            }

            //If none of criteria worked, return int.
            record = (record == string.Empty) ? number.ToString() : record;
            return record;
        }
    }
}