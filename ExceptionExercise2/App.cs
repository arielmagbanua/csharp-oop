namespace ExceptionExercise2
{
    public class App
    {
        public void Number(int num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Invalid integer");
            }
        }
    }
}
