namespace RandMeTonight;

public class Randomizer
{
    private int numberResult;


    public Randomizer(int numberResult)
    {
       
        this.numberResult = numberResult;

    }

    public override string ToString()
    {
        return numberResult.ToString();
    }
}