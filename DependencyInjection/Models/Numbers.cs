namespace DependencyInjection.Models
{
    public class Numbers
    {
        public Numbers(int value , string result)
        {
            Value = value;
            Result = result;
        }
        public int Value { get;  }

        public string Result { get; }
    }
}