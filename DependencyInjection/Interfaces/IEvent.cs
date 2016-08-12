namespace DependencyInjection.Interfaces
{
    /// <summary>
    /// IEvent provides abstration to business logic.
    /// </summary>
    public interface IEvent
    {
        /// <summary>
        /// This function will take a number, do the logic and return a string based on the given number.
        /// </summary>
        /// <param name="number">interger to be processed.</param>
        /// <returns>string value based on the number provided.</returns>
        string Fire(int number);
    }
}