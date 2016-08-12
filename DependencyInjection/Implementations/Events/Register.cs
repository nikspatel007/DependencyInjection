using System.Collections.Generic;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Implementations.Events
{
    public class Register : IEvent
    {
        public string Fire(int number)
        {
            var record = string.Empty;

            if (number % 3 == 0)
            {
                SetString("Register", ref record);
            }

            if (number % 5 == 0)
            {
                SetString("Patient", ref record);
            }

            if (string.IsNullOrEmpty(record))
            {
                SetString(number.ToString(), ref record);
            }
            return record;
        }

        private void SetString(string value, ref string record)
        {
            record += (record == string.Empty) ? string.Empty : " ";
            record += value;
        }

    }
}