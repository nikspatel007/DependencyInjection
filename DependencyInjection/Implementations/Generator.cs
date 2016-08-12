using System.Collections.Generic;
using DependencyInjection.Interfaces;
using DependencyInjection.Models;

namespace DependencyInjection.Implementations
{
    public class Generator : IGenerator
    {
        private readonly IEvent _event;

        public Generator(IEvent @event)
        {
            _event = @event;
        }

        public List<Numbers> Generate(int start, int end)
        {
            List<Numbers> records = new List<Numbers>();
            for (int i = start; i <= end; i++)
            {
                var number = new Numbers(i , _event.Fire(i));
                records.Add(number);
            }

            return records;
        }
    }
}