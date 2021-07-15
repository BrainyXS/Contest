namespace FizzBuzz.Strategies
{
    public class BuzzPattern : IFizzBuzzPattern
    {
        public bool IsResponsible(int input)
        {
            return input % 3 != 0 && input % 5 == 0;
        }

        public string Execute(int input)
        {
            return "Buzz";
        }
    }
}