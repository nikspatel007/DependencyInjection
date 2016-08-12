using DependencyInjection.Interfaces;

namespace DependencyInjection.Implementations.Events
{
    public class Diagnose : IEvent
    {
        public string Fire(int number)
        {
            var record = string.Empty;

            if (number%2 == 0)
            {
              SetString("Diagnose", ref record);  
            }

            if (number % 7 == 0)
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