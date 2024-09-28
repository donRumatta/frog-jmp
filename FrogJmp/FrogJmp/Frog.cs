namespace FrogJmp;

public class Frog(int jmpLength, int start)
{
    public int Jump(int end)
    {
        double distance = end - start;
        var leaps = distance / jmpLength;

        return (int)Math.Ceiling(leaps);
    }
}