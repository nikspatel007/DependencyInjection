using System.Collections.Generic;
using DependencyInjection.Models;

namespace DependencyInjection.Interfaces
{
    /// <summary>
    /// Iteraters through given range of numbers and performs logic on those numbers.
    /// </summary>
    public interface IGenerator
    {
        /// <summary>
        /// Based on a given range of number, Generate function returns a iterator of strings.
        /// </summary>
        /// <param name="start">Starting Number</param>
        /// <param name="end">Ending number</param>
        /// <returns>IEnumerable ot Number Models.</returns>
        List<Numbers> Generate(int start, int end);
    }
}