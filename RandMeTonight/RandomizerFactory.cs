namespace RandMeTonight;

public class RandomizerFactory
{
    private int _correctChecks;
    public Randomizer Calculate(int number, int scope, int renewals)
    {
        _correctChecks = 0;
        Random rnd = new Random();

        

        for (int i = 0; i < renewals; i++)
        {
            int generatedNumber = rnd.Next(0, scope);
          CheckNumber(number,generatedNumber);
        }
        return new Randomizer(_correctChecks);
    }



    private void CheckNumber(int number, int generatedNumber)
    {
        if (number == generatedNumber)
        {
            _correctChecks += 1;
        }
    }
}