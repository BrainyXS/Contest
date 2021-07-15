namespace FizzBuzz.Strategies
{
    public interface IFizzBuzzPattern
    {
        bool IsResponsible(int input);
        string Execute(int input);
    }
}