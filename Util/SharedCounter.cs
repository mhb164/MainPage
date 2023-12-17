namespace Util
{
    public class SharedCounter
    {
        public static int CurrentCount { get; private set; } = 0;

        public static void IncrementCount()
        {
            CurrentCount++;
        }
    }
}
